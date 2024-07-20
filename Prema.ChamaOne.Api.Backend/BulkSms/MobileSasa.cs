using System.Text;
using Microsoft.Extensions.Options;
using Prema.ChamaOne.Api.Backend.AppSettings;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Logging;
using Prema.ChamaOne.Api.Backend.Models;
using Prema.ChamaOne.Api.Backend.Telegram;

namespace Prema.ChamaOne.Api.Backend.BulkSms
{
    public class MobileSasa : IBulkSms
    {
        private readonly MobileSasaSettings mobileSasaSettings;
        private readonly Logger logger;
        private readonly TelegramBot telegram;
        private readonly HttpClient httpClient;
        private readonly IServiceProvider serviceProvider;
        public MobileSasa(IOptionsMonitor<MobileSasaSettings> mobileSasaSettings, Logger logger, TelegramBot telegram, HttpClient httpClient, IServiceProvider serviceProvider)
        {
            this.mobileSasaSettings = mobileSasaSettings.CurrentValue;
            this.logger = logger;
            this.telegram = telegram;
            this.httpClient = httpClient;
            this.serviceProvider = serviceProvider;
        }

        public async Task<bool> SendSms(string recipient_contact, string recipient_name, string message, string sender)
        {
            SMSRecord smsRecord = new SMSRecord
            {
                recipient_contact = recipient_contact,
                recipient_name = recipient_name,
                message = message,
                date_time_sent = DateTime.Now,
                failure_count = 0,
                status = sms_status.Pending
            };

            try
            {
                var requestContent = new
                {
                    senderID = mobileSasaSettings.SenderId,
                    message = message,
                    phones = recipient_contact
                };

                var jsonContent = new StringContent(
                    Newtonsoft.Json.JsonConvert.SerializeObject(requestContent),
                    Encoding.UTF8,
                    "application/json");

                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {mobileSasaSettings.ApiToken}");

                using (var scope = serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();

                    context.SMSRecord.Add(smsRecord);
                    await context.SaveChangesAsync(); // Save the initial record to get the Id

                    var response = await httpClient.PostAsync(mobileSasaSettings.ApiUrl, jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        smsRecord.status = sms_status.Sent;
                        await context.SaveChangesAsync();
                        return true;
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        smsRecord.status = sms_status.Failed;
                        smsRecord.failure_count += 1;

                        var smsFailure = new SMSFailure
                        {
                            fk_sms_record_id = smsRecord.id,
                            error = errorContent,
                            date_time = DateTime.Now
                        };

                        context.SMSFailure.Add(smsFailure);
                        await context.SaveChangesAsync();

                        logger.WriteToLog($"Failed to send message. Status code: {response.StatusCode}", $"Error: {errorContent}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                smsRecord.status = sms_status.Failed;
                smsRecord.failure_count += 1;

                using (var scope = serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();

                    var smsFailure = new SMSFailure
                    {
                        fk_sms_record_id = smsRecord.id,
                        error = ex.Message,
                        date_time = DateTime.Now
                    };

                    context.SMSFailure.Add(smsFailure);
                    await context.SaveChangesAsync();

                    logger.WriteToLog($"SendSms: {ex}", "Error");
                }
                return false;
            }
        }


    }
}
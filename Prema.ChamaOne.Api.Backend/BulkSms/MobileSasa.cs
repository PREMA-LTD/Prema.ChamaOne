using System.Text;
using Microsoft.Extensions.Options;
using Prema.ChamaOne.Api.Backend.AppSettings;
using Prema.ChamaOne.Api.Backend.Logging;
using Prema.ChamaOne.Api.Backend.Telegram;

namespace Prema.ChamaOne.Api.Backend.BulkSms
{
    public class MobileSasa
    {
        private readonly MobileSasaSettings mobileSasaSettings;
        private readonly Logger logger;
        private readonly TelegramBot telegram;
        private readonly HttpClient httpClient;
        public MobileSasa(IOptionsMonitor<MobileSasaSettings> mobileSasaSettings, Logger logger, TelegramBot telegram, HttpClient httpClient)
        {
            this.mobileSasaSettings = mobileSasaSettings.CurrentValue;
            this.logger = logger;
            this.telegram = telegram;
            this.httpClient = httpClient;
        }

        public async Task<bool> SendSms(string contact, string message)
        {
            try
            {
                var requestContent = new
                {
                    senderID = mobileSasaSettings.SenderId,
                    message = message,
                    phones = contact
                };

                var jsonContent = new StringContent(
                    Newtonsoft.Json.JsonConvert.SerializeObject(requestContent),
                    Encoding.UTF8,
                    "application/json");

                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {mobileSasaSettings.ApiToken}");

                var response = await httpClient.PostAsync(mobileSasaSettings.ApiUrl, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    logger.WriteToLog($"Failed to send message. Status code: {response.StatusCode}", "Error: {errorContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                logger.WriteToLog($"SendSms: {ex}", "Error");
                return false;
            }
        }

    }
}
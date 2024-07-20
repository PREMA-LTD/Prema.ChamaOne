using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Prema.ChamaOne.Api.Backend.BulkSms;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Logging;
using Prema.ChamaOne.Api.Backend.Models;

namespace Prema.ChamaOne.Api.Backend.Services
{
    public class ContributionReminderService : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly IServiceProvider _serviceProvider;
        //private readonly ILogger<ContributionUpdaterService> _logger;
        private readonly Logger _logger;
        private readonly TimeSpan _checkInterval = TimeSpan.FromHours(24); // Check daily if reminders need to be sent
        private readonly IMapper _mapper;
        private readonly IBulkSms _bulkSms;

        public ContributionReminderService(IServiceProvider serviceProvider, Logger logger, IMapper mapper, IBulkSms bulkSms)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
            _mapper = mapper;
            _bulkSms = bulkSms;
        }

        private TimeSpan CalculateInitialDelay()
        {
            DateTime now = DateTime.Now;
            DateTime nextRun = new DateTime(now.Year, now.Month, now.Day, 10, 0, 0);

            if (now >= nextRun)
            {
                nextRun = nextRun.AddDays(1); // Next 9 AM if it's already past today's 10 AM
            }

            return nextRun - now;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.WriteToLog("Contribution Reminder Service is starting.", "Information");

            TimeSpan initialDelay = CalculateInitialDelay();
            _timer = new Timer(CheckAndSendReminders, null, initialDelay, _checkInterval);
            return Task.CompletedTask;
        }

        private async void CheckAndSendReminders(object state)
        {
            DateTime now = DateTime.Now;
            DateTime endOfMonth = new DateTime(now.Year, now.Month, DateTime.DaysInMonth(now.Year, now.Month));

            if (isDayOfDeadline(endOfMonth) || isThreeDaysToDeadline(endOfMonth) || isOneWeekToDeadline(endOfMonth) || isTwoWeeksToDeadline(endOfMonth))
            {
                List<MemberDto> members = GetListOfMembersWithPendingContributions();

                foreach(MemberDto member in members)
                {
                    string? message = GetReminderMessage(endOfMonth, member.other_names);

                    if (message == null)
                    {
                        _logger.WriteToLog("Contribution Reminder Service message is null.", "Error");
                    }
                    else
                    {
                        await _bulkSms.SendSms($"+" + member.contact, $"{member.surname} {member.other_names}", message, "");
                    }
                }
                
                _logger.WriteToLog("Contribution Reminder Service sending reminders.", "Information");                

            }
        }

        private string? GetReminderMessage(DateTime endOfMonth, string memberName)
        {            
            if(isDayOfDeadline(endOfMonth))
            {
                return $"Good morning {memberName}, today is the deadline for {endOfMonth.ToString("MMMM")} contributions. Kindly clear before end of day as to avoid penalties. Thank you and have a great day.";
            } 

            if (isThreeDaysToDeadline(endOfMonth))
            {
                return $"Good morning {memberName}, we have 3 days till the deadline for {endOfMonth.ToString("MMMM")} contributions. Kindly clear before then as to avoid penalties. Thank you and have a great day.";
            }

            if (isOneWeekToDeadline(endOfMonth))
            {
                return $"Good morning {memberName}, we have 1 week till the deadline for {endOfMonth.ToString("MMMM")} contributions. Kindly clear before then as to avoid penalties. Thank you and have a great day.";
            }

            if (isTwoWeeksToDeadline(endOfMonth))
            {
                return $"Good morning {memberName}, we have 2 weeks till the deadline for {endOfMonth.ToString("MMMM")} contributions. Kindly clear before then as to avoid penalties. Thank you and have a great day.";
            }

            return null;
        }

        private List<MemberDto> GetListOfMembersWithPendingContributions()
        {            
            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();

                var members = dbContext.Member
                    .Where(m => m.Contributions.Any(c =>
                        c.fk_transaction_status_id == TransactionStatusEnum.Pending &&
                        c.contribution_period.Month == DateTime.Now.Month &&
                        c.contribution_period.Year == DateTime.Now.Year))
                    .ToList();

                var memberDtos = _mapper.Map<List<MemberDto>>(members);

                return memberDtos;
            }
        }

        private bool isTwoWeeksToDeadline(DateTime endOfMonth)
        {
            return DateTime.Now.Date == endOfMonth.AddDays(-14).Date;
        }
        private bool isOneWeekToDeadline(DateTime endOfMonth)
        {
            return DateTime.Now.Date == endOfMonth.AddDays(-7).Date;
        }
        private bool isThreeDaysToDeadline(DateTime endOfMonth)
        {
            return DateTime.Now.Date == endOfMonth.AddDays(-3).Date;
        }
        private bool isDayOfDeadline(DateTime endOfMonth)
        {
            return DateTime.Now.Date == endOfMonth.Date;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}

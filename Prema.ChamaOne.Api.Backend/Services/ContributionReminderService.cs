using AutoMapper;
using AutoMapper.Execution;
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
            DateTime nextRun = new DateTime(now.Year, now.Month, now.Day, 7, 0, 0);

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
                List<MemberContributionBalance> members = GetListOfMembersWithPendingContributions();

                foreach(MemberContributionBalance memberData in members)
                {
                    if (memberData.contributionBalance <= 0) return;

                    string? message = GetReminderMessage(endOfMonth, memberData);

                    if (message == null)
                    {
                        _logger.WriteToLog("Contribution Reminder Service message is null.", "Error");
                    }
                    else
                    {
                        await _bulkSms.SendSms($"+" + memberData.memberDto.contact, $"{memberData.memberDto.surname} {memberData.memberDto.other_names}", message, "");
                    }
                }
                
                _logger.WriteToLog("Contribution Reminder Service sending reminders.", "Information");                

            }
        }

        private string? GetReminderMessage(DateTime endOfMonth, MemberContributionBalance memberData)
        {
            string ending = $"Please clear your pending contributions of Ksh. {memberData.contributionBalance.ToString("F2")} to Shagilia before then. Your support is highly appreciated. For assistance, contact Enock at 0712490863. Thank you!";

            if (isDayOfDeadline(endOfMonth))
            {
                return $"Dear {memberData.memberDto.other_names}, today midnight is the deadline for {endOfMonth.ToString("MMMM")} contributions. {ending}";
            } 

            if (isThreeDaysToDeadline(endOfMonth))
            {
                return $"Dear {memberData.memberDto.other_names}, we have 3 days till the deadline for {endOfMonth.ToString("MMMM")} contributions. {ending}";
            }

            if (isOneWeekToDeadline(endOfMonth))
            {
                return $"Dear {memberData.memberDto.other_names}, we have 1 week till the deadline for {endOfMonth.ToString("MMMM")} contributions. {ending}";
            }

            if (isTwoWeeksToDeadline(endOfMonth))
            {
                return $"Dear {memberData.memberDto.other_names}, we have 2 weeks till the deadline for {endOfMonth.ToString("MMMM")} contributions. {ending}";
            }

            return null;
        }

        private List<MemberContributionBalance> GetListOfMembersWithPendingContributions()
        {            
            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();

                var membersWithBalances = dbContext.Member
                    .Where(m => m.Contributions.Any(c =>
                        c.fk_transaction_status_id == TransactionStatusEnum.Pending &&
                        c.contribution_period.Month == DateTime.Now.Month &&
                        c.contribution_period.Year == DateTime.Now.Year))
                    .Select(m => new MemberContributionBalance()
                    {
                        memberDto = _mapper.Map<MemberDto>(m),
                        contributionBalance = m.Contributions
                            .Where(c =>
                                c.fk_transaction_status_id == TransactionStatusEnum.Pending &&
                                c.contribution_period.Month == DateTime.Now.Month &&
                                c.contribution_period.Year == DateTime.Now.Year)
                            .Sum(c => c.balance)
                    })
                    .ToList();

                return membersWithBalances;
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

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;

namespace Prema.ChamaOne.Api.Backend.Services
{
    public class ContributionUpdaterService : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<ContributionUpdaterService> _logger;

        public ContributionUpdaterService(IServiceProvider serviceProvider, ILogger<ContributionUpdaterService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Contribution Updater Service is starting.");
            
            var nextRunTime = GetNextRunTime();
            var currentTime = DateTime.Now;
            var timeToGo = nextRunTime - currentTime;

            _timer = new Timer(DoWork, null, timeToGo, Timeout.InfiniteTimeSpan);
            DoWork(null);
            return Task.CompletedTask;
        }

        private DateTime GetNextRunTime()
        {
            //var now = DateTime.Now;

            TimeZoneInfo nairobiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Africa Standard Time"); //datetime now for nairobi timezone
            DateTime now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, nairobiTimeZone);

            var nextRun = new DateTime(now.Year, now.Month, 1).AddMonths(1);
            //var nextRun = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second + 10);

            return nextRun;
        }

        private async void DoWork(object state)
        {
            _logger.LogInformation("Contribution Service is working.");

            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();

                var members = await dbContext.Member.ToListAsync();

                TimeZoneInfo nairobiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Africa Standard Time"); //datetime now for nairobi timezone
                DateTime localNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, nairobiTimeZone);

                var currentPeriod = DateOnly.FromDateTime(localNow);
                var previousPeriod = currentPeriod.AddMonths(-1);

                foreach (var member in members)
                {
                    //create contribution record for new month
                    bool currentMonthContributionExists = dbContext.Contribution
                        .Any(c => c.fk_member_id == member.id && c.contribution_period.Month == currentPeriod.Month && c.contribution_period.Year == currentPeriod.Year);

                    if (!currentMonthContributionExists)
                    {
                        decimal amountDue = member.fk_occupation_id == 1 ? 100 : 200; //different rate for employed and student
                        var contribution = new Contribution
                        {
                            fk_member_id = member.id,
                            amount = amountDue, 
                            balance = amountDue,
                            penalty = 0,
                            contribution_period = currentPeriod,
                            fk_transaction_status_id = TransactionStatusEnum.Pending, //pending
                        };

                        dbContext.Contribution.Add(contribution);

                        dbContext.SaveChanges();

                        var transactionEntity = new TransactionEntity
                        {
                            id = 0,
                            fk_contribution_id = contribution.id
                        };

                        dbContext.TransactionEntity.Add(transactionEntity);

                        dbContext.SaveChanges();
                    }

                    //update penalty for pending contributions
                    var previousContribution = dbContext.Contribution
                        .FirstOrDefault(c => c.fk_member_id == member.id && c.contribution_period == previousPeriod && c.fk_transaction_status_id == TransactionStatusEnum.Pending);


                    if (previousContribution != null)
                    {
                        decimal penalty = CalculatePenalty(previousContribution.amount);

                        previousContribution.penalty = penalty;
                        previousContribution.balance = previousContribution.balance + penalty;
                        previousContribution.fk_transaction_status_id = TransactionStatusEnum.Overdue;
                        dbContext.Contribution.Update(previousContribution);
                    }
                }

                dbContext.SaveChanges();
            }

            var nextRunTime = GetNextRunTime();
            var currentTime = DateTime.Now;
            var timeToGo = nextRunTime - currentTime;

            _timer.Change(timeToGo, Timeout.InfiniteTimeSpan);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Contribution Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        private decimal CalculatePenalty(decimal contributionAmount)
        {
            return contributionAmount / 2;
        }
    }
}

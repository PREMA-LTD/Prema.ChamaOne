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
    public class LoanService : IHostedService, IDisposable
    {
        private Timer _timer;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<LoanService> _logger;

        public LoanService(IServiceProvider serviceProvider, ILogger<LoanService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("LoanService Service is starting.");

            var nextRunTime = GetNextRunTime();
            var currentTime = DateTime.Now;
            var timeToGo = nextRunTime - currentTime;

            _timer = new Timer(DoWork, null, timeToGo, Timeout.InfiniteTimeSpan);

            return Task.CompletedTask;
        }

        private DateTime GetNextRunTime()
        {
            var now = DateTime.Now;
            var nextRun = now.Date.AddDays(1); // Midnight of the next day

            return nextRun;
        }

        private async void DoWork(object state)
        {
            _logger.LogInformation("Loan Service Service is working.");

            using (var scope = _serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();

                var loans = await dbContext.Loan.Where(l => l.fk_transaction_status_id == TransactionStatusEnum.Pending && l.date_due > DateTime.UtcNow).ToListAsync();

                if (loans != null)
                {
                    foreach (var loan in loans)
                    {
                        loan.penalty = CalculatePenalty(loan);
                        loan.fk_transaction_status_id = TransactionStatusEnum.Overdue;
                        dbContext.Loan.Update(loan);
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
            _logger.LogInformation("Loan Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        private decimal CalculatePenalty(Loan loan)
        {
            return loan.principal * 1.1M; //10% penalty
        }
    }
}

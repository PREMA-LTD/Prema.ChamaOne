using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Prema.ChamaOne.Api.Backend.Caching;
using Prema.ChamaOne.Api.Backend.Caching.CacheServices;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models.Location;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

public class LocationCacheWorker : BackgroundService
{
    private readonly ILogger<LocationCacheWorker> _logger;
    private readonly ILocationCacheService _locationCacheService;

    public LocationCacheWorker(ILogger<LocationCacheWorker> logger, ILocationCacheService locationCacheService)
    {
        _logger = logger;
        _locationCacheService = locationCacheService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                _logger.LogInformation("Started loading location cache running at: {time}", DateTimeOffset.Now);
                await _locationCacheService.LoadCache();
                _logger.LogInformation("Finished loading location cache running at: {time}", DateTimeOffset.Now);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Location Cache Error Occured Executing {nameof(LocationCacheWorker)}");
            }

            await Task.Delay(1000, stoppingToken);
        }
    }


}

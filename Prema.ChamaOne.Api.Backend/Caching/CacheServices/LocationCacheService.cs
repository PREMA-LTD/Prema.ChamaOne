using System.Diagnostics;
using CSharpFunctionalExtensions;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using Prema.ChamaOne.Api.Backend.Models.Location;
using Prema.ChamaOne.Api.Backend.Database;
using Microsoft.EntityFrameworkCore;

namespace Prema.ChamaOne.Api.Backend.Caching.CacheServices
{
    public enum SingletonStatus
    {
        Initializing,
        ErrorInitializingRetrying,
        ErrorInitializingFailed,
        Ready,
    }

    public interface ILocationCacheService
    {
        SingletonStatus Status { get; set; }
        bool IsLoaded { get; }
        Task LoadCache(bool forceall = false);
        //Task ReloadCache(bool forceall = false);
        Result<List<County>> GetCounties();
    }

    public class LocationCacheService : ILocationCacheService
    {
        private readonly ILogger<LocationCacheService> _logger;
        private readonly IServiceProvider _serviceProvider;
        public Dictionary<int, County> _county;
        public Dictionary<int, Subcounty> _subcounty;
        public Dictionary<int, Ward> _ward;
        private DateTime _lastReloadDateTime;
        private readonly DateTime _minReloadDateTime = new DateTime(2000, 1, 1);

        public LocationCacheService(ILogger<LocationCacheService> logger, IServiceProvider serviceProvider)
        {
            Status = SingletonStatus.Initializing;
            //_timezoneOffsetSettingRepository = timezoneOffsetSettingRepository;
            _logger = logger;
            _serviceProvider = serviceProvider;
            _county = new Dictionary<int, County>();
            _subcounty = new Dictionary<int, Subcounty>();
            _ward = new Dictionary<int, Ward>();
        }

        public SingletonStatus Status { get; set; }
        public bool IsLoaded => _lastReloadDateTime > _minReloadDateTime;

        public async Task LoadCache(bool forceall = false)
        {
            var reloadDateTime = DateTime.UtcNow;
            try
            {
                if (forceall)
                {
                    _lastReloadDateTime = _minReloadDateTime;
                }

                Dictionary<int, County> counties;

                using (var scope = _serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ChamaOneDatabaseContext>();
                    counties = (await dbContext.County
                                .AsNoTracking()
                                .ToDictionaryAsync(county => county.id, county => county));
                }

                if (_county.Count == 0 || forceall)
                {
                    _county = counties;
                    _logger.LogInformation("Counties cache loaded. {}", DateTime.UtcNow);
                }

                _lastReloadDateTime = reloadDateTime;
                Status = SingletonStatus.Ready;
            }
            catch (Exception e)
            {
                Status = SingletonStatus.ErrorInitializingRetrying;

                _logger.LogError(e, "Error Loading Location Cache");

                throw;
            }
        }

        #region CacheReload
        //public async Task ReloadCache(bool forceall = false)
        //{
        //    var s = _serviceProvider.CreateScope();
        //    var svc = _serviceProvider.CreateScope().ServiceProvider.GetRequiredService<GpsTimeOffsetSettingRepository>();

        //    using var taskActivity = AppTracing.ActivitySource.StartActivity($"{nameof(GpsTimeOffsetSettingService)}.{nameof(ReloadCache)}");
        //    var reloadDateTime = DateTime.UtcNow;
        //    try
        //    {
        //        if (forceall)
        //        {
        //            _lastReloadDateTime = _minReloadDateTime;
        //        }


        //        taskActivity?.AddEvent(new("Timezone LoadingFromDB"));

        //        Dictionary<long, GpsTimeOffsetSetting> newOrUpdatedTimezoneOffsetSettings;
        //        using (var scope = _serviceProvider.CreateScope())
        //        {
        //            var timezoneOffsetSettingRepository = scope.ServiceProvider.GetRequiredService<GpsTimeOffsetSettingRepository>();
        //            newOrUpdatedTimezoneOffsetSettings = (await timezoneOffsetSettingRepository.GetTimezoneOffsetSettings(_lastReloadDateTime))
        //                .ToDictionary(i => i.imei, timezoneOffsetSetting => timezoneOffsetSetting);
        //        }

        //        if (_cachedDeviceTimezoneOffsetSetting.Count == 0 || forceall)
        //        {
        //            _cachedDeviceTimezoneOffsetSetting = newOrUpdatedTimezoneOffsetSettings;
        //            taskActivity?.AddEvent(new("Timezone Cache Reloaded"));
        //        }
        //        else
        //        {
        //            foreach (var newOrUpdatedTimezoneOffsetSetting in newOrUpdatedTimezoneOffsetSettings)
        //            {
        //                _cachedDeviceTimezoneOffsetSetting[newOrUpdatedTimezoneOffsetSetting.Key] = newOrUpdatedTimezoneOffsetSetting.Value;
        //            }
        //            taskActivity?.AddEvent(new("Timezone Cache Updated"));
        //        }
        //        _lastReloadDateTime = reloadDateTime;
        //        Status = SingletonStatus.Ready;
        //        taskActivity?.SetStatus(ActivityStatusCode.Ok, "Timezone Complete");
        //    }
        //    catch (Exception e)
        //    {
        //        if (_appSettings.CacheUnavailableAction == CacheUnavailableAction.DontAlterTime)
        //        {
        //            // Consider Ready even though we have had an exception
        //            Status = SingletonStatus.Ready;
        //            _lastReloadDateTime = reloadDateTime;
        //        }
        //        else
        //        {
        //            Status = SingletonStatus.ErrorInitializingRetrying;
        //        }

        //        _logger.LogError(e, "Error Loading Device Information");
        //        taskActivity?.SetStatus(ActivityStatusCode.Error, e.Message);
        //        throw;
        //    }
        //}
        #endregion

        public Result<List<County>> GetCounties()
        {
            if (!_county.Any())
            {
                return Result.Failure<List<County>>($"Counties Not Found");
            }
            
            return _county == null
                ? Result.Failure<List<County>>($"Missing couties")
                : Result.Success<List<County>>(_county.Select(c => c.Value).ToList());
        }
    }
}
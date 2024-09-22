using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
using AutoMapper;
using Prema.ChamaOne.Api.Backend.Caching.CacheServices;
namespace Prema.ChamaOne.Api.Backend.Controllers;

public static class LocationEndpoints
{
    public static void MapLocationEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Location").WithTags("Location");

        group.MapGet("/County", async(ILocationCacheService locationCacheService, IMapper mapper) =>
        {
            var counties = locationCacheService.GetCounties();

            if (counties.IsSuccess)
            {
                return Results.Ok(counties.Value);
            }            

            return Results.NotFound();
        })
        .WithName("GetAllCounties")
        .WithOpenApi();

        group.MapGet("/Subcounty/{countyId}", async (ILocationCacheService locationCacheService, IMapper mapper, int countyId) =>
        {
            var subcounties = locationCacheService.GetSubcounties(countyId);

            if (subcounties.IsSuccess)
            {
                return Results.Ok(subcounties.Value);
            }

            return Results.NotFound();
        })
        .WithName("GetCountySubcounties")
        .WithOpenApi();

        group.MapGet("/Ward/{subcountyId}", async (ILocationCacheService locationCacheService, IMapper mapper, int subcountyId) =>
        {
            var counties = locationCacheService.GetWards(subcountyId);

            if (counties.IsSuccess)
            {
                return Results.Ok(counties.Value);
            }

            return Results.NotFound();
        })
        .WithName("GetSubcoutyWards")
        .WithOpenApi();
    }
}

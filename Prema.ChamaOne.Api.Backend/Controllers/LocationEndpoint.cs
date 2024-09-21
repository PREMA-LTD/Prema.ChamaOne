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
        var group = routes.MapGroup("/api/Location").WithTags(nameof(Gender));

        group.MapGet("/County", async (IMapper mapper, LocationCacheService locationCacheService) =>
        {
            var counties = locationCacheService.GetCounties();
            return Results.Ok(counties);
        })
        .WithName("GetAllCounties")
        .WithOpenApi();

    }
}

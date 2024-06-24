using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
using AutoMapper;
namespace Prema.ChamaOne.Api.Backend.Controllers;

public static class ContributionEndpoints
{
    public static void MapContributionEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Contribution").WithTags(nameof(Contribution));

        group.MapGet("/", async (ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var contributions = await db.Contribution.AsNoTracking().ToListAsync();
            var contributionDtos = mapper.Map<List<ContributionDto>>(contributions);
            return Results.Ok(contributionDtos);
        })
        .WithName("GetAllContributions")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<ContributionDto>, NotFound>> (int id, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            return await db.Contribution.AsNoTracking()
                .FirstOrDefaultAsync(model => model.id == id)
                is Contribution model
                    ? TypedResults.Ok(mapper.Map<ContributionDto>(model))
                    : TypedResults.NotFound();
        })
        .WithName("GetContributionById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, ContributionDto contributionDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var contribution = await db.Contribution.FindAsync(id);

            if (contribution == null)
            {
                return TypedResults.NotFound();
            }

            // Map the incoming ContributionDto to the existing Contribution entity
            mapper.Map(contributionDto, contribution);

            var affected = await db.SaveChangesAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateContribution")
        .WithOpenApi();

        group.MapPost("/", async (ContributionDto contributionDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var contribution = mapper.Map<Contribution>(contributionDto); // Map from DTO to Entity
            db.Contribution.Add(contribution);
            await db.SaveChangesAsync();
            var createdDto = mapper.Map<ContributionDto>(contribution); // Map from Entity to DTO
            return TypedResults.Created($"/api/Contribution/{createdDto.id}", createdDto);
        })
        .WithName("CreateContribution")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ChamaOneDatabaseContext db) =>
        {
            var affected = await db.Contribution
                .Where(model => model.id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteContribution")
        .WithOpenApi();
    }
}

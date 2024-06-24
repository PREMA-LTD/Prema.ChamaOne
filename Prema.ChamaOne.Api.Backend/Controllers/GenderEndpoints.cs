using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
using AutoMapper;
namespace Prema.ChamaOne.Api.Backend.Controllers;

public static class GenderEndpoints
{
    public static void MapGenderEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Gender").WithTags(nameof(Gender));

        group.MapGet("/", async (ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var genders = await db.Gender.AsNoTracking().ToListAsync();
            var genderDtos = mapper.Map<List<GenderDto>>(genders);
            return Results.Ok(genderDtos);
        })
        .WithName("GetAllGenders")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<GenderDto>, NotFound>> (int id, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            return await db.Gender.AsNoTracking()
                .FirstOrDefaultAsync(model => model.id == id)
                is Gender model
                    ? TypedResults.Ok(mapper.Map<GenderDto>(model))
                    : TypedResults.NotFound();
        })
        .WithName("GetGenderById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, GenderDto genderDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var gender = await db.Gender.FindAsync(id);

            if (gender == null)
            {
                return TypedResults.NotFound();
            }

            // Map the incoming GenderDto to the existing Gender entity
            mapper.Map(genderDto, gender);

            var affected = await db.SaveChangesAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateGender")
        .WithOpenApi();

        group.MapPost("/", async (GenderDto genderDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var gender = mapper.Map<Gender>(genderDto); // Map from DTO to Entity
            db.Gender.Add(gender);
            await db.SaveChangesAsync();
            var createdDto = mapper.Map<GenderDto>(gender); // Map from Entity to DTO
            return TypedResults.Created($"/api/Gender/{createdDto.id}", createdDto);
        })
        .WithName("CreateGender")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ChamaOneDatabaseContext db) =>
        {
            var affected = await db.Gender
                .Where(model => model.id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteGender")
        .WithOpenApi();
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
using AutoMapper;
namespace Prema.ChamaOne.Api.Backend.Controllers;

public static class MemberEndpoints
{
    public static void MapMemberEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Member").WithTags(nameof(Member));

        group.MapGet("/", async (ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var members = await db.Member.AsNoTracking().ToListAsync();
            var memberDtos = mapper.Map<List<MemberDto>>(members);
            return Results.Ok(memberDtos);
        })
        .WithName("GetAllMembers")
        .WithOpenApi()
        .RequireAuthorization(); 

        group.MapGet("/{id}", async Task<Results<Ok<MemberDto>, NotFound>> (int id, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            return await db.Member.AsNoTracking()
                .FirstOrDefaultAsync(model => model.id == id)
                is Member model
                    ? TypedResults.Ok(mapper.Map<MemberDto>(model))
                    : TypedResults.NotFound();
        })
        .WithName("GetMemberById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, MemberDto memberDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var member = await db.Member.FindAsync(id);

            if (member == null)
            {
                return TypedResults.NotFound();
            }

            // Map the incoming MemberDto to the existing Member entity
            mapper.Map(memberDto, member);

            var affected = await db.SaveChangesAsync();

            return TypedResults.Ok();
        })
        .WithName("UpdateMember")
        .WithOpenApi();

        group.MapPost("/", async (MemberDto memberDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var member = mapper.Map<Member>(memberDto); // Map from DTO to Entity
            db.Member.Add(member);
            await db.SaveChangesAsync();
            var createdDto = mapper.Map<MemberDto>(member); // Map from Entity to DTO
            return TypedResults.Created($"/api/Member/{createdDto.id}", createdDto);
        })
        .WithName("CreateMember")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ChamaOneDatabaseContext db) =>
        {
            var affected = await db.Member
                .Where(model => model.id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteMember")
        .WithOpenApi();
    }
}

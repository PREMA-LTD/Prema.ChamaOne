using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
using AutoMapper;
namespace Prema.ChamaOne.Api.Backend.Controllers;

public static class LoanEndpoints
{
    public static void MapLoanEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Loan").WithTags(nameof(Loan));

        group.MapGet("/", async (ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var loans = await db.Loan.AsNoTracking().ToListAsync();
            var loanDtos = mapper.Map<List<LoanDto>>(loans);
            return Results.Ok(loanDtos);
        })
        .WithName("GetAllLoans")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<LoanDto>, NotFound>> (int id, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            return await db.Loan.AsNoTracking()
                .FirstOrDefaultAsync(model => model.id == id)
                is Loan model
                    ? TypedResults.Ok(mapper.Map<LoanDto>(model))
                    : TypedResults.NotFound();
        })
        .WithName("GetLoanById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, LoanDto loanDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var loan = await db.Loan.FindAsync(id);

            if (loan == null)
            {
                return TypedResults.NotFound();
            }

            // Map the incoming LoanDto to the existing Loan entity
            mapper.Map(loanDto, loan);

            var affected = await db.SaveChangesAsync();

            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateLoan")
        .WithOpenApi();

        group.MapPost("/", async (LoanDto loanDto, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            var loan = mapper.Map<Loan>(loanDto); // Map from DTO to Entity
            db.Loan.Add(loan);
            await db.SaveChangesAsync();
            var createdDto = mapper.Map<LoanDto>(loan); // Map from Entity to DTO
            return TypedResults.Created($"/api/Loan/{createdDto.id}", createdDto);
        })
        .WithName("CreateLoan")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ChamaOneDatabaseContext db) =>
        {
            var affected = await db.Loan
                .Where(model => model.id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteLoan")
        .WithOpenApi();
    }
}

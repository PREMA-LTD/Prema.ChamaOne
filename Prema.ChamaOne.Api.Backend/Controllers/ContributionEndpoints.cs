using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
using AutoMapper;
using AutoMapper.Execution;
using System.Drawing.Printing;
using Prema.ChamaOne.Api.Backend.BulkSms;
namespace Prema.ChamaOne.Api.Backend.Controllers;

public static class ContributionEndpoints
{
    public static void MapContributionEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Contribution").WithTags(nameof(Contribution));

        group.MapGet("/", async (ChamaOneDatabaseContext db, IMapper mapper, int pageNumber = 0, int pageSize = 1, int memberId = 0) =>
        {
            var totalContributions = await db.Contribution
                .AsNoTracking()
                .CountAsync(); // Get total count for pagination

            List<ContributionAndMemberDto> contributions = new List<ContributionAndMemberDto>();

            if (memberId == 0)
            {
                contributions = await db.Contribution
                    .AsNoTracking()
                    .Include(c => c.Member)  // Ensure Member is included in the query
                    .OrderBy(c => c.id) // Ensure a predictable order
                    .Skip(pageNumber * pageSize) // Skip records based on page number
                    .Take(pageSize) // Take records based on page size
                    .Select(c => new ContributionAndMemberDto
                    {
                        id = c.id,
                        amount = c.amount,
                        balance = c.balance,
                        penalty = c.penalty,
                        contribution_period = c.contribution_period,
                        fk_transaction_status_id = (int)c.fk_transaction_status_id,
                        member = c.Member
                    })
                    .ToListAsync();
            } else
            {
                contributions = await db.Contribution
                    .AsNoTracking()
                    .Include(c => c.Member)  // Ensure Member is included in the query
                    .OrderBy(c => c.id) // Ensure a predictable order
                    .Where(m => m.fk_member_id == memberId) // Use '==' for comparison
                    .Skip(pageNumber * pageSize) // Skip records based on page number
                    .Take(pageSize) // Take records based on page size
                    .Select(c => new ContributionAndMemberDto
                    {
                        id = c.id,
                        amount = c.amount,
                        balance = c.balance,
                        penalty = c.penalty,
                        contribution_period = c.contribution_period,
                        fk_transaction_status_id = (int)c.fk_transaction_status_id,
                        member = c.Member
                    })
                    .ToListAsync();
            }

            // Return results including pagination metadata
            return Results.Ok(new 
            {
                total = totalContributions,
                contributions = contributions
            });
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

        group.MapGet("/Totals/{memberId}", async Task<Results<Ok<ContributionTotalsDto>, NotFound>> (ChamaOneDatabaseContext db, IMapper mapper, int memberId = 0) =>
        {
            if (memberId == 0)
            {
                return await db.Contribution.AsNoTracking()
                    .Where(c => c.fk_member_id > 0)
                    .GroupBy(_ => true)  // Group everything (all records)
                    .Select(group => new ContributionTotalsDto
                    {
                        balance = group.Sum(model => model.balance),         // Sum of all balances
                        penalty = group.Sum(model => model.penalty),         // Sum of all penalties
                        amount = group.Sum(model => model.amount),
                        totalPaid = group.Sum(model => model.penalty) + (group.Sum(model => model.amount) - group.Sum(model => model.balance)) // TotalPaid = TotalBalance - (TotalPenalty + TotalAmount)
                    })
                    .FirstOrDefaultAsync()
                    is ContributionTotalsDto result && result != null
                    ? TypedResults.Ok(result)
                    : TypedResults.NotFound();
            }
            else
            {
                return await db.Contribution.AsNoTracking()
                    .Where(c => c.fk_member_id == memberId)
                    .GroupBy(_ => true)  // Group everything (all records)
                    .Select(group => new ContributionTotalsDto
                    {
                        balance = group.Sum(model => model.balance),         // Sum of all balances
                        penalty = group.Sum(model => model.penalty),         // Sum of all penalties
                        amount = group.Sum(model => model.amount),           // Sum of all amounts
                        totalPaid = group.Sum(model => model.penalty) + (group.Sum(model => model.amount) - group.Sum(model => model.balance))     // TotalPaid = TotalBalance - (TotalPenalty + TotalAmount)
                    })
                    .FirstOrDefaultAsync()
                    is ContributionTotalsDto result && result != null
                    ? TypedResults.Ok(result)
                    : TypedResults.NotFound();
            }
        })
        .WithName("GetContributionTotal")
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


        group.MapPost("/MakeContribution", async Task<Results<Ok<ContributionDto>, NotFound<string>>> (ContributionDetails contributionDetails, ChamaOneDatabaseContext db, IMapper mapper, IBulkSms mobileSasa) =>
        {
            //update contribution record
            var contributionRecord = await db.Contribution
                .Where(model =>
                    model.contribution_period.Year == contributionDetails.contribution_period.Year &&
                    model.contribution_period.Month == contributionDetails.contribution_period.Month &&
                    model.fk_member_id == contributionDetails.member_id)
                .FirstOrDefaultAsync();

            var memberDetails = await db.Member
                .Where(model => model.id == contributionDetails.member_id)
                .FirstOrDefaultAsync();

            if (memberDetails == null)
            {
                return TypedResults.NotFound("Member data not found.");
            }

            if (contributionRecord == null)
            {
                decimal contributionAmount = memberDetails.fk_occupation_id == 1 ? 100 : 200; //different rate for employed and student

                contributionRecord = new Contribution
                {
                    fk_member_id = memberDetails.id,
                    amount = contributionAmount, 
                    penalty = 0,
                    balance = contributionAmount - contributionDetails.amount_paid,
                    contribution_period = DateOnly.FromDateTime(DateTime.UtcNow),
                    fk_transaction_status_id = TransactionStatusEnum.Pending, //pending
                };

                db.Contribution.Add(contributionRecord);

                db.SaveChanges();

                db.TransactionEntity.Add(new TransactionEntity
                {
                    id = 0,
                    fk_contribution_id = contributionRecord.id
                });

                db.SaveChanges();
            }

            contributionRecord.balance = contributionRecord.balance - contributionDetails.amount_paid;

            if (contributionRecord.balance == 0)
            {
                contributionRecord.fk_transaction_status_id = TransactionStatusEnum.Paid;
            }

            //save transaction record
            TransactionEntity? transactionEntity = await db.TransactionEntity
                .FirstOrDefaultAsync(t => t.fk_contribution_id == contributionRecord.id);

            if (transactionEntity == null) return TypedResults.NotFound("Missing transaction entity record.");

            var newTransaction = new Transaction
            {
                date_of_record = DateTime.UtcNow,
                date = contributionDetails.date_of_payment,
                amount = contributionDetails.amount_paid,
                description = "Contribution payment",
                reference =contributionDetails.reference,
                fk_transaction_type_id = 1,
                fk_transaction_entity_type_id = 1,
                fk_transaction_entity_id = transactionEntity.id
            };

            db.Transaction.Add(newTransaction);

            await db.SaveChangesAsync();

            //send payment acknowledgement sms
            await mobileSasa.SendSms(memberDetails.contact, $"{memberDetails.other_names} {memberDetails.surname}", $"Hello {memberDetails.other_names}, your contribution payment of Ksh. {contributionDetails.amount_paid} for {contributionDetails.contribution_period.ToString("MMMM yyyy")} has been recieved successfully. Thank you.");

            var createdDto = mapper.Map<ContributionDto>(contributionRecord);

            return TypedResults.Ok(createdDto);
        })
        .WithName("MakeContribution")
        .WithOpenApi();

    }
}

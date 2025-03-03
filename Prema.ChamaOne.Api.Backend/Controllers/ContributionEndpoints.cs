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

        group.MapGet("/", async (ChamaOneDatabaseContext db, IMapper mapper, int pageNumber = 0, int pageSize = 1, int memberId = 0, int month = 0, int year = 0, int status = 0) =>
        {
            var query = db.Contribution
                .AsNoTracking()
                .Include(c => c.Member)
                .OrderBy(c => c.id)
                .AsQueryable();

            // Apply filters dynamically based on the provided parameters
            if (memberId != 0)
            {
                query = query.Where(c => c.fk_member_id == memberId);
            }
            if (month != 0)
            {
                query = query.Where(c => c.contribution_period.Month == month);
            }
            if (year != 0)
            {
                query = query.Where(c => c.contribution_period.Year == year);
            }
            if (status != 0)
            {
                query = query.Where(c => c.fk_transaction_status_id == (TransactionStatusEnum)status);
            }

            // Count the total records for pagination
            var totalContributions = await query.CountAsync();

            // Apply pagination and projection to DTO
            var contributions = await query
                .Skip(pageNumber * pageSize)
                .Take(pageSize)
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


        group.MapGet("/Member/{memberId}", async Task<Results<Ok<ContributionDto[]>, NotFound>> (int memberId, ChamaOneDatabaseContext db, IMapper mapper) =>
        {
            // Check if memberId is 0 and fetch records where memberId is greater than 0
            if (memberId == 0)
            {
                var contributions = await db.Contribution.AsNoTracking()
                    .Where(model => model.fk_member_id > memberId)
                    .ToListAsync();

                return contributions.Any()
                    ? TypedResults.Ok(mapper.Map<ContributionDto[]>(contributions))
                    : TypedResults.NotFound();
            }
            else
            {
                // Fetch records where memberId matches the parameter
                var contributions = await db.Contribution.AsNoTracking()
                    .Where(model => model.fk_member_id == memberId)
                    .ToListAsync();

                return contributions.Any()
                    ? TypedResults.Ok(mapper.Map<ContributionDto[]>(contributions))
                    : TypedResults.NotFound();
            }
        })
        .WithName("GetContributionByMemberId")
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

            //if paid prior to deadline
            if (DateOnly.FromDateTime(contributionDetails.date_of_payment) <= contributionDetails.contribution_period)
            {
                contributionRecord.penalty = 0;

                decimal contributionAmount = memberDetails.fk_occupation_id == 1 ? 100 : 200;
                contributionRecord.amount = contributionAmount;
                contributionRecord.balance = contributionAmount;
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


        group.MapPost("/MakeFutureContribution", async Task<Results<Ok<FutureContributionDetials>, NotFound<string>>> (FutureContributionDetials futureContributionDetails, ChamaOneDatabaseContext db, IMapper mapper, IBulkSms mobileSasa) =>
        {           

            var memberDetails = await db.Member
                .Where(model => model.id == futureContributionDetails.memberId)
                .FirstOrDefaultAsync();

            if (memberDetails == null)
            {
                return TypedResults.NotFound("Member data not found.");
            }

            TimeZoneInfo nairobiTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Africa/Nairobi"); //datetime now for nairobi timezone
            DateTime localNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, nairobiTimeZone);

            decimal amountDue = memberDetails.fk_occupation_id == 1 ? 100 : 200;

            do
            {
                DateTime testDate = localNow;

                var contributionDetails = await db.Contribution
                    .Where(model =>
                        model.contribution_period.Year == DateOnly.FromDateTime(testDate).Year &&
                        model.contribution_period.Month == DateOnly.FromDateTime(testDate).Month &&
                        model.fk_member_id == futureContributionDetails.memberId)
                    .FirstOrDefaultAsync();

                localNow = localNow.AddMonths(1); //increment to next month

                if (contributionDetails == null)
                {
                    var currentPeriod = DateOnly.FromDateTime(testDate);
                    var amountPaid = futureContributionDetails.amountPaid >= amountDue ? amountDue : futureContributionDetails.amountPaid;
                    var balance = futureContributionDetails.amountPaid >= amountDue ? 0 : (amountDue - futureContributionDetails.amountPaid);
                    futureContributionDetails.amountPaid -= amountPaid;

                    var contribution = new Contribution
                    {
                        fk_member_id = futureContributionDetails.memberId,
                        amount = memberDetails.fk_occupation_id == 1 ? 100 : 200,
                        balance = balance,
                        penalty = 0,
                        contribution_period = currentPeriod,
                        fk_transaction_status_id = balance > 0 ? TransactionStatusEnum.Pending : TransactionStatusEnum.Paid, // TODO partial payment
                    };

                    db.Contribution.Add(contribution);

                    db.SaveChanges();

                    var transactionEntity = new TransactionEntity
                    {
                        id = 0,
                        fk_contribution_id = contribution.id
                    };

                    db.TransactionEntity.Add(transactionEntity);

                    db.SaveChanges();
                }
                else
                {
                    if (contributionDetails.fk_transaction_status_id == TransactionStatusEnum.Paid) continue;

                    var amountPaid = futureContributionDetails.amountPaid >= contributionDetails.balance ? contributionDetails.balance : futureContributionDetails.amountPaid;
                    var balance = futureContributionDetails.amountPaid >= contributionDetails.balance ? 0 : (contributionDetails.balance - futureContributionDetails.amountPaid);
                    futureContributionDetails.amountPaid -= amountPaid;

                    contributionDetails.balance = futureContributionDetails.amountPaid >= amountDue ? 0 : futureContributionDetails.amountPaid;
                    contributionDetails.fk_transaction_status_id = contributionDetails.balance > 0 ? TransactionStatusEnum.Pending : TransactionStatusEnum.Paid; // TODO partial payment
                    db.Contribution.Update(contributionDetails);
                    db.SaveChanges();
                }

            } while (futureContributionDetails.amountPaid > 0);

            //send payment acknowledgement sms
            await mobileSasa.SendSms(memberDetails.contact, $"{memberDetails.other_names} {memberDetails.surname}", $"Hello {memberDetails.other_names}, your contribution payment of Ksh. {futureContributionDetails.amountPaid} has been recieved successfully. Thank you.");

            var createdDto = mapper.Map<FutureContributionDetials>(futureContributionDetails);

            return TypedResults.Ok(createdDto);
        })
        .WithName("MakeFutureContribution")
        .WithOpenApi();
    }
}

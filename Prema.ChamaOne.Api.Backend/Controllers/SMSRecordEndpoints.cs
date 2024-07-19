using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
namespace Prema.ChamaOne.Api.Backend.Controllers;

public static class SMSRecordEndpoints
{
    public static void MapSMSRecordEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/SMSRecord").WithTags(nameof(SMSRecord));

        group.MapGet("/", async (ChamaOneDatabaseContext db) =>
        {
            var smsRecords = await db.SMSRecord
                                     .Select(s => new
                                     {
                                         s.id,
                                         s.message,
                                         s.recipient_name,
                                         s.recipient_contact,
                                         s.date_time_sent,
                                         s.failure_count,
                                         s.status
                                     })
                                     .ToListAsync();

            var smsFailures = await db.SMSFailure
                                      .Select(f => new
                                      {
                                          f.id,
                                          f.error,
                                          f.date_time,
                                          f.fk_sms_record_id
                                      })
                                      .ToListAsync();

            var result = smsRecords.Select(s => new
            {
                s.id,
                s.message,
                s.recipient_name,
                s.recipient_contact,
                s.date_time_sent,
                s.failure_count,
                s.status,
                SMSFailures = smsFailures.Where(f => f.fk_sms_record_id == s.id).ToList()
            }).ToList();

            return Results.Json(result);


        })
        .WithName("GetAllSMSRecords")
        .WithOpenApi();


        group.MapGet("/{id}", async Task<Results<Ok<SMSRecord>, NotFound>> (int id, ChamaOneDatabaseContext db) =>
        {
            return await db.SMSRecord.AsNoTracking()
                .FirstOrDefaultAsync(model => model.id == id)
                is SMSRecord model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetSMSRecordById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, SMSRecord sMSRecord, ChamaOneDatabaseContext db) =>
        {
            var affected = await db.SMSRecord
                .Where(model => model.id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.id, sMSRecord.id)
                    .SetProperty(m => m.message, sMSRecord.message)
                    .SetProperty(m => m.recipient_name, sMSRecord.recipient_name)
                    .SetProperty(m => m.recipient_contact, sMSRecord.recipient_contact)
                    .SetProperty(m => m.date_time_sent, sMSRecord.date_time_sent)
                    .SetProperty(m => m.failure_count, sMSRecord.failure_count)
                    .SetProperty(m => m.status, sMSRecord.status)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateSMSRecord")
        .WithOpenApi();

        group.MapPost("/", async (SMSRecord sMSRecord, ChamaOneDatabaseContext db) =>
        {
            db.SMSRecord.Add(sMSRecord);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/SMSRecord/{sMSRecord.id}",sMSRecord);
        })
        .WithName("CreateSMSRecord")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ChamaOneDatabaseContext db) =>
        {
            var affected = await db.SMSRecord
                .Where(model => model.id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteSMSRecord")
        .WithOpenApi();
    }
}

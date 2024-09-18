using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Prema.ChamaOne.Api.Backend.Database;
using Prema.ChamaOne.Api.Backend.Models;
using System.Threading.Tasks;
using Prema.ChamaOne.Api.Backend.BulkSms;

namespace Prema.ChamaOne.Api.Backend.Controllers
{
    public static class MessagingEndpoints
    {
        public static void MapMessagingEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/Messaging").WithTags("Messaging");

            group.MapPost("/SendSingleSms", async (SMS sMSRecord, ChamaOneDatabaseContext db, IBulkSms mobileSasa) =>
            {
                // Send the SMS using the injected service
                await mobileSasa.SendSms(sMSRecord.recipient_contact, sMSRecord.recipient_name, sMSRecord.message);

                return TypedResults.Ok();
            })
            .WithName("SendSMS")
            .WithOpenApi();


            group.MapPost("/ResendSingleSms", async (SMSRecord sMSRecord, ChamaOneDatabaseContext db, IBulkSms mobileSasa) =>
            {
                // Send the SMS using the injected service
                await mobileSasa.ResendSms(sMSRecord.id);

                return TypedResults.Ok();
            })
            .WithName("ResendSingleSms")
            .WithOpenApi();
        }
    }
}

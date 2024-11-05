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

public static class UserEndpoints
{
    public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/User").WithTags(nameof(User));

        group.MapPost("/UpdateMember/{memberId}/{userId}", async Task<Results<Ok, NotFound>> (ChamaOneDatabaseContext db, IMapper mapper, IBulkSms mobileSasa, int memberId = 0, string? userId = null) =>
        {
            //update member data
            var member = await db.Member.FindAsync(memberId);

            if (member == null)
            {
                return TypedResults.NotFound();
            }

            member.fk_user_id = userId;

            var affected = await db.SaveChangesAsync();

            return TypedResults.Ok();
        })
        .WithName("MakeContribution")
        .WithOpenApi();

    }


    //private bool ResetPassword(int memberId)
    //{

    //    return true;
    //}
}
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

        group.MapPost("/UpdateUserId", async Task<Results<Ok, NotFound>> (UserData userData, ChamaOneDatabaseContext db, IMapper mapper, IBulkSms mobileSasal) =>
        {
            //update member data
            var member = await db.Member.FindAsync(userData.member_id);

            if (member == null)
            {
                return TypedResults.NotFound();
            }

            member.fk_user_id = userData.user_id;

            var affected = await db.SaveChangesAsync();

            return TypedResults.Ok();
        })
        .WithName("UpdateUserId")
        .WithOpenApi();

    }


    //private bool ResetPassword(int memberId)
    //{

    //    return true;
    //}
}
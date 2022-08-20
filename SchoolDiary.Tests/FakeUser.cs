using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace SchoolDiary.Tests
{
    public class FakeUser : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var claimPrincipal = new ClaimsPrincipal();

            claimPrincipal.AddIdentity(new ClaimsIdentity(
                new[]
                {
                    new Claim(ClaimTypes.Role, "Admin")
                }));

            context.HttpContext.User = claimPrincipal;

            await next();
        }
    }
}

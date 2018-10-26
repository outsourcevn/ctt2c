using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AppPortal.ApiHost.Startups
{
    public class CheckHasRoleRequiment : AuthorizationHandler<CheckHasRoleRequiment>, IAuthorizationRequirement
    {
        string[] _roles;
        public CheckHasRoleRequiment(params string[] roles)
        {
            _roles = roles;
        }

        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            CheckHasRoleRequiment requirement)
        {
            if (!context.User.HasClaim(c => c.Type == "rolesForUser"))
            {
                return Task.CompletedTask;
            }

            var rolesForUser = context.User.FindFirst(c => c.Type == "rolesForUser").Value.Split(new char[] { ',' });
            if(_roles.Any(role => rolesForUser.Contains(role)))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}

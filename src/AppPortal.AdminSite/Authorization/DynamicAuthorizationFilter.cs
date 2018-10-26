using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AppPortal.AdminSite.ViewModels;
using AppPortal.Core;
using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace AppPortal.AdminSite.Authorization
{
    public class DynamicAuthorizationFilter : IAsyncAuthorizationFilter
    {
        public DynamicAuthorizationFilter()
        {
        }
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            await Task.Run(() =>
            {
                if (!IsProtectedAction(context))
                    return;

                if (!IsUserAuthenticated(context))
                {
                    var returnUrl = $"/{context.RouteData.Values.GetValueOrDefault("controller")?.ToString()}/{context.RouteData.Values.GetValueOrDefault("action")?.ToString()}";
                    context.Result = new RedirectToActionResult("Login", "Account", new { returnUrl = returnUrl });

                    return;
                }

                var actionId = GetActionId(context);
                if (actionId == ActionId.Home || actionId == ActionId.Logout)
                    return;

                var UserClamPrincipal = context.HttpContext.User;
                var rolesClaim = UserClamPrincipal?.FindFirst(c => c.Type == "rolesForUser").Value;
                if(rolesClaim == null)
                {
                    context.Result = new ForbidResult();
                    return;
                }

                var roles = JsonConvert.DeserializeObject<List<ApplicationRole>>(rolesClaim);

                if (roles.Any(c => c.NormalizedName == AppConst.ROLE_SYSADMIN))
                {
                    return;
                }
                foreach (var role in roles)
                {
                    if (role.AccessPage != null)
                    {
                        var accessList =
                            JsonConvert.DeserializeObject<IEnumerable<MvcControllerInfoViewModel>>(role.AccessPage);
                        if (accessList.SelectMany(c => c.Actions).Any(a => a.Id == actionId))
                            return;
                    }
                }

                context.Result = new ForbidResult();
            });
        }

        private bool IsProtectedAction(AuthorizationFilterContext context)
        {
            if (context.Filters.Any(item => item is IAllowAnonymousFilter))
                return false;

            var controllerActionDescriptor = (ControllerActionDescriptor)context.ActionDescriptor;
            var controllerTypeInfo = controllerActionDescriptor.ControllerTypeInfo;
            var actionMethodInfo = controllerActionDescriptor.MethodInfo;

            var authorizeAttribute = controllerTypeInfo.GetCustomAttribute<AuthorizeAttribute>();
            if (authorizeAttribute != null)
                return true;

            authorizeAttribute = actionMethodInfo.GetCustomAttribute<AuthorizeAttribute>();
            if (authorizeAttribute != null)
                return true;

            return false;
        }

        private bool IsUserAuthenticated(AuthorizationFilterContext context)
        {
            return context.HttpContext.User.Identity.IsAuthenticated;
        }

        private string GetActionId(AuthorizationFilterContext context)
        {
            var controllerActionDescriptor = (ControllerActionDescriptor)context.ActionDescriptor;
            var area = controllerActionDescriptor
                .ControllerTypeInfo
                .GetCustomAttribute<AreaAttribute>()?.RouteValue;
            var controller = controllerActionDescriptor.ControllerName;
            var action = controllerActionDescriptor.ActionName;

            return $"{area}:{controller}:{action}";
        }
    }
}

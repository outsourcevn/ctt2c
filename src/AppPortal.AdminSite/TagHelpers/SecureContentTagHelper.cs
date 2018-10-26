using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.ViewModels;
using AppPortal.Core;
using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Newtonsoft.Json;

namespace AppPortal.AdminSite.TagHelpers
{
    [HtmlTargetElement("secure-content")]
    public class SecureContentTagHelper : TagHelper
    {
        public SecureContentTagHelper()
        {
        }
        [HtmlAttributeName("asp-area")]
        public string Area { get; set; }

        [HtmlAttributeName("asp-controller")]
        public string Controller { get; set; }

        [HtmlAttributeName("asp-action")]
        public string Action { get; set; }

        [ViewContext, HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {

            await Task.Run(() =>
            {
                output.TagName = null;
                var user = ViewContext.HttpContext.User;

                if (!user.Identity.IsAuthenticated)
                {
                    output.SuppressOutput();
                    return;
                }

                var rolesClaim = user?.FindFirst(c => c.Type == "rolesForUser").Value;
                if (rolesClaim == null)
                {
                    output.SuppressOutput();
                    return;
                }

                var roles = JsonConvert.DeserializeObject<List<ApplicationRole>>(rolesClaim);

                if (roles.Any(c => c.NormalizedName == AppConst.ROLE_SYSADMIN))
                {
                    return;
                }

                var actionId = $"{Area}:{Controller}:{Action}";

                foreach (var role in roles)
                {
                    if (role.AccessPage == null)
                        continue;
                    var accessList =
                             JsonConvert.DeserializeObject<IEnumerable<MvcControllerInfoViewModel>>(role.AccessPage);
                    if (accessList.SelectMany(c => c.Actions).Any(a => a.Id == actionId))
                        return;
                }

                output.SuppressOutput();
            });
        }
    }
}

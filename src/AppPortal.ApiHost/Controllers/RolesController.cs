using System.Linq;
using System.Threading.Tasks;
using AppPortal.ApiHost.Controllers.Base;
using AppPortal.ApiHost.ViewModels;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]    
    public class RolesController : ApiBaseController<RolesController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        public RolesController(
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IAppLogger<RolesController> logger) : base(configuration, logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpGet("getRoles")]
        public async Task<IActionResult> ListRolesAsync(string keyword = "", int? take = 15, int? skip = 0, int? page = 1)
        {
            if (string.IsNullOrEmpty(keyword)) keyword = "";
            var query = _roleManager.Roles;

            if (!string.IsNullOrEmpty(keyword) && keyword != "") query = query.Where(x => x.Name.Contains(keyword) || x.RoleDescription.Contains(keyword));

            // paging
            if (page.HasValue && page.Value > 1) skip = (page - 1) * take;
            int rows = query.Count();
            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.Skip(skip.Value).Take(take.Value);

            var items = await query.Select(x => new ListItemsViewModel<string, object>()
            {
                Id = x.Id,
                Name = x.Name,
                Field = new
                {
                    RoleDescription = x.RoleDescription,
                    NormalizedName = x.NormalizedName
                }                
            }).ToListAsync();       

            return ResponseInterceptor(items, rows, new Paging()
            {
                PageNumber = page.Value,
                PageSize = take.Value,
                Take = take.Value,
                Skip = skip.Value,
                Query = keyword
            });
        }
    }
}
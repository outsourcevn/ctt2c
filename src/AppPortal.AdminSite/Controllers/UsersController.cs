using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.ViewModels.Users;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Quản trị tài khoản")]
    public class UsersController : AdminBaseController<UsersController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        public UsersController(
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IAppLogger<UsersController> logger) : base(configuration, logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [DisplayName("Quản lý tài khoản người dùng")]
        public IActionResult Index(string keyword, int? pageSize, int? take = 15, int? skip = 0, int? page = 1)
        {
            if (!take.HasValue) take = 15;
            if (!page.HasValue) page = 1;
            if (!pageSize.HasValue) pageSize = take;
            if (string.IsNullOrEmpty(keyword)) keyword = "";
            ViewData["keyword"] = keyword;
            ViewData["take"] = take;
            ViewData["page"] = page;
            ViewData["pageSize"] = pageSize;
            return View();
        }       

        [DisplayName("Tạo mới/cập nhật người dùng")]
        public async Task<IActionResult> CreateOrUpdate(string id)
        {
            var model = new AccountViewModel
            {
                Roles = _roleManager.Roles.OrderBy(t => t.Name).ToDictionary(x => x.Name, x => false)
            };

            if (!string.IsNullOrWhiteSpace(id))
            {
                var user = await _userManager.FindByIdAsync(id);
                model.AccountId = id;
                model.Email = user.Email;
                model.FullName = user.FullName;
                model.UserName = user.UserName;
                model.PhoneNumber = user.PhoneNumber;
				model.EmailAuth = user.EmailAuth;
                var userRoles = await _userManager.GetRolesAsync(user);
                foreach (var item in userRoles)
                {
                    model.Roles[item] = true;
                }
            }
            return View(model);
        }

        [DisplayName("Thông tin tài khoản")]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if(user == null)
            {
                return new NotFoundResult();
            }
            var dataModel = new UserProfileViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                PhoneNumber = user.PhoneNumber,
                TypeAccount = user.TypeUser,
                UserName = user.UserName
            };
            // add Roles for user
            var roles = await _userManager.GetRolesAsync(user);
            var rolesForUser = await _roleManager.Roles
                .Where(r => roles.Contains(r.NormalizedName))
                .ToListAsync();

            dataModel.Roles = rolesForUser.ToDictionary(x => x.Name, x => x.RoleDescription);

            return View(dataModel);
        }
    }
}
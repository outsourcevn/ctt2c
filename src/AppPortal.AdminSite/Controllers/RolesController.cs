using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models;
using AppPortal.AdminSite.ViewModels;
using AppPortal.AdminSite.ViewModels.Roles;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Quản trị hệ thống")]
    public class RolesController : AdminBaseController<RolesController>
    {
        private readonly IMvcControllerDiscovery _mvcControllerDiscovery;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RolesController(
            IConfiguration configuration,
            IMvcControllerDiscovery mvcControllerDiscovery,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IAppLogger<RolesController> logger) : base(configuration, logger)
        {
            _mvcControllerDiscovery = mvcControllerDiscovery;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [DisplayName("Quản lý phân quyền")]
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

        // GET: Role/Create
        [DisplayName("Tạo mới quyền")]
        public ActionResult Create()
        {
            var controllersVm = _mvcControllerDiscovery.GetControllers().Select(c => Mapper.Map<MvcControllerInfo, MvcControllerInfoViewModel>(c));
            ViewData["Controllers"] = controllersVm;
            return View();
        }

        // POST: Role/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RoleViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Controllers"] = _mvcControllerDiscovery.GetControllers().Select(c => Mapper.Map<MvcControllerInfo, MvcControllerInfoViewModel>(c));
                return View(viewModel);
            }

            var role = new ApplicationRole { Name = viewModel.Name };
            if (viewModel.SelectedControllers != null && viewModel.SelectedControllers.Any())
            {
                foreach (var controller in viewModel.SelectedControllers)
                    foreach (var action in controller.Actions)
                        action.ControllerId = controller.Id;

                var accessJson = JsonConvert.SerializeObject(viewModel.SelectedControllers);
                role.AccessPage = accessJson;
            }

            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
                return RedirectToAction(nameof(Create));

            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);

            ViewData["Controllers"] = _mvcControllerDiscovery.GetControllers().Select(c => Mapper.Map<MvcControllerInfo, MvcControllerInfoViewModel>(c));
            return View(viewModel);
        }
    }
}
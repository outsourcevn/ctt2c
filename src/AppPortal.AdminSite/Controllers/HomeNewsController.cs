using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.AdminSite.ViewModels.News;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Quản trị tin tức")]
    public class HomeNewsController : AdminBaseController<NewsController>
    {
        private readonly ICategoryService _categoryService;
        private readonly INewsService _newsService;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeNewsController(
            IConfiguration configuration,
            IAppLogger<NewsController> logger,
            ICategoryService categoryService,
            UserManager<ApplicationUser> userManager,
            INewsService newsService) : base(configuration, logger)
        {
            _categoryService = categoryService;
            _newsService = newsService;
            _userManager = userManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [DisplayName("Quản lý tin tức")]
        public async Task<IActionResult> Index(string keyword, int? pageSize, int? take = 15, int? skip = 0, int? page = 1, int? categoryId = -1, int? status = -1, int? type = -1)
        {
            if (!take.HasValue) take = 15;
            if (!page.HasValue) page = 1;
            if (!pageSize.HasValue) pageSize = take;
            if (string.IsNullOrEmpty(keyword)) keyword = "";
            ViewData["keyword"] = keyword;
            ViewData["take"] = take;
            ViewData["page"] = page;
            ViewData["pageSize"] = pageSize;
            ViewData["categoryId"] = categoryId.Value;
            ViewData["status"] = status.Value;
            ViewData["type"] = type.Value;
            var userInfo = await _userManager.GetUserAsync(User);
            HttpContext.Session.SetString("GroupId", userInfo.GroupId.ToString());
            return View();
        }

        [DisplayName("Tạo mới tin tức")]
        public IActionResult Create()
        {
            ViewData["UserId"] = UserId;
            ViewData["UserEmail"] = UserEmail;
            ViewData["UserName"] = UserName;
            ViewData["UserFullName"] = UserFullName;

            List<SelectListItem> statusNews = new List<SelectListItem>() {
                new SelectListItem() { Value =  ((int)IsStatus.approved).ToString(), Text = "Đã xác nhận" },
                new SelectListItem() { Value =  ((int)IsStatus.draft).ToString(), Text = "Tin nháp" },
                new SelectListItem() { Value =  ((int)IsStatus.pending).ToString(), Text = "Đang chờ xử lý", Selected = true },
                new SelectListItem() { Value =  ((int)IsStatus.publish).ToString(), Text = "Đã đăng" }
            };

            ViewData["statusNews"] = statusNews;

            return View();
        }

        [DisplayName("Cập nhật tin tức")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _newsService.GetHomeNewsById(id.Value);
            if (entity == null)
            {
                return NotFound();
            }
            var viewModel = Mapper.Map<HomeNews, NewsViewModel>(entity);

            List<SelectListItem> statusNews = new List<SelectListItem>() {
                new SelectListItem() { Value =  ((int)IsStatus.approved).ToString(), Text = "Đã xác nhận" },
                new SelectListItem() { Value =  ((int)IsStatus.draft).ToString(), Text = "Tin nháp" },
                new SelectListItem() { Value =  ((int)IsStatus.pending).ToString(), Text = "Đang chờ xử lý", Selected = true },
                new SelectListItem() { Value =  ((int)IsStatus.publish).ToString(), Text = "Đã đăng" }
            };

            ViewData["statusNews"] = statusNews;

            return View(viewModel);
        }
    }
}
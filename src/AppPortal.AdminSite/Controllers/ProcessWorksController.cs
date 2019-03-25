using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.AdminSite.ViewModels;
using AppPortal.AdminSite.ViewModels.News;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Xử lý công việc")]
    public class ProcessWorksController : AdminBaseController<ProcessWorksController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly INewsService _newsService;
        public ProcessWorksController(
            UserManager<ApplicationUser> userManager,
            INewsService newsService,
            IConfiguration configuration,
            IAppLogger<ProcessWorksController> logger) : base(configuration, logger)
        {
            _newsService = newsService;
            _userManager = userManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [DisplayName("Quản lý ý kiến đóng góp")]
        public IActionResult Index(string keyword, int? pageSize, int? take = 15, int? skip = 0, int? page = 1, int? categoryId = -1, int? status = -1, int? type = -1)
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
            return View();
        }

        [DisplayName("Tạo mới góp ý")]
        public IActionResult Create()
        {
            ViewData["UserId"] = UserId;
            ViewData["UserEmail"] = UserEmail;
            ViewData["UserName"] = UserName;
            ViewData["UserFullName"] = UserFullName;

            List<SelectListItem> statusNews = new List<SelectListItem>() {
                new SelectListItem() { Value =  ((int)IsStatus.pending).ToString(), Text = "Đang chờ xử lý", Selected = true },
                new SelectListItem() { Value =  ((int)IsStatus.publish).ToString(), Text = "Công bố" },
                new SelectListItem() { Value =  ((int)IsStatus.draft).ToString(), Text = "Tiếp nhận & chuyển" },
                new SelectListItem() { Value =  ((int)IsStatus.approved).ToString(), Text = "Xác nhận duyệt yêu cầu" },
                new SelectListItem() { Value =  ((int)IsStatus.deleted).ToString(), Text = "Yêu cầu không hợp lệ." },
            };

            ViewData["statusNews"] = statusNews;

            return View();
        }

        [DisplayName("Xử lý ý kiến người dân")]
        public IActionResult Step(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _newsService.GetNewsById(id.Value);
            if (entity == null)
            {
                return NotFound();
            }
            var viewModel = Mapper.Map<NewsModel, NewsViewModel>(entity);
            
            List<SelectListItem> statusNews = new List<SelectListItem>() {
                new SelectListItem() { Value =  ((int)IsStatus.pending).ToString(), Text = "Đang chờ xử lý", Selected = true },
                new SelectListItem() { Value =  ((int)IsStatus.publish).ToString(), Text = "Công bố" },
                new SelectListItem() { Value =  ((int)IsStatus.draft).ToString(), Text = "Tiếp nhận & chuyển" },
                new SelectListItem() { Value =  ((int)IsStatus.approved).ToString(), Text = "Xác nhận duyệt yêu cầu" },
                new SelectListItem() { Value =  ((int)IsStatus.deleted).ToString(), Text = "Yêu cầu không hợp lệ." },
            };

            ViewData["statusNews"] = statusNews;

            // get lst User Gửi thông báo
            var lstUsers = _userManager.Users.Where(u => u.EmailConfirmed == true).Select(u => new UserViewModel
            {
                Id = u.Id,
                Email = u.Email,
                FullName = u.FullName,
                Phone = u.PhoneNumber,
                TypeAccount = u.TypeUser
            }).ToList();

            ViewData["lstUsers"] = lstUsers;

            return View(viewModel);
        }
    }
}
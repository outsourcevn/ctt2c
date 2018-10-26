using System.ComponentModel;
using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.AdminSite.ViewModels.Cats;
using AppPortal.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Quản trị chủ đề góp ý")]
    public class TopicsController : AdminBaseController<TopicsController>
    {
        private readonly ICategoryService _categoryService;
        public TopicsController(
             ICategoryService categoryService,
            IConfiguration configuration, 
            IAppLogger<TopicsController> logger) : base(configuration, logger)
        {
            _categoryService = categoryService;
        }

        [DisplayName("Quản lý chủ đề")]
        public IActionResult Index(string keyword, int? pageSize, int? take = 15, int? skip = 0, int? page = 1, int? parentId = -1, int? excludeId = -1)
        {
            if (!take.HasValue) take = 15;
            if (!page.HasValue) page = 1;
            if (!pageSize.HasValue) pageSize = take;
            if (string.IsNullOrEmpty(keyword)) keyword = "";
            ViewData["keyword"] = keyword;
            ViewData["take"] = take;
            ViewData["page"] = page;
            ViewData["pageSize"] = pageSize;
            ViewData["parentId"] = parentId.Value;
            ViewData["excludeId"] = excludeId.Value;
            return View();
        }

        [DisplayName("Tạo mới chủ đề")]
        public IActionResult Create()
        {
            CategoryViewModel viewModel = new CategoryViewModel();
            return View(viewModel);
        }

        [DisplayName("Cập nhật chủ đề")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _categoryService.GetCategoryById(null, id);
            if (entity == null)
            {
                return NotFound();
            }

            var viewModel = Mapper.Map<CategoryModel, CategoryViewModel>(entity);

            return View(viewModel);
        }
    }
}
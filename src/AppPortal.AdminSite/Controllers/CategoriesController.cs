using AppPortal.AdminSite.Controllers.Base;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.AdminSite.ViewModels.Cats;
using AppPortal.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;

namespace AppPortal.AdminSite.Controllers
{
    [DisplayName("Quản trị danh mục")]
    public class CategoriesController : AdminBaseController<CategoriesController>
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(
            ICategoryService categoryService,
            IConfiguration configuration, 
            IAppLogger<CategoriesController> logger) : base(configuration, logger)
        {
            _categoryService = categoryService;
        }

        [DisplayName("Quản lý danh mục")]
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

        [DisplayName("Tạo mới danh mục")]
        public IActionResult Create()
        {
            CategoryViewModel viewModel = new CategoryViewModel();
            return View(viewModel);
        }

        [DisplayName("Cập nhật danh mục")]
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
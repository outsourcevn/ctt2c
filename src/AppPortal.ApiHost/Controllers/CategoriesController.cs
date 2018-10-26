using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.ApiHost.Controllers.Base;
using AppPortal.ApiHost.ViewModels;
using AppPortal.ApiHost.ViewModels.Cats;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]
    public class CategoriesController : ApiBaseController<CategoriesController>
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(
            IConfiguration configuration, 
            IAppLogger<CategoriesController> logger,
            ICategoryService categoryService) : base(configuration, logger)
        {
            _categoryService = categoryService;
        }

        // list
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("getCats")]
        public IActionResult ListCatsAsync(string keyword = "", int? take = 15, int? skip = 0, int? page = 1, int? parentId = -1, int? excludeId = -1)
        {
            var query = _categoryService.GetListCatPaging(out int rows, skip, take, keyword, parentId, excludeId);
            var vm = query.Select(n => Mapper.Map<ListItemCategoryModel, ListItemCategoryViewModel>(n));
            return ResponseInterceptor(vm, rows, new Paging()
            {
                PageNumber = page.Value,
                PageSize = take.Value,
                Take = take.Value,
                Skip = skip.Value,
                Query = keyword,
            });
        }
        // create
        // update
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("CreateOrUpdate")]
        public IActionResult CreateOrUpdate(int? Id, [FromBody] CategoryViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            string message = "Thêm danh mục thành công";
            try
            {
                var entityModel = Mapper.Map<CategoryViewModel, CategoryModel>(model);
                if (Id.HasValue && Id > 0)
                {
                    message = "Cập nhật danh mục thành công";
                    entityModel.Id = Id.Value;
                }
                entityModel.ShowType = Core.Entities.ShowType.IsNormal;
                _categoryService.AddOrUpdate(entityModel);
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        // delete
        // deleteall
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("Delete")]
        public IActionResult Delete([FromBody] int? Id)
        {
            if(!Id.HasValue)
            {
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = "The Id is request.",
                }));
            }
            var entity = _categoryService.GetCategoryById(null, Id.Value);
            if (entity == null)
            {
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = "Danh mục không tồn tại.",
                }));
            }
            string message = "";
            try
            {
                _categoryService.Delete(Id.Value);
                message = "Danh mục đã được xóa.";
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("getTreeCats")]
        public async Task<IActionResult> GetTreeCats()
        {
            var cat = await _categoryService.GetTree();
            var viewModel = cat.Select(c => Mapper.Map<TreeCategoryModel, TreeCategoryViewModel>(c));
            return ResponseInterceptor(viewModel);
        }
    }
}
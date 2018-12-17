using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Website.Services.Extensions;
using AppPortal.Website.Services.Interfaces;
using AppPortal.Website.Services.Models.Cats;
using Microsoft.EntityFrameworkCore;

namespace AppPortal.Website.Services.Websites
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category, int> _category;
        private readonly IAsyncRepository<Category, int> _categoryAsync;

        public CategoryService(
            IRepository<Category, int> category,
            IAsyncRepository<Category, int> categoryAsync)
        {
            _category = category;
            _categoryAsync = categoryAsync;
        }

        public CategoryModel GetCategoryById(string seeName, int? id)
        {
            Category item;
            if (id.HasValue) item = _category.Table.FirstOrDefault(x => x.Id == id);
            else item = _category.Table.FirstOrDefault(x => x.Sename == seeName);
            return item.EntityToModel();
        }

        public async Task<IList<TreeCategoryModel>> GetTree()
        {
            var lst = await _category.Table
                                     .Where(x => x.ParentId == null || x.ParentId == 0 && x.IsShow == true && x.ShowType == ShowType.IsNormal)
                                     .Select(x => new TreeCategoryModel
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         IsShow = x.IsShow,
                                         OrderSort = x.OrderSort,
                                         Sename = x.Sename,
                                         TargetUrl = x.TargetUrl,
                                     }).ToListAsync();
            lst.ForEach(item => item.items = GetChilds(item.Id));
            return lst;
        }

        public async Task<IList<TreeCategoryModel>> GetTopicTree()
        {
            var lst = await _category.Table
                                     .Where(x => x.ParentId == null || x.ParentId == 0 && x.IsShow == true && x.ShowType == ShowType.IsTopic)
                                     .Select(x => new TreeCategoryModel
                                     {
                                         Id = x.Id,
                                         Name = x.Name,
                                         IsShow = x.IsShow,
                                         OrderSort = x.OrderSort,
                                         Sename = x.Sename,
                                         TargetUrl = x.TargetUrl,
                                     }).ToListAsync();
            lst.ForEach(item => item.items = GetChilds(item.Id));
            return lst;
        }

        public IQueryable<Category> GetTables()
        {
            return _category.Table;
        }

        private IList<TreeCategoryModel> GetChilds(int? parentId)
        {
            var lst = _category.Table.Where(x => x.ParentId == parentId && x.IsShow == true).Select(x => new TreeCategoryModel
            {
                Id = x.Id,
                Name = x.Name,
                IsShow = x.IsShow,
                OrderSort = x.OrderSort,
                Sename = x.Sename,
                TargetUrl = x.TargetUrl
            }).ToList();
            lst.ForEach(item => item.items = GetChilds(item.Id));
            return lst;
        }
    }
}

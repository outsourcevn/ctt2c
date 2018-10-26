using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services.Extensions;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppPortal.AdminSite.Services.Administrator
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

        public void AddOrUpdate(CategoryModel model)
        {
            Category entity = null;
            if (model.Id > 0) entity = _category.GetById(model.Id);
            entity = model.ModelToEntity(entity);

            if (model.Id > 0)
            {
                entity.OnUpdated = DateTime.Now;
                _category.Update(entity);
            }
            else
            {
                entity.OnCreated = DateTime.Now;
                if (entity.IsShow) entity.OnPublished = DateTime.Now;
                _category.Add(entity);
            }
        }

        public void Delete(int id)
        {
            var entity = _category.GetById(id);
            if (entity != null)
                _category.Delete(entity);
        }

        public CategoryModel GetCategoryById(string seeName, int? id = 0)
        {
            if (id.HasValue && id.Value != 0)
            {
                var item = _category.Table.SingleOrDefault(x => x.Id == id);
                return item.EntityToModel();
            }               
            else
            {
               var item = _category.Table.SingleOrDefault(x => x.Sename == seeName && x.Id == id);
               return item.EntityToModel();
            }            
        }

        public IList<ListItemCategoryModel> GetListCatPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? parentId = -1, int? excludeId = -1)
        {
            var query = GetTables().Where(x => !string.Equals(x.ShowType, ShowType.IsTopic));
            if (query == null)
            {
                rows = 0;
                return new List<ListItemCategoryModel>() { };
            }
            if (!string.IsNullOrEmpty(keyword) && keyword != "")
                query = query.Where(x => x.Name.Contains(keyword) || x.Sename.Contains(keyword));

            if (parentId > 0) query = query.Where(x => x.ParentId == parentId);
            if (excludeId > 0) query = query.Where(x => x.Id != excludeId);
            rows = query.Count();

            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.Skip(skip.Value).Take(take.Value);
            return GetList(query);
        }

        public IList<ListItemCategoryModel> GetListTopicPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? parentId = -1, int? excludeId = -1)
        {
            var query = GetTables().Where(x => string.Equals(x.ShowType, ShowType.IsTopic));
            if (query == null)
            {
                rows = 0;
                return new List<ListItemCategoryModel>() { };
            }
            if (!string.IsNullOrEmpty(keyword) && keyword != "")
                query = query.Where(x => x.Name.Contains(keyword) || x.Sename.Contains(keyword));

            if (parentId > 0) query = query.Where(x => x.ParentId == parentId);
            if (excludeId > 0) query = query.Where(x => x.Id != excludeId);
            rows = query.Count();

            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.Skip(skip.Value).Take(take.Value);
            return GetList(query);
        }

        public async Task<IList<TreeCategoryModel>> GetTree()
        {
            var lst = await _category.Table
                                     .Where(x => (x.ParentId == null || x.ParentId == 0) && x.IsShow == true && x.ShowType == ShowType.IsNormal)
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

        public async Task<IList<TreeCategoryModel>> GetTopicsTree()
        {
            var lst = await _category.Table
                                     .Where(x => (x.ParentId == null || x.ParentId == 0) && x.IsShow == true && x.ShowType == ShowType.IsTopic)
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

        private IList<ListItemCategoryModel> GetList(IQueryable<Category> category)
        {
            var results = new List<ListItemCategoryModel>();
            var lst = category
                .Where(x => x.ParentId == null || x.ParentId == 0)
                .Select(x => new ListItemCategoryModel { Id = x.Id, Name = x.Name }).ToList();
            foreach (var item in lst)
            {
                item.Level = 0;
                item.PrefixName = item.Name;
                results.Add(item);
                var items = GetList(1, "|--", item.Id);
                if (items != null) results.AddRange(items);
            }
            return results;
        }

        public IList<ListItemCategoryModel> GetListCategory()
        {
            var results = new List<ListItemCategoryModel>();
            var lst = GetTables()
                .Where(x => x.ParentId == null || x.ParentId == 0 && x.IsShow == true)
                .Select(x => new ListItemCategoryModel { Id = x.Id, Name = x.Name }).ToList();
            foreach (var item in lst)
            {
                item.Level = 0;
                item.PrefixName = item.Name;
                results.Add(item);
                var items = GetList(1, "|--", item.Id);
                if (items != null) results.AddRange(items);
            }
            return results;
        }

        public IQueryable<Category> GetTables()
        {
            return _category.Table;
        }

        private IList<ListItemCategoryModel> GetList(int level, string separate, int parentId)
        {
            var lst = GetTables().Where(x => x.ParentId == parentId).Select(x => new ListItemCategoryModel { Id = x.Id, Name = x.Name }).ToList();
            if (lst.Count < 1) return null;
            var results = new List<ListItemCategoryModel>();
            foreach (var item in lst)
            {
                item.Level = level;
                item.PrefixName = separate + item.Name;
                results.Add(item);
                var items = GetList(level + 1, separate + "|--", item.Id);
                if (items != null) results.AddRange(items);
            }
            return results;
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

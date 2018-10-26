using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.Core.Entities;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface ICategoryService
    {
        void AddOrUpdate(CategoryModel model);
        void Delete(int Id);
        CategoryModel GetCategoryById(string seeName, int? id = null);
        IList<ListItemCategoryModel> GetListCatPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? parentId = -1, int? excludeId = -1);
        IList<ListItemCategoryModel> GetListTopicPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? parentId = -1, int? excludeId = -1);
        Task<IList<TreeCategoryModel>> GetTree();
        Task<IList<TreeCategoryModel>> GetTopicsTree();
        IList<ListItemCategoryModel> GetListCategory();
        IQueryable<Category> GetTables();
    }
}

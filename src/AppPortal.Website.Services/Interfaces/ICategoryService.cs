using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.Core.Entities;
using AppPortal.Website.Services.Models.Cats;

namespace AppPortal.Website.Services.Interfaces
{
    public interface ICategoryService
    {
        CategoryModel GetCategoryById(string seeName, int? id = null);
        Task<IList<TreeCategoryModel>> GetTree();
        Task<IList<TreeCategoryModel>> GetTopicTree();
        IQueryable<Category> GetTables();
    }
}

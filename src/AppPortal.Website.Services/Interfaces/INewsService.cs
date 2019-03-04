using System.Collections.Generic;
using System.Linq;
using AppPortal.Core.Entities;
using AppPortal.Website.Services.Models.News;

namespace AppPortal.Website.Services.Interfaces
{
    public interface INewsService
    {
        void AddOrUpdate(NewsModel model);
        NewsModel GetNewsById(int id);
        ItemsNewWithCategory GetItemNewsWithCategory(int? catId, int? count);
        ItemsNewWithCategory GetItemNewsForTopOfCategory();
        IList<NewsModel> GetNewsPaging(out int rows, int? take = 15, int? skip = 0, int? catId = -1);
        IQueryable<News> GetTables(); 
        IList<News> GetNewsList();
        Config GetConfig(string type);
        NewsModel GetNewsByMatin(string matin);
    }
}

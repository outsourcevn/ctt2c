using System;
using System.Collections.Generic;
using System.Linq;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Website.Services.Extensions;
using AppPortal.Website.Services.Interfaces;
using AppPortal.Website.Services.Models.News;

namespace AppPortal.Website.Services.Websites
{
    public class NewsService : INewsService
    {
        private readonly IRepository<News, int> _news;
        private readonly IAsyncRepository<News, int> _newsAsync;
        private readonly IRepository<Category, int> _category;
        private readonly IAppLogger<NewsService> _appLogger;
        private readonly IRepository<Config, int> _config;
        public NewsService(
            IRepository<News, int> news,
            IAsyncRepository<News, int> newsAsync,
            IRepository<Category, int> category,
            IRepository<Config, int> config,
            IAppLogger<NewsService> appLogger)
        {
            _news = news;
            _newsAsync = newsAsync;
            _category = category;
            _config = config;
            _appLogger = appLogger;
        }

        public Config GetConfig(string type)
        {
            return _config.Table.Where(x => x.type == type).FirstOrDefault();
        }

        public void AddOrUpdate(NewsModel model)
        {
            News entity = null;
            if (model.Id > 0) entity = _news.GetById(model.Id);
            entity = model.ModelToEntity(entity);
            if (model.Id > 0)
            {

                entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.pending;
                entity.OnUpdated = DateTime.Now;
                _news.Update(entity);               
            }
            else
            {
                var itemCat = _category.GetById(model.CategoryId.Value) ?? null;
                entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.pending;
                entity.OnCreated = DateTime.Now;
                entity.NewsCategories = new List<NewsCategory>
                {
                    new NewsCategory
                    {
                        CategoryId = entity.CategoryId,
                        NewsId = entity.Id,
                        News = entity,
                        Categories = itemCat
                    }
                };
                _news.Add(entity);
            }
        }

        public ItemsNewWithCategory GetItemNewsForTopOfCategory()
        {
            var datas = new List<News>();
            var countCats = _category.Table.Where(x => x.IsShow == true && x.ShowType == ShowType.IsNormal).Count();
            for (int i = 1; i <= countCats; i++)
            {
                var data = GetTables()
                             .Where(t => t.CategoryId == i && t.IsShow == true && (t.IsStatus == IsStatus.publish || t.IsStatus == IsStatus.approved))
                             .OrderByDescending(t => t.OnCreated).Take(1).ToList();
                datas.AddRange(data);
            }

            return new ItemsNewWithCategory(1, null, datas.MapLstEntityToListModel());
        }

        public ItemsNewWithCategory GetItemNewsWithCategory(int? catId, int? count)
        {
            if (!count.HasValue) count = 4;
            var catName = _category.GetById(catId.Value)?.Name;
            var datas = GetTables()
                .Where(t => t.CategoryId == catId && t.IsShow == true && (t.IsStatus == IsStatus.publish || t.IsStatus == IsStatus.approved))
                .OrderByDescending(t => t.OnCreated).Take(count.Value);
            return new ItemsNewWithCategory(catId.Value, catName, datas.ToList().MapLstEntityToListModel());
        }

        public NewsModel GetNewsById(int id)
        {
            return GetTables().SingleOrDefault(x => x.Id == id).EntityToModel();
        }

        public NewsModel GetNewsByMatin(string matin)
        {
            return GetTables().SingleOrDefault(x => x.MaPakn == matin).EntityToModel();
        }

        public IList<NewsModel> GetNewsPaging(out int rows, int? take = 15, int? skip = 0, int? catId = -1)
        {
            var query = GetTables().Where(x => x.IsShow == true && x.IsStatus == IsStatus.publish && !x.OnDeleted.HasValue);
            if (query == null)
            {
                rows = 0;
                return new List<NewsModel>() { };
            }
            if (catId.HasValue && catId.Value > -1) query = query.Where(x => x.CategoryId == catId);
            rows = query.Count();
            query = query.OrderByDescending(x => x.OnCreated);
            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.Skip(skip.Value).Take(take.Value);
            return query.Select(x => x.EntityToModel()).ToList();
        }

        public IQueryable<News> GetTables()
        {
            return _news.Table;
        }

        public IList<News> GetNewsList()
        {
            return _news.Table.Where(x => x.IsStatus == IsStatus.approved).OrderByDescending(z => z.OnPublished).Take(3).ToList();
        }
    }
}

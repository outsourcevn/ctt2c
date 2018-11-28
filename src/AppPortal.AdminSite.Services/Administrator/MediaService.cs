using System;
using System.Collections.Generic;
using System.Linq;
using AppPortal.AdminSite.Services.Extensions;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;

namespace AppPortal.AdminSite.Services.Administrator
{
    public class MediaService : IMediaService
    {
        private readonly IRepository<News, int> _news;
        private readonly IAsyncRepository<News, int> _newsAsync;
        private readonly IRepository<NewsCategory, int> _newsCat;
        private readonly IRepository<NewsRelated, int> _newsRelated;
        private readonly IRepository<Category, int> _category;
        private readonly IAppLogger<NewsService> _appLogger;
        private readonly IRepository<ReportNews, int> _rptNews;
        private readonly IRepository<Notifications, int> _notifi;
        private readonly IRepository<NewsLog, int> _newslog;
        private readonly IRepository<Files, int> _files;
        private readonly IRepository<Media, int> _media;
        public MediaService(
            IRepository<News, int> news,
            IAsyncRepository<News, int> newsAsync,
            IRepository<NewsCategory, int> newsCat,
            IRepository<NewsRelated, int> newsRelated,
            IRepository<ReportNews, int> ReportNews,
            IRepository<Category, int> category,
            IRepository<Notifications, int> notifi,
            IRepository<NewsLog, int> newslog,
            IRepository<Files, int> files,
            IRepository<Media, int> medias,
            IAppLogger<NewsService> appLogger)
        {
            _news = news;
            _newsAsync = newsAsync;
            _newsCat = newsCat;
            _newsRelated = newsRelated;
            _category = category;
            _appLogger = appLogger;
            _rptNews = ReportNews;
            _notifi = notifi;
            _newslog = newslog;
            _files = files;
            _media = medias;
        }

        public IList<Media> GetMedia(string type)
        {
            return _media.Table.Where(x => x.OnDeleted.HasValue && x.OnPublish.HasValue && x.type == type).ToList();
        }

        public void delete(int id)
        {
            var media = _media.Table.Where(x => x.Id == id).FirstOrDefault();
            if(media != null)
            {
                media.OnDeleted = DateTime.Now;
                _media.Update(media);
            }
        }

        public void AddOrEdit(Media model)
        {
            if(model.Id > 0)
            {
                //la edit
                var media = _media.Table.Where(x => x.Id == model.Id).FirstOrDefault();
                if(media != null)
                {
                    media.description = model.description;
                    media.name = model.name;
                    _media.Update(media);
                }
            }
            else
            {
                var media = new Media();
                media.name = model.name;
                media.description = model.description;
                media.size = model.size;
                media.type = model.type;
                media.OnCreated = DateTime.Now;
                media.url = model.url;
                _media.Add(media);
            }
        }

    }
}

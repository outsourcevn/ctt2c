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
    public class NewsLogService : INewsLog
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
        public NewsLogService(
            IRepository<News, int> news,
            IAsyncRepository<News, int> newsAsync,
            IRepository<NewsCategory, int> newsCat,
            IRepository<NewsRelated, int> newsRelated,
            IRepository<ReportNews, int> ReportNews,
            IRepository<Category, int> category,
            IRepository<Notifications, int> notifi,
            IRepository<NewsLog, int> newslog,
            IRepository<Files, int> files,
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
        }

        public void AddOrUpdate(NewsLog model)
        {
            NewsLog entity = null;
            if (model.Id > 0) entity = _newslog.GetById(model.Id);
            if (model.Id > 0)
            {
                entity.Note = model.Note;
                entity.OnCreated = DateTime.Now;
                _newslog.Update(entity);
            }
            else
            {
                entity = model;
                _newslog.Add(entity);
            }
        }

        public void Delete(int id)
        {
            var entity = _news.GetById(id);
            if (entity != null)
            {
                entity.OnDeleted = DateTime.Now;
                entity.IsShow = false;
                entity.IsStatus = IsStatus.deleted;
                _news.Update(entity);
            }
        }

        public NewsLog GetNewLogPhanCong(int NewsId)
        {
            return _newslog.Table.Where(x => x.NewsId == NewsId).Where(z => z.GroupNameTo == "dvct").FirstOrDefault();
        }

        public NewsLog GetNewsLogByNewsIdUser(int NewsId , string username)
        {
            return _newslog.Table.Where(x => x.NewsId == NewsId).Where(z => z.UserName == username).FirstOrDefault();
        }

        public IList<NewsLog> GetNewsLogByNewsIdGroupNameFrom(int NewsId, string GroupNameFrom , int type)
        {
            var compare = IsTypeStatus.is_phancong;
            if(type == 4)
            {
                compare = IsTypeStatus.is_chuyencongvan;
            }
            return _newslog.Table.Where(x => x.NewsId == NewsId)
                .Where(i => i.TypeStatus == compare)
                .ToList();
        }

        public IList<NewLogUpLoad> GetReport(int NewsId)
        {
            var dataReturn = new List<NewLogUpLoad>();
            var data = _newslog.Table.Where(x => x.NewsId == NewsId).Where(x => x.GroupNameTo == "dvct").ToList();
            foreach(var item in data)
            {
                var obj = new NewLogUpLoad();
                obj.Data = item.Data;
                obj.FullUserName = item.FullUserName;
                var file = _files.Table.Where(e => e.NewsLogId == item.Id).ToList();
                obj.files = file;
                dataReturn.Add(obj);
            }

            return dataReturn;
        }

        public IList<NewsLog> GetNewsLogByNewsIdNameFrom(int NewsId, string UserName)
        {
            if(UserName == "is_ano")
            {
                var data = _newslog.Table.Where(x => x.NewsId == NewsId).Where(x => x.GroupNameTo == "dvct").FirstOrDefault();
                UserName = data.UserName;
            }
            return _newslog.Table.Where(x => x.NewsId == NewsId)
                .Where(z => z.UserName == UserName)
                .ToList();
        }

        public NewsLog GetInfoNewLog(int news_id, string group)
        {
            return _newslog.Table.Where(x => x.NewsId == news_id)
                .Where(z => z.GroupNameTo == group)
                .FirstOrDefault();
        }

        public NewsLogFile GetInfoNewLogAndFile(int news_id, string group)
        {
            return _newslog.Table.Where(x => x.NewsId == news_id)
                .Where(z => z.GroupNameTo == group)
                .GroupJoin(_files.Table, x => x.Id, y => y.NewsLogId, (newslog, filesLst) => new NewsLogFile
                {
                    newsLog = newslog,
                    lstFiles = filesLst.Where(z => z.NewsLogId == newslog.Id).ToList()
                }).FirstOrDefault();
        }

        public IList<NewsLog> GetPhanCongList(int news_id, string group)
        {
            return _newslog.Table.Where(x => x.NewsId == news_id)
               .Where(z => z.GroupNameFrom == group)
               .OrderByDescending(z => z.OnCreated)
               .Take(1)
               .ToList();
        }

        public NewsLog AddOrUpdateReport(int id, string data, int? typeStatus = 0)
        {
            var item = _newslog.Table.Where(x => x.Id == id).FirstOrDefault();
            if(item != null)
            {
                item.Data = data;
                //khong phai la bao cao
                if (typeStatus > 0) item.TypeStatus = (IsTypeStatus)typeStatus;

                if (typeStatus == 5) item.OnXuly = DateTime.Now;
                // = 0 la bao cao
                _newslog.Update(item);
                if (typeStatus == 0)
                {
                    var news = _news.Table.Where(x => x.Id == item.NewsId).FirstOrDefault();
                    if (news != null)
                    {
                        if ((IsTypeStatus)typeStatus == IsTypeStatus.chuyentralai)
                        {
                            news.IsStatus = IsStatus.chuyentralai;
                        }
                        else
                        {
                            news.IsStatus = IsStatus.baocao;
                        }
                        
                        news.OnPublished = DateTime.Now;
                        _news.Update(news);
                    }
                }
                if(typeStatus == 7)
                {
                    var news = _news.Table.Where(x => x.Id == item.NewsId).FirstOrDefault();
                    if (news != null)
                    {
                        news.IsStatus = IsStatus.chuyentralai;
                        news.OnPublished = DateTime.Now;
                        _news.Update(news);
                    }
                }
                if (typeStatus == 5) {
                    var news = _news.Table.Where(x => x.Id == item.NewsId).FirstOrDefault();
                    if (news != null)
                    {
                        news.IsStatus = IsStatus.baocao;
                        news.OnPublished = DateTime.Now;
                        _news.Update(news);
                    }
                }

            }
            return item;
        }

        public int AddtoFileTable(FileUpload fileUpload , string id)
        {
            var file = new Files();
            file.isDelete = 0;
            file.name = fileUpload.name;
            file.NewsLogId = Int32.Parse(id);
            file.size = fileUpload.size;
            file.thumbnailUrl = fileUpload.thumbnailUrl;
            file.type = fileUpload.type;
            file.url = fileUpload.url;
            file.OnCreated = DateTime.Now;
            _files.Add(file);
            return file.Id;
        }

        public string DeleteFile(int id)
        {
            try
            {
                var file = _files.Table.Where(e => e.Id == id).FirstOrDefault();
                if(file != null)
                {
                    file.isDelete = 1;
                    _files.Update(file);
                    return file.name;
                }
                return String.Empty;
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public List<FileUpload> GetFile(int id , string urlWeb)
        {
            var data = new List<FileUpload>();
            var fileUpLoad = _files.Table.Where(e => e.NewsLogId == id && e.isDelete == 0).ToList();
            if (fileUpLoad != null)
            {
                foreach (var item in fileUpLoad)
                {
                    var obj = new FileUpload();
                    obj.deleteType = "DELETE";
                    obj.name = item.name;
                    obj.size = item.size;
                    obj.thumbnailUrl = item.url;
                    obj.type = item.type;
                    obj.url = item.url;
                    obj.deleteUrl = urlWeb + "/api/NewsLog/delete/" + item.Id.ToString();
                    data.Add(obj);
                }
            }
           
            return data;
        }
    }
}

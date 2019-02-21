using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AppPortal.AdminSite.Services.Extensions;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;

namespace AppPortal.AdminSite.Services.Administrator
{
    public class NewsService : INewsService
    {
        private readonly IRepository<News, int> _news;
        private readonly IAsyncRepository<News, int> _newsAsync;
        private readonly IRepository<NewsCategory, int> _newsCat;
        private readonly IRepository<NewsRelated, int> _newsRelated;
        private readonly IRepository<Category, int> _category;
        private readonly IAppLogger<NewsService> _appLogger;
        private readonly IRepository<ReportNews , int> _rptNews;
        private readonly IRepository<Notifications , int> _notifi;
        private readonly IRepository<NewsLog , int> _newLog;
        private readonly IRepository<HomeNews , int> _homeNews;
        private readonly IRepository<NewsPreview , int> _newsPreview;
        private readonly IRepository<Files, int> _files;

        public NewsService(
            IRepository<News, int> news,
            IAsyncRepository<News, int> newsAsync,
            IRepository<NewsCategory, int> newsCat,
            IRepository<NewsRelated, int> newsRelated,
            IRepository<ReportNews, int> ReportNews,
            IRepository<Category, int> category,
            IRepository<Notifications, int> notifi,
            IRepository<NewsLog, int> newLog,
            IRepository<HomeNews, int> homeNews,
            IRepository<NewsPreview, int> newsPreview,
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
            _newLog = newLog;
            _homeNews = homeNews;
            _newsPreview = newsPreview;
            _files = files;
        }

        public IList<GetReport1> GetReport1(string startdate, string enddate)
        {
            var report = new List<GetReport1>();
            var tiepnhan = _news.Table;
            var dangxuly = _news.Table.Where(x => x.IsStatus == IsStatus.baocao);
            var phancong = _news.Table.Where(x => x.IsStatus == IsStatus.phancong);
            var approved = _news.Table.Where(x => x.IsStatus == IsStatus.approved);
            if (!string.IsNullOrEmpty(startdate))
            {
                tiepnhan = tiepnhan.Where(x => x.OnCreated >= DateTime.Parse(startdate));
                phancong = phancong.Where(x => x.OnCreated >= DateTime.Parse(startdate));
                approved = approved.Where(x => x.OnCreated >= DateTime.Parse(startdate));
                dangxuly = dangxuly.Where(x => x.OnCreated >= DateTime.Parse(startdate));
            }

            if (!string.IsNullOrEmpty(enddate))
            {
                tiepnhan = tiepnhan.Where(x => x.OnCreated <= DateTime.Parse(enddate));
                phancong = phancong.Where(x => x.OnCreated <= DateTime.Parse(enddate));
                approved = approved.Where(x => x.OnCreated <= DateTime.Parse(enddate));
                dangxuly = dangxuly.Where(x => x.OnCreated <= DateTime.Parse(enddate));
            }

            report.Add(new GetReport1()
            {
                type = IsStatus.tiepnhan,
                count = tiepnhan.Count(),
                typeString = "Tiếp nhận"
            });

            report.Add(new GetReport1()
            {
                type = IsStatus.phancong,
                count = phancong.Count(),
                typeString = "Phân công"
            });

            report.Add(new GetReport1()
            {
                type = IsStatus.approved,
                count = approved.Count(),
                typeString = "Công bố"
            });

            report.Add(new GetReport1()
            {
                type = IsStatus.baocao,
                count = dangxuly.Count(),
                typeString = "Đang xử lý"
            });

            return report;
        }

        public IList<GetReport1> GetReport2(string startdate, string enddate)
        {
            var report = new List<GetReport1>();
            var nguoidan = _news.Table.Where(x => x.doituong == 0);
            var doanhnghiep = _news.Table.Where(x => x.doituong == 1);
            if (!string.IsNullOrEmpty(startdate))
            {
                nguoidan = nguoidan.Where(x => x.OnCreated >= DateTime.Parse(startdate));
                doanhnghiep = doanhnghiep.Where(x => x.OnCreated >= DateTime.Parse(startdate));
            }

            if (!string.IsNullOrEmpty(enddate))
            {
                nguoidan = nguoidan.Where(x => x.OnCreated <= DateTime.Parse(enddate));
                doanhnghiep = doanhnghiep.Where(x => x.OnCreated <= DateTime.Parse(enddate));
            }

            report.Add(new GetReport1()
            {
                count = nguoidan.Count(),
                typeString = "Người dân"
            });

            report.Add(new GetReport1()
            {
                count = doanhnghiep.Count(),
                typeString = "Doanh nghiệp"
            });

            return report;
        }

        public IList<GetReport2> GetReport3(string startdate, string enddate)
        {
            var report = new List<GetReport1>();
            var nguoidan = _news.Table.Where(x => x.doituong == 0);
            var doanhnghiep = _news.Table.Where(x => x.doituong == 1);
            if (!string.IsNullOrEmpty(startdate))
            {
                nguoidan = nguoidan.Where(x => x.OnCreated >= DateTime.Parse(startdate));
                doanhnghiep = doanhnghiep.Where(x => x.OnCreated >= DateTime.Parse(startdate));
            }
            
            if (!string.IsNullOrEmpty(enddate))
            {
                nguoidan = nguoidan.Where(x => x.OnCreated <= DateTime.Parse(enddate));
                doanhnghiep = doanhnghiep.Where(x => x.OnCreated <= DateTime.Parse(enddate));
            }

            var nguoidanGr = nguoidan.GroupBy(x => x.IsType).Select(group => new GetReport2
            {
                type = group.Key,
                typeString = "Người dân",
                count = group.Count(),
                chudeString = convertChudeToString(group.Key)
            }).ToList();

            var doanhnghiepGr = doanhnghiep.GroupBy(x => x.IsType).Select(group => new GetReport2
            {
                type = group.Key,
                typeString = "Doanh nghiệp",
                count = group.Count(),
                chudeString = convertChudeToString(group.Key)
            }).ToList();

            return doanhnghiepGr.Concat(nguoidanGr).ToList();
        }

        public IList<GetReport2> GetReport4(string startdate, string enddate)
        {
            var report = new List<GetReport1>();
            var nguoidan = _news.Table.Where(x => x.doituong == 0);
            var doanhnghiep = _news.Table.Where(x => x.doituong == 1);
            if (!string.IsNullOrEmpty(startdate))
            {
                nguoidan = nguoidan.Where(x => x.OnCreated >= DateTime.Parse(startdate));
                doanhnghiep = doanhnghiep.Where(x => x.OnCreated >= DateTime.Parse(startdate));
            }

            if (!string.IsNullOrEmpty(enddate))
            {
                nguoidan = nguoidan.Where(x => x.OnCreated <= DateTime.Parse(enddate));
                doanhnghiep = doanhnghiep.Where(x => x.OnCreated <= DateTime.Parse(enddate));
            }

            var nguoidanGr = nguoidan.GroupBy(x => x.tinhthanhpho).Select(group => new GetReport2
            {
                khuvuc = group.Key,
                typeString = "Người dân",
                count = group.Count()
            }).ToList();

            var doanhnghiepGr = doanhnghiep.GroupBy(x => x.tinhthanhpho).Select(group => new GetReport2
            {
                khuvuc = group.Key,
                typeString = "Doanh nghiệp",
                count = group.Count()
            }).ToList();

            return doanhnghiepGr.Concat(nguoidanGr).ToList();
        }

        private string convertChudeToString(IsType type)
        {
            switch (type)
            {
                case IsType.onhiemmoitruong:
                    return "Ô nhiễm môi trường - Ô nhiễm chất thải rắn";
                case IsType.onhiemmoitruong_khithai:
                    return "Ô nhiễm môi trường -  Ô nhiễm khí thải";
                case IsType.onhiemmoitruong_nuocthai:
                    return "Ô nhiễm môi trường - Ô nhiễm nước thải";
                case IsType.giaiphapsangkien:
                    return "Giải pháp, sáng kiến bảo vệ môi trường";
                case IsType.cochehanhchinh:
                    return "Cơ chế, chính sách";
                case IsType.noType:
                    return "Chưa phân loại";
                default:
                    return String.Empty;
            }
        }

        //Quy trình mới
        public void ChuyenLenLanhDao(string id ,string note)
        {
            if (!String.IsNullOrEmpty(id))
            {
                var item = _news.GetById(Int32.Parse(id));
                if (item != null)
                {
                    item.Note = note;
                    item.IsStatus = IsStatus.baocaoldtc;
                    _news.Update(item);
                }
            }
        }



        public IList<Notifications> GetNotifications(string username)
        {
            return _notifi.Table.Where(x => x.UserName == username).ToList();
        }

        public void UpdateNote(string id , string note)
        {
            if (!String.IsNullOrEmpty(id))
            {
                var item = _news.GetById(Int32.Parse(id));
                if(item != null)
                {
                    item.Note = note;
                    _news.Update(item);
                }
            }
        }

        public void AddOrUpdateNotification(Notifications model)
        {
            if(model.Id != 0)
            {
                // la update
                var item = _notifi.GetById(model.Id);
                if (item == null) item = new Notifications();
                item.isRead = model.isRead;
                item.UserName = model.UserName;
                item.OnCreated = DateTime.Now;
                _notifi.Update(item);
            }
            else
            {

                var item = new Notifications();
                item.Notification = model.Notification;
                item.NewsId = model.NewsId;
                item.isRead = model.isRead;
                item.UserName = model.UserName;
                item.OnCreated = DateTime.Now;
                _notifi.Update(item);
                // la add
            }
        }

        public IList<ListItemNewsCategory> ReportNewsCategory()
        {
            var dataCat = _category.Table.ToList();
            var dataReturn = new List<ListItemNewsCategory>();
            foreach (var item in dataCat)
            {
                var obj = new ListItemNewsCategory();
                var countItem = _news.Table.Where(x => x.CategoryId == item.Id).Count();
                obj.category = item.Name.ToString();
                obj.count = countItem;
                dataReturn.Add(obj);
            }
            return dataReturn;
        }

        public IList<ListItemNewsMapYear> ReportNewsYear()
        {
            var dataYear = _news.Table.Select(s => new {
                year = s.OnCreated != null ? s.OnCreated.Value.Year : 0
            }).Distinct().OrderBy(i => i.year).ToList();

            var dataReturn = new List<ListItemNewsMapYear>();
            try
            {
                dataYear = dataYear.Where(x => x.year != 0).ToList();
                if (dataYear.Count > 0)
                {
                    for (var i = dataYear.First().year; i <= dataYear.Last().year; i++)
                    {
                        var obj = new ListItemNewsMapYear();
                        obj.year = i.ToString();
                        obj.count = _news.Table.Where(x => x.OnCreated.HasValue && x.OnCreated.Value.Year == i).Count();
                        dataReturn.Add(obj);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            
            return dataReturn;
        }
        
        public IQueryable<ReportNews> GetTablesRpt()
        {
            return _rptNews.Table;
        }

        public void AddOrUpdateNewReport(ReportNewsView model)
        {
            if (model.Id > 0)
            {
                var item = _rptNews.GetById(model.Id);
                if (item == null) item = new ReportNews();
                item.NewsId = model.NewsId;
                item.data = model.data;
                item.UserName = model.UserName;
                item.OnCreated = DateTime.Now;
                _rptNews.Update(item);
            }
            else
            {
                var item = new ReportNews();
                item.NewsId = model.NewsId;
                item.data = model.data;
                item.UserName = model.UserName;
                item.OnCreated = DateTime.Now;
                _rptNews.Add(item);
            }
        }

        public ReportNews GetBaocaos(int id)
        {
            var query = GetTablesRpt().Where(x => x.NewsId == id).FirstOrDefault();
            return query;
        }

        public void AddNewRelated(NewsRelatedModel model)
        {
            if (model.Id > 0)
            {
                var item = _newsRelated.GetById(model.Id);
                item = model.ModelToEntity(item);
                _newsRelated.Update(item);
            }
            else 
                _newsRelated.Add(model.ModelToEntity());
        }

        public News AddOrUpdateModel(NewsModel model)
        {
            News entity = null;
            if (model.Id > 0) entity = _news.GetById(model.Id);
            entity = model.ModelToEntity(entity);
            if (model.Id > 0)
            {

                entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.tiepnhan;
                entity.OnUpdated = DateTime.Now;
                _news.Update(entity);               
            }
            else
            {
                var itemCat = _category.GetById(model.CategoryId.Value) ?? null;
                entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.tiepnhan;
                entity.OnCreated = DateTime.Now;
                entity.CategoryId = model.CategoryId;
                var modelAdd = _news.Add(entity);

                //push notifi
                var notifi = new Notifications();
                notifi.isRead = false;
                notifi.UserName = model.UserName;
                notifi.Notification = model.Name;
                notifi.NewsId = modelAdd.Id;
                notifi.OnCreated = DateTime.Now;
                _notifi.Add(notifi);
            }
            return entity;
        }

        public void AddOrUpdateHome(HomeNewsModel model)
        {
            HomeNews entity = null;
            if (model.Id > 0) entity = _homeNews.GetById(model.Id);
            entity = model.ModelToEntityHome(entity);
            if (model.Id > 0)
            {

                entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.tiepnhan;
                entity.OnUpdated = DateTime.Now;
                _homeNews.Update(entity);
            }
            else
            {
                var itemCat = _category.GetById(model.CategoryId.Value) ?? null;
                entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.tiepnhan;
                entity.OnCreated = DateTime.Now;
                entity.CategoryId = model.CategoryId;
                var modelAdd = _homeNews.Add(entity);
            }
        }

        public void AddOrUpdateHomeNews(HomeNews model)
        {
            HomeNews entity = null;
            if (model.Id > 0) entity = _homeNews.GetById(model.Id);
            entity = model.ModelToEntityHomeNews(entity);
            if (model.Id > 0)
            {

                entity.IsStatus = (IsStatus)model.IsStatus;
                entity.OnUpdated = DateTime.Now;
                _homeNews.Update(entity);
            }
            else
            {
                var itemCat = _category.GetById(model.CategoryId.Value) ?? null;
                entity.IsStatus = (IsStatus)model.IsStatus;
                entity.OnCreated = DateTime.Now;
                entity.CategoryId = model.CategoryId;
                var modelAdd = _homeNews.Add(entity);
            }
        }

        public int AddOrUpdateNewsPreview(NewsPreview model)
        {
            NewsPreview entity = null;
            entity = model.ModelToEntityNewsPreview(entity);
            var itemCat = _category.GetById(model.CategoryId.Value) ?? null;
            entity.IsStatus = (IsStatus)model.IsStatus;
            entity.OnCreated = DateTime.Now;
            entity.CategoryId = model.CategoryId;
            var modelAdd = _newsPreview.Add(entity);
            return modelAdd.Id;
        }

        public void AddOrUpdate(NewsModel model)
        {
            News entity = null;
            if (model.Id > 0) entity = _news.GetById(model.Id);
            entity = model.ModelToEntity(entity);
            if (model.Id > 0)
            {
                //entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.tiepnhan;
                if (!(entity.CategoryId > 0))
                {
                    entity.CategoryId = 12;
                }
                entity.OnUpdated = DateTime.Now;
                _news.Update(entity);               
            }
            else
            {
                var itemCat = _category.GetById(model.CategoryId.Value) ?? null;
                entity.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.tiepnhan;
                entity.OnCreated = DateTime.Now;
                entity.OnUpdated = DateTime.Now;
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
                var modelAdd = _news.Add(entity);

                //push notifi
                var notifi = new Notifications();
                notifi.isRead = false;
                notifi.UserName = model.UserName;
                notifi.Notification = model.Name;
                notifi.NewsId = modelAdd.Id;
                notifi.OnCreated = DateTime.Now;
                _notifi.Add(notifi);
            }
        }

        public void Delete(int id)
        {
            var entity = _news.GetById(id);
            if(entity != null)
            {
                _news.Delete(entity);
            }
        }

        public void DeleteHome(int id)
        {
            var entity = _homeNews.GetById(id);
            if (entity != null)
            {
                entity.IsShow = false;
                entity.IsStatus = IsStatus.deleted;
                _homeNews.Update(entity);
            }
        }

        public void ShiftDeleteHome(int id)
        {
            var entity = _homeNews.GetById(id);
            if (entity != null)
            {
                entity.OnDeleted = DateTime.Now;
                _homeNews.Update(entity);
            }
        }

        public void Hoactac(int id)
        {
            var entity = _homeNews.GetById(id);
            if (entity != null)
            {
                entity.OnDeleted = null;
                entity.IsShow = true;
                entity.IsStatus = IsStatus.publish;
                _homeNews.Update(entity);
            }
        }

        public int DeleteAll(params string[] ids)
        {
            int count = 0;
            try
            {
                if (ids == null || ids.Count() == 0) return count;
                ids.ToList().ForEach(item =>
                {
                    if(int.TryParse(item, out int Id))
                    {
                        count += UpdateNews(Id, false, IsStatus.deleted, true);
                    }
                });
            }
            catch (Exception ex)
            {
                _appLogger.LogWarning(ex.ToString());
                return count;
            }
            return count;
        }

        public int Drafts(params string[] ids)
        {
            int count = 0;
            try
            {               
                if (ids == null || ids.Count() == 0) return count;
                ids.ToList().ForEach(item =>
                {
                    if (int.TryParse(item, out int Id))
                    {
                        count += UpdateNews(Id, false, IsStatus.draft, false);
                    }
                });
            }
            catch (Exception ex)
            {
                _appLogger.LogWarning(ex.ToString());
                return count;
            }
            return count;
        }

        public ItemsNewWithCategory GetItemNewsForTopOfCategory()
        {
            var datas = new List<News>();
            for (int i = 1; i <= 5; i++)
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

        public HomeNews GetHomeNewsById(int id)
        {
            var newDetail = _homeNews.Table.SingleOrDefault(x => x.Id == id);
            if (newDetail != null)
            {
                if (newDetail.CountView == null)
                {
                    newDetail.CountView = 1;
                } else
                {
                    newDetail.CountView++;
                }
                
                _homeNews.Update(newDetail);
            }
           

            return newDetail;
        }

        public NewsPreview getNewsPreviewById(int id)
        {
            return _newsPreview.Table.SingleOrDefault(x => x.Id == id);
        }

        public IList<HomeNews> GetHomeNewsByCate(int? id = 0 , int? number = 0,int? xemnhieu = 0)
        {
            var homeNews = _homeNews.Table.Where(x => x.IsStatus != IsStatus.deleted && !x.OnDeleted.HasValue);
         
            homeNews = homeNews.Where(z => z.IsStatus == IsStatus.publish);
            
            
            if (id != 0)
            {
                homeNews = homeNews.Where(x => x.CategoryId == id);
            }
            if (xemnhieu == 1)
            {
                homeNews = homeNews.OrderByDescending(x => x.CountView);
            }
            else
            {
                homeNews = homeNews.OrderByDescending(x => x.OnPublished);
            }
            if (number != 0)
            {
                homeNews = homeNews.Take((int)number);
            }

            var homeNewsLst = homeNews.ToList();

            foreach (var iem in homeNewsLst)
            {
                if (!string.IsNullOrEmpty(iem.Image))
                {
                    iem.Image = "http://103.9.86.36:8081" + iem.Image;
                    iem.Content = "";
                }
            }
            return homeNewsLst;
        }

        public IList<HomeNews> GetHomeNewsBySearch(string value)
        {
            var homeNews = _homeNews.Table.Where(x => x.IsStatus != IsStatus.deleted && !x.OnDeleted.HasValue);

            homeNews = homeNews.Where(z => z.IsStatus == IsStatus.publish);
            homeNews = homeNews.Where(z => z.Name.Contains(value) || z.Abstract.Contains(value) || z.Content.Contains(value));
            homeNews = homeNews.OrderByDescending(x => x.OnPublished);

            //if (id != 0)
            //{
            //    homeNews = homeNews.Where(x => x.CategoryId == id);
            //}
            //if (number != 0)
            //{
            //    homeNews = homeNews.Take((int)number);
            //}

            var homeNewsLst = homeNews.ToList();

            foreach (var iem in homeNewsLst)
            {
                if (!string.IsNullOrEmpty(iem.Image))
                {
                    iem.Image = "http://103.9.86.36:8081" + iem.Image;
                    iem.Content = "";
                }
            }
            return homeNewsLst;
        }

        public void UpdateStatus(string id, IsStatus status)
        {
            var data = _news.GetById(Int32.Parse(id));
            if(data != null)
            {
                data.IsStatus = status;
                _news.Update(data);
            }
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

        private string ConvertToUnSign(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            return str2;
        }

        private bool infoUser(IsType isType = 0, string mapakn = "")
        {
            try
            {
                if (isType == IsType.cochehanhchinh || isType == IsType.giaiphapsangkien)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }    
            return false;
        }

        public IList<LstItemNews> GetLstNewsAno(string name, string email, string sdt, int id, string mapakn = "")
        {
            var query = _news.Table.Select(x => new LstItemNews
            {
                Id = x.Id,
                Name = x.Name,
                Image = x.Image,
                Sename = x.Sename,
                Abstract = x.Abstract,
                Content = x.Content,
                OnPublished = x.OnPublished,
                UserFullName = (infoUser(x.IsType , mapakn)) ? x.UserFullName : "",
                UserEmail = (infoUser(x.IsType , mapakn)) ? x.UserEmail : "",
                UserPhone = (infoUser(x.IsType, mapakn)) ? x.UserPhone : "",
                IsStatus = x.IsStatus,
                MaPakn = x.MaPakn,
                fileUpload = x.fileUpload,
                newslog = _newLog.Table.Where(z => z.NewsId == x.Id && z.UserName == "anonymous").GroupJoin(_files.Table, a => a.Id, b => b.NewsLogId, (a, b) => new NewsLogModel
                {
                    Id = a.Id,
                    Note = a.Note,
                    Data = a.Data,
                    files = b.Where(c => c.NewsLogId == a.Id && c.isDelete == 0).ToList()
                }).FirstOrDefault()
            });

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x => ConvertToUnSign(x.UserFullName).ToLower().IndexOf(name.ToLower()) > 0 || x.UserFullName.ToLower().Contains(name.ToLower()));
            }

            if (!string.IsNullOrEmpty(sdt))
            {
                query = query.Where(x => x.UserPhone.Contains(sdt));
            }

            if (!string.IsNullOrEmpty(email))
            {
                query = query.Where(x => x.UserEmail.Contains(email));
            }

            if (!string.IsNullOrEmpty(mapakn))
            {
                query = query.Where(x => x.Name.Contains(mapakn));
            }
            else
            {
                query = query.Where(x => x.IsStatus == IsStatus.approved);
            }

            query = query.Where(x => x.newslog != null);
            if(id > 0)
            {
                query = query.Where(x => x.Id == id);
            }
            
            return query.ToList();
        }

        public IList<ListItemNewsModel> GetLstNewsPaging(out int rows, int? skip = 0, int? take = 15000, string keyword = "",
            int? categoryId = -1, int? status = -1, int? type = -1 , string username = "", string GroupId = "", int? newlogStatus = -1, string mapakn = "")
        {
            //var query = GetTables().Where(x => x.IsType == IsType.noType && x.IsType != IsType.topic);
            var query = GetTables();
            if (status == -1)
            {
                //query = query.Where(x => !x.OnDeleted.HasValue && !x.IsShow);
            }

            if (!string.IsNullOrEmpty(username))
            {
                if (GroupId == "ldtcmt" || GroupId == "ttdl")
                {
                    query = query.Where(z =>
                        _newLog.Table.Where(i => i.NewsId == z.Id).Select(x => x.GroupNameTo).Contains(GroupId)
                    );
                }
                else
                {
                    query = query.Where(z =>
                        _newLog.Table.Where(i => i.NewsId == z.Id).Select(x => x.UserName).Contains(username)
                    );
                }
                
            }

            if (query == null)
            {
                rows = 0;
                return new List<ListItemNewsModel>() { };
            }
            if (!string.IsNullOrEmpty(keyword) && keyword != "")
                query = query.Where(x => x.Name.Contains(keyword) || x.Sename.Contains(keyword));

            if (categoryId > 0) query = query.Where(x => x.CategoryId == categoryId);
            if (status >= 0) query = query.Where(x => x.IsStatus == (IsStatus)status);
            if (type > 0) query = query.Where(x => x.IsType == (IsType)type);
            query = query.Where(x => x.OnDeleted.HasValue == false);
            rows = query.Count();

            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.OrderByDescending(x => x.Id).Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.OrderByDescending(x => x.Id).Skip(skip.Value).Take(take.Value);

            query = query.OrderByDescending(x => x.OnUpdated);

            var query2 = query.GroupJoin(_newLog.Table, x => x.Id, b => b.NewsId, (x, b) => new ListItemNewsModelJoin
            {
                Id = x.Id,
                Name = x.Name ?? null,
                Image = x.Image ?? null,
                Sename = x.Sename ?? null,
                Abstract = x.Abstract ?? null,
                Content = x.Content ?? null,
                IsShow = x.IsShow,
                OnCreated = x.OnCreated,
                OnDeleted = x.OnDeleted,
                OnUpdated = x.OnUpdated,
                OnPublished = x.OnPublished,
                status = x.IsStatus,
                Note = x.Note,
                fileUpload = x.fileUpload,
                IsType = x.IsType,
                doituong = x.doituong,
                MaPakn = x.MaPakn,
                newsLog = b.Where(z => z.UserName == username).FirstOrDefault()
            });
            if (newlogStatus >= 0) query2 = query2.Where(z => z.newsLog.TypeStatus == (IsTypeStatus)newlogStatus);
            var dataRetun = query2.Select(x => new ListItemNewsModel
            {
                Id = x.Id,
                Name = x.Name ?? null,
                Image = x.Image ?? null,
                Sename = x.Sename ?? null,
                Abstract = x.Abstract ?? null,
                Content = x.Content ?? null,
                IsShow = x.IsShow,
                OnCreated = x.OnCreated,
                OnDeleted = x.OnDeleted,
                OnUpdated = x.OnUpdated,
                OnPublished = x.OnPublished,
                status = x.status,
                Note = x.Note,
                fileUpload = x.fileUpload,
                IsType = x.IsType,
                doituong = x.doituong,
                MaPakn = x.MaPakn,
                newsLog = x.newsLog
            }).ToList();
            var index = skip + 1;
            var dataNews = new List<ListItemNewsModel>();
            foreach(var itemdata in dataRetun)
            {
                itemdata.stt = (int)index;
                index++;
                if (GroupId == "ldtcmt" || GroupId == "ttdl")
                {
                    var data2 = _newLog.Table.Where(x => x.NewsId == itemdata.Id)
                        .Where(i => i.GroupNameTo == username).FirstOrDefault();
                    itemdata.Note = data2.Note;
                }
                else
                {
                    var data2 = _newLog.Table.Where(x => x.NewsId == itemdata.Id)
                        .Where(i => i.UserName == username).FirstOrDefault();
                    itemdata.Note = data2.Note;
                }
                dataNews.Add(itemdata);
            }
            return dataNews;
        }

        public IList<ListItemNewsModel> GetLstHomeNewsPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "",
            int? categoryId = -1, int? status = -1, int? type = -1, string username = "", string GroupId = "")
        {
            //var query = GetTables().Where(x => x.IsType == IsType.noType && x.IsType != IsType.topic);
            var query = _homeNews.Table;
            if (status == -1)
            {
                //query = query.Where(x => !x.OnDeleted.HasValue && !x.IsShow);
            }

            if (query == null)
            {
                rows = 0;
                return new List<ListItemNewsModel>() { };
            }
            if (!string.IsNullOrEmpty(keyword) && keyword != "")
                query = query.Where(x => x.Name.Contains(keyword) || x.Sename.Contains(keyword));

            if (categoryId > 0) query = query.Where(x => x.CategoryId == categoryId);
            if (status >= 0) query = query.Where(x => x.IsStatus == (IsStatus)status);
            if (type > 0) query = query.Where(x => x.IsType == (IsType)type);
            if(status != 4)
            {
                query = query.Where(x => x.IsStatus != IsStatus.deleted);
            }

            query = query.Where(x => !x.OnDeleted.HasValue);
            rows = query.Count();

            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.OrderByDescending(x => x.Id).Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.OrderByDescending(x => x.Id).Skip(skip.Value).Take(take.Value);

            query = query.OrderByDescending(x => x.OnPublished);

            var dataRetun = query.Select(x => new ListItemNewsModel
            {
                Id = x.Id,
                Name = x.Name ?? null,
                Image = x.Image ?? null,
                Sename = x.Sename ?? null,
                Abstract = x.Abstract ?? null,
                Content = x.Content ?? null,
                IsShow = x.IsShow,
                OnCreated = x.OnCreated,
                OnDeleted = x.OnDeleted,
                OnUpdated = x.OnUpdated,
                OnPublished = x.OnPublished,
                status = x.IsStatus,
                Note = x.Note,
                fileUpload = x.fileUpload,
                IsType = x.IsType,
                Category_Id = x.CategoryId,
                UserId = x.UserId 
            }).ToList();
            return dataRetun;
        }

        public IList<ListItemNewsMap> ReportNews()
        {
            //var query = GetTables().Where(x => x.IsType == IsType.noType && x.IsType != IsType.topic);
            var query = GetTables().Where(x => !string.IsNullOrEmpty(x.Lat) && !string.IsNullOrEmpty(x.Lng)).Take(100).ToList();
            
            return query.Select(x => new ListItemNewsMap
            {
                Name = x.Name ?? null,
                AddressString = x.AddressString,
                Lat = x.Lat,
                Lng = x.Lng
            }).ToList();
        }

        public IList<ListItemNewsModel> GetLstTopicPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? categoryId = -1, int? status = -1, int? type = -1)
        {
            var query = GetTables().Where(x => x.IsType == IsType.topic);
            if(status == -1)
            {
                query = query.Where(x => !x.OnDeleted.HasValue && !x.IsShow);
            }
            if (query == null)
            {
                rows = 0;
                return new List<ListItemNewsModel>() { };
            }
            if (!string.IsNullOrEmpty(keyword) && keyword != "")
                query = query.Where(x => x.Name.Contains(keyword) || x.Sename.Contains(keyword));

            if (categoryId > 0) query = query.Where(x => x.CategoryId == categoryId);
            if (status > 0) query = query.Where(x => x.IsStatus == (IsStatus)status);
            if (type > 0) query = query.Where(x => x.IsType == (IsType)type);
            rows = query.Count();

            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.OrderByDescending(x => x.Id).Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.OrderByDescending(x => x.Id).Skip(skip.Value).Take(take.Value);

            return query.Select(x => new ListItemNewsModel
            {
                Id = x.Id,
                Name = x.Name ?? null,
                Image = x.Image ?? null,
                Sename = x.Sename ?? null,
                Abstract = x.Abstract ?? null,
                IsShow = x.IsShow,
                OnCreated = x.OnCreated,
                OnDeleted = x.OnDeleted,
                OnUpdated = x.OnUpdated,
                OnPublished = x.OnPublished,
                status = x.IsStatus
            }).ToList();
        }

        public IQueryable<News> GetTables()
        {
            return _news.Table;
        }

        public int Process(params string[] ids)
        {
            int count = 0;
            try
            {               
                if (ids == null || ids.Count() == 0) return count;
                ids.ToList().ForEach(item =>
                {
                    if (int.TryParse(item, out int Id))
                    {
                        count += UpdateNews(Id, false, IsStatus.approved, false);
                    }
                });                
            }
            catch (Exception ex)
            {
                _appLogger.LogWarning(ex.ToString());
                return count;
            }
            return count;
        }

        public int Publishs(string[] ids , string username = "")
        {
            int count = 0;
            try
            {
                if (ids == null || ids.Count() == 0) return count;
                ids.ToList().ForEach(item =>
                {
                    if (int.TryParse(item, out int Id))
                    {
                        count += UpdateNews(Id, true, IsStatus.publish, false , username);
                        if(string.IsNullOrEmpty(username))
                        {
                            //push notifi
                            var notifi = _notifi.Table.Where(x => x.NewsId == Id).FirstOrDefault();
                            if(notifi != null)
                            {
                                var notifiAdd = new Notifications();
                                notifiAdd.isRead = false;
                                notifiAdd.UserName = "ldtcmt";
                                notifiAdd.Notification = notifi.Notification;
                                notifiAdd.NewsId = notifi.NewsId;
                                notifiAdd.OnCreated = DateTime.Now;
                                _notifi.Add(notifiAdd);
                            }
                        }
                        else
                        {
                            //push notifi
                            var notifi = _notifi.Table.Where(x => x.NewsId == Id).FirstOrDefault();
                            if (notifi != null)
                            {
                                var notifiAdd = new Notifications();
                                notifiAdd.isRead = false;
                                notifiAdd.UserName = username;
                                notifiAdd.Notification = notifi.Notification;
                                notifiAdd.NewsId = notifi.NewsId;
                                notifiAdd.OnCreated = DateTime.Now;
                                _notifi.Add(notifiAdd);
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                _appLogger.LogWarning(ex.ToString());
                return count;
            }
            return count;
        }

        public int Baocaos(string[] ids, string username = "")
        {
            int count = 0;
            try
            {
                if (ids == null || ids.Count() == 0) return count;
                ids.ToList().ForEach(item =>
                {
                    if (int.TryParse(item, out int Id))
                    {
                        count += UpdateNews(Id, true, IsStatus.baocao, false, username);
                    }
                });
            }
            catch (Exception ex)
            {
                _appLogger.LogWarning(ex.ToString());
                return count;
            }
            return count;
        }



        private int UpdateNews(int Id, bool isShow, IsStatus status, bool isDelete = false , string username = "")
        {
            int count = 0;
            var entity = _news.GetById(Id);
            if(status == IsStatus.publish)
            {
                if (string.IsNullOrEmpty(username))
                {
                    entity.UserName = entity.UserName + ",ldtcmt";
                }
                else
                {
                    entity.UserName = entity.UserName + "," + username;
                    status = IsStatus.phancong;
                    //push notifi
                    var notifi = new Notifications();
                    notifi.isRead = false;
                    notifi.UserName = username;
                    notifi.Notification = "Bạn được lãnh đạo phân công " + entity.Name;
                    notifi.NewsId = entity.Id;
                    notifi.OnCreated = DateTime.Now;
                    _notifi.Add(notifi);
                }
                
            }

            if (entity != null)
            {
                entity.IsShow = isShow;
                entity.IsStatus = status;
                if (isDelete)
                {
                    entity.OnDeleted = DateTime.Now;
                    entity.OnPublished = null;
                    entity.OnUpdated = null;
                }
                else
                {
                    entity.OnUpdated = DateTime.Now;
                    entity.OnDeleted = null;
                }
                if (status == IsStatus.publish)
                {
                    entity.OnPublished = DateTime.Now;
                    entity.OnDeleted = null;
                }
                
                _news.Update(entity);
                count += 1;
            }
            return count;
        }
    }
}

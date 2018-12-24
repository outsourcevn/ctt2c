using System.Collections.Generic;
using System.Linq;
using AppPortal.AdminSite.Services.Models;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.Core.Entities;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface INewsService
    {
        News AddOrUpdateModel(NewsModel model);
        void AddOrUpdate(NewsModel model);
        void AddOrUpdateHome(HomeNewsModel model);
        void AddOrUpdateHomeNews(HomeNews model);
        void Delete(int id);
        void DeleteHome(int id);
        void ShiftDeleteHome(int id);
        NewsModel GetNewsById(int id);
        HomeNews GetHomeNewsById(int id);
        IList<GetReport1> GetReport1(string startdate, string enddate);
        IList<GetReport1> GetReport2(string startdate, string enddate);
        IList<GetReport2> GetReport3(string startdate, string enddate);
        IList<GetReport2> GetReport4(string startdate, string enddate);
        void Hoactac(int id);
        IList<HomeNews> GetHomeNewsByCate(int? id , int? number);
        IList<ListItemNewsModel> GetLstNewsPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? categoryId = -1, int? status = -1, 
            int? type = -1 , string username = "" , string GroupId = "", int? newlogStatus = -1, string mapakn = "");
        IList<LstItemNews> GetLstNewsAno(string name, string email, string sdt, int id, string mapakn = "");
        IList<ListItemNewsModel> GetLstHomeNewsPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? categoryId = -1, int? status = -1,
            int? type = -1, string username = "", string GroupId = "");

        IList<ListItemNewsModel> GetLstTopicPaging(out int rows, int? skip = 0, int? take = 15, string keyword = "", int? categoryId = -1, int? status = -1, int? type = -1);
        void AddNewRelated(NewsRelatedModel model);
        int Publishs(string[] ids , string username = "");
        int Baocaos(string[] ids , string username = "");
        ReportNews GetBaocaos(int id);
        int Process(params string[] ids);
        int Drafts(params string[] ids);
        int DeleteAll(params string[] ids);
        // for AppPortal.Website.Services
        ItemsNewWithCategory GetItemNewsWithCategory(int? catId, int? count);
        ItemsNewWithCategory GetItemNewsForTopOfCategory();
        IList<NewsModel> GetNewsPaging(out int rows, int? take = 15, int? skip = 0, int? catId = -1);
        IQueryable<News> GetTables();
        void AddOrUpdateNewReport(ReportNewsView model);
        void UpdateNote(string id, string note);

        //Quy trinh moi
        void ChuyenLenLanhDao(string id , string note);
        void UpdateStatus(string id, IsStatus status);

        //void PhanCong(string id , string username , string note);

        //For report
        IList<ListItemNewsMap> ReportNews();
        IList<ListItemNewsCategory> ReportNewsCategory();
        IList<ListItemNewsMapYear> ReportNewsYear();

        //For notification
        IList<Notifications> GetNotifications(string username);
        void AddOrUpdateNotification(Notifications model);
    }
}

using AppPortal.AdminSite.Services.Models.News;
using AppPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface INewsLog
    {
        void AddOrUpdate(NewsLog model);
        void Delete(int id);
        NewsLog GetNewsLogByNewsIdUser(int id , string username);
        NewsLog GetNewLogPhanCong(int id);
        IList<NewsLog> GetNewsLogByNewsIdGroupNameFrom(int NewsId, string GroupNameFrom , int type); 
        IList<NewsLog> GetNewsLogByNewsIdNameFrom(int NewsId, string UserName);
        NewsLog AddOrUpdateReport(int id , string data, int? typeStatus = 0);
        IList<NewLogUpLoad> GetReport(int NewsId);
        int AddtoFileTable(FileUpload fileUpload, string id);
        string DeleteFile(int id);
        List<FileUpload> GetFile(int id, string urlWeb);
        NewsLog GetInfoNewLog(int news_id, string group);
        IList<NewsLog> GetPhanCongList(int news_id, string group);
        NewsLogFile GetInfoNewLogAndFile(int news_id, string group);
    }
}

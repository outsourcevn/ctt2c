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
        IList<NewsLog> GetNewsLogByNewsIdGroupNameFrom(int NewsId, string GroupNameFrom , int type); 
        IList<NewsLog> GetNewsLogByNewsIdNameFrom(int NewsId, string UserName);
        NewsLog AddOrUpdateReport(int id , string data);
        IList<NewsLog> GetReport(int NewsId);
        int AddtoFileTable(FileUpload fileUpload, string id);
        string DeleteFile(int id);
        List<FileUpload> GetFile(int id, string urlWeb);
    }
}

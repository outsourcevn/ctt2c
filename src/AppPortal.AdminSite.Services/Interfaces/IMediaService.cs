using AppPortal.AdminSite.Services.Models.News;
using AppPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPortal.AdminSite.Services.Interfaces
{
    public interface IMediaService
    {
        IList<Media> GetMedia(string type);
        void AddOrEdit(Media model);
        void delete(int id);
    }
}

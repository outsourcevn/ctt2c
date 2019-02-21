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
        private readonly IRepository<Media, int> _media;
        private readonly IRepository<Config, int> _config;
        private readonly IRepository<Vanban, int> _vanban;
        public MediaService(
            IRepository<Config, int> config,
            IRepository<Vanban, int> vanban,
            IRepository<Media, int> medias)
        {
            _media = medias;
            _config = config;
            _vanban = vanban;
        }
        public Config AddOrEditConfig(string type, string url)
        {
            var data = _config.Table.Where(z => z.type == type).FirstOrDefault();
            if (data != null)
            {
                data.url = url;
                _config.Update(data);
                return data;
            }
            else
            {
                var config = new Config();
                config.type = type;
                config.url = url;
                _config.Add(config);
                return config;
            }
        }

        public Config GetConfig(string type)
        {
            return _config.Table.Where(x => x.type == type).FirstOrDefault();
        }

        public IList<Media> GetMedia(string type, int is_publish)
        {
            if (is_publish == 1)
            {
                return _media.Table.Where(x => x.OnDeleted == null && (x.IsPublish == true) && x.type == type).OrderByDescending(x => x.OnCreated).ToList();
            }
            else if (is_publish == 0)
            {
                return _media.Table.Where(x => x.OnDeleted == null && (x.IsPublish == false) && x.type == type).OrderByDescending(x => x.OnCreated).ToList();
            }
            else
            {
                return _media.Table.Where(x => x.OnDeleted == null && x.type == type).OrderByDescending(x => x.OnCreated).ToList();
            }

        }

        public void delete(int id)
        {
            var media = _media.Table.Where(x => x.Id == id).FirstOrDefault();
            if (media != null)
            {
                media.OnDeleted = DateTime.Now;
                _media.Update(media);
            }
        }

        public void deleteVanban(int id)
        {
            var media = _vanban.Table.Where(x => x.Id == id).FirstOrDefault();
            if (media != null)
            {
                media.OnDeleted = DateTime.Now;
                _vanban.Update(media);
            }
        }

        public Media AddOrEdit(Media model)
        {
            if (model.Id > 0)
            {
                //la edit
                var media = _media.Table.Where(x => x.Id == model.Id).FirstOrDefault();
                if (media != null)
                {
                    media.description = model.description;
                    media.name = model.name;
                    media.IsPublish = model.IsPublish;
                    media.OnPublish = model.OnPublish;
                    _media.Update(media);
                }
                return media;
            }
            else
            {
                var media = new Media();
                media.name = model.name;
                media.description = model.description;
                media.size = model.size;
                media.type = model.type;
                media.OnCreated = DateTime.Now;
                media.OnPublish = model.OnPublish;
                media.IsPublish = model.IsPublish;
                media.url = model.url;
                media.filesImage = model.filesImage;
                _media.Add(media);
                return media;
            }

        }

        public Vanban AddOrEditVanban(Vanban model)
        {
            if (model.Id > 0)
            {
                //la edit
                var media = _vanban.Table.Where(x => x.Id == model.Id).FirstOrDefault();
                if (media != null)
                {
                    media.sovanban = model.sovanban;
                    media.tenvanban = model.tenvanban;
                    media.ngaybanhanh = model.ngaybanhanh;
                    media.loaivanban = model.loaivanban;
                    media.coquanbanhanh = model.coquanbanhanh;
                    _vanban.Update(media);
                }
                return media;
            }
            else
            {
                var media = new Vanban();
                media.sovanban = model.sovanban;
                media.tenvanban = model.tenvanban;
                media.url = model.url;
                media.ngaybanhanh = model.ngaybanhanh;
                media.loaivanban = model.loaivanban;
                media.coquanbanhanh = model.coquanbanhanh;
                media.IsPublish = model.IsPublish;
                media.OnCreated = model.OnCreated;
                _vanban.Add(media);
                return media;
            }
        }

        public IList<Vanban> GetVanban(string type,string searchValue = "", int number = 0)
        {
            if (number > 0)
            {
                return _vanban.Table.Where(x => x.OnDeleted == null).OrderByDescending(x => x.OnCreated).Take(number).ToList();
            }
            if (type == "1")
            {
                if (searchValue != null && searchValue != "")
                {
                    return _vanban.Table.Where(x => (x.OnDeleted == null && x.IsPublish == true) && (x.sovanban.Contains(searchValue) || x.tenvanban.Contains(searchValue) || x.loaivanban.Contains(searchValue) || x.coquanbanhanh.Contains(searchValue))).OrderByDescending(x => x.OnCreated).ToList();
                } else
                {
                    return _vanban.Table.Where(x => x.OnDeleted == null && x.IsPublish == true).OrderByDescending(x => x.OnCreated).ToList();
                }
                
            }
            else
            {
                if (searchValue != null && searchValue != "")
                {
                    return _vanban.Table.Where(x => (x.OnDeleted == null && x.IsPublish == false) && (x.sovanban.Contains(searchValue) || x.tenvanban.Contains(searchValue) || x.loaivanban.Contains(searchValue) || x.coquanbanhanh.Contains(searchValue))).OrderByDescending(x => x.OnCreated).ToList();
                }
                else
                {
                    return _vanban.Table.Where(x => x.OnDeleted == null && x.IsPublish == false).OrderByDescending(x => x.OnCreated).ToList();
                }
                
            }

 
        }

    }
}

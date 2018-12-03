﻿using System;
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
        public MediaService(
            IRepository<Media, int> medias)
        {
            _media = medias;
        }

        public IList<Media> GetMedia(string type , int is_publish)
        {
            if (is_publish == 1)
            {
                return _media.Table.Where(x => x.OnDeleted == null && x.OnPublish.HasValue && x.type == type).OrderByDescending(x => x.OnCreated).ToList();
            }
            else
            {
                return _media.Table.Where(x => x.OnDeleted == null && x.type == type).OrderByDescending(x => x.OnCreated).ToList();
            }
           
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

        public Media AddOrEdit(Media model)
        {
            if(model.Id > 0)
            {
                //la edit
                var media = _media.Table.Where(x => x.Id == model.Id).FirstOrDefault();
                if(media != null)
                {
                    media.description = model.description;
                    media.name = model.name;
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
                media.url = model.url;
                _media.Add(media);
                return media;
            }
            
        }

    }
}
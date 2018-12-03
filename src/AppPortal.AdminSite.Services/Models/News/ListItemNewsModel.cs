using System;
using System.Collections.Generic;
using AppPortal.Core.Entities;

namespace AppPortal.AdminSite.Services.Models.News
{
    public class ListItemNewsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Sename { get; set; }

        public string Abstract { get; set; }
        public string Content { get; set; }
        public string fileUpload { get; set; }
        public IsType IsType { get; set; }
        public bool? IsShow { get; set; }

        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublished { get; set; }

        public IsStatus status { get; set; }

        public string Note { get; set; }
        public int stt { get; set; }
    }

    public class LstItemNews
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Sename { get; set; }
        public string UserFullName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }

        public string Abstract { get; set; }
        public string Content { get; set; }
        public string fileUpload { get; set; }
        public IsType IsType { get; set; }
        public bool? IsShow { get; set; }

        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublished { get; set; }
        public IsStatus IsStatus { get; set; }
        public NewsLogModel newslog { get; set; }

    }

    public class ListItemNewsMap
    {
        public string Name { get; set; }
        public string AddressString { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
    }

    public class ListItemNewsCategory
    {
        public string category { get; set; }
        public int count { get; set; }
    }

    public class ListItemNewsMapYear
    {
        public string year { get; set; }
        public int count { get; set; }
    }
}

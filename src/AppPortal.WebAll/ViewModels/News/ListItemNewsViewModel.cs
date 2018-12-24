using System;
using AppPortal.Core.Entities;

namespace AppPortal.WebSite.ViewModels.News
{
    public class ListItemNewsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Sename { get; set; }
        public string Abstract { get; set; }
        public bool IsShow { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublished { get; set; }

        public IsStatus status { get; set; }
    }
}

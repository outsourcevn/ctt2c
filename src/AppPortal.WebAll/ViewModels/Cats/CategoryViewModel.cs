using System;
using AppPortal.Core.Entities;

namespace AppPortal.WebSite.ViewModels.Cats
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string LinkHeader { get; set; }
        public string LinkFooter { get; set; }
        public string Name { get; set; }
        public string TargetUrl { get; set; }
        public int? OrderSort { get; set; }
        public bool IsShow { get; set; }
        public bool ShowChild { get; set; }
        public ShowType ShowType { get; set; }
        public string Sename { get; set; }
        public Position Position { get; set; }
        public DateTime? OnUpdated { set; get; }
        public DateTime? OnDeleted { set; get; }
        public DateTime? OnCreated { set; get; }
        public DateTime? OnPublished { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
    }
}

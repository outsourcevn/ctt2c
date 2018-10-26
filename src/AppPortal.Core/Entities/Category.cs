using System;
using System.Collections.Generic;
using AppPortal.Core.Interfaces;

namespace AppPortal.Core.Entities
{
    public class Category : BaseEntity<int>, IDateEntity, ISeoEntity
    {
        public Category()
        {
            this.OnCreated = DateTime.Now;
        }
        public virtual int? ParentId { get; set; }
        public virtual string Name { set; get; }
        public virtual string Sename { set; get; }
        public virtual string TargetUrl { get; set; }
        public virtual int? OrderSort { get; set; }
        public virtual bool IsShow { get; set; }
        public virtual bool ShowChild { get; set; }
        public virtual string LinkHeader { get; set; }
        public virtual string LinkFooter { get; set; }
        public ShowType ShowType { get; set; }
        public Position Position { get; set; }
        public DateTime? OnUpdated { set; get; }
        public DateTime? OnDeleted { set; get; }
        public DateTime? OnCreated { set; get; }
        public DateTime? OnPublished { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public IEnumerable<News> News { get; private set; }
        public IEnumerable<NewsCategory> NewsCategories { get; set; }
    }

    public enum ShowType : int
    {
        IsNormal,
        IsModule,
        IsTopic,
        IsVideo
    }

    public enum Position : int
    {
        OnlyShowTypical
    }
}

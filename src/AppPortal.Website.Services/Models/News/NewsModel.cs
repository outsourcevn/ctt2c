using System;
using System.Collections.Generic;

namespace AppPortal.Website.Services.Models.News
{
    public class NewsModel
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? AddressId { get; set; }
        public string Name { get; set; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public bool IsShow { get; set; }
        public string Sename { set; get; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public int? CountView { get; set; }
        public int? CountLike { get; set; }
        public string SourceNews { get; set; }
        public string Note { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublished { get; set; }
        public int? IsStatus { get; set; }
        public int? IsNew { get; set; }
        public int? IsView { get; set; }
        public int? IsType { get; set; }
        public int? IsPosition { get; set; }
    }

    public class NewsCategoryModel
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? NewsId { get; set; }
    }

    public class NewsRelatedModel {
        public int Id { get; set; }
        public int NewsId1 { get; set; }
        public int NewsId2 { get; set; }
    }

    public class ItemsNewWithCategory
    {
        public ItemsNewWithCategory(int catId, string catName, List<NewsModel> lstItem)
        {
            this.CategoryId = catId;
            this.CatName = catName;
            this.lstNewItems = lstItem;
        }
        public int? CategoryId { get; set; }
        public string CatName { get; set; }
        public List<NewsModel> lstNewItems { get; set; }
    }
}

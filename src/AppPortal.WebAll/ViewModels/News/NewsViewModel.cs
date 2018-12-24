using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppPortal.WebSite.ViewModels.News
{
    public class NewsViewModel
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

    public class NewsViewModel2
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
        public string UserAddress { get; set; }
        public string UserPhone { get; set; }
        public DateTime? Thoigianxayra { get; set; }
        public string TenCaNhanToChuc { get; set; }
    }

    public class ItemsNewWithCategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CatName { get; set; }
        public List<NewsViewModel> lstNewItems { get; set; }
    }

    public class ResponseViewModel<TModel>
    {
        public int Counts { get; set; }
        public IEnumerable<TModel> datas { get; set; }
    }

    public class NewsRelatedViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int NewsId1 { get; set; }
        [Required]
        public int NewsId2 { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace AppPortal.AdminSite.ViewModels.News
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Chuyên mục")]
        [Required(ErrorMessage = "{0} không được để trống.")]
        public int CategoryId { get; set; }
        [Display(Name = "Tiêu đề")]
        [Required(ErrorMessage = "{0} không được để trống.")]
        public string Name { get; set; }
        [Display(Name = "Tóm tắt")]
        [Required(ErrorMessage = "{0} không được để trống.")]
        public string Abstract { get; set; }
        [Display(Name = "Nội dung")]
        [Required(ErrorMessage = "{0} không được để trống.")]
        public string Content { get; set; }
        [Display(Name = "Ảnh đại diện")]
        [Required(ErrorMessage = "{0} không được để trống.")]
        public string Image { get; set; }
        [Display(Name = "Link")]
        public string Link { get; set; }
        [Display(Name = "Đăng tin")]
        public bool IsShow { get; set; }
        public int? AddressId { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [Display(Name = "Đường dẫn URL")]
        public string Sename { set; get; }
        [Display(Name = "SEO title")]
        public string MetaTitle { get; set; }
        [Display(Name = "SEO Keyworld")]
        public string MetaKeywords { get; set; }
        [Display(Name = "SEO Description")]
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
        [Display(Name = "Trạng thái")]
        public int? IsStatus { get; set; }
        public int? IsNew { get; set; }
        public int? IsView { get; set; }
        public int? IsType { get; set; }
        public int? IsPosition { get; set; }
    }
    public class NewsCategoryViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int? CategoryId { get; set; }
        [Required]
        public int? NewsId { get; set; }
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

    public class NewsLogViewPost
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Data { get; set; }
    }
}

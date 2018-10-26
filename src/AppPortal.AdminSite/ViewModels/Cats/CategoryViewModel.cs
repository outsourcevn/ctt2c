using System;
using System.ComponentModel.DataAnnotations;
using AppPortal.Core.Entities;

namespace AppPortal.AdminSite.ViewModels.Cats
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Danh mục cha")]
        public int? ParentId { get; set; }
        public string LinkHeader { get; set; }
        public string LinkFooter { get; set; }
        [Required(ErrorMessage = "{0} không được để trống.")]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }
        [Display(Name = "TargetUrl")]
        public string TargetUrl { get; set; } = "_self";
        [Display(Name = "Sắp xếp")]
        public int? OrderSort { get; set; } = 0;
        [Display(Name = "Hiện thị")]
        public bool IsShow { get; set; } = true;
        public bool ShowChild { get; set; }
        [Display(Name = "Kiểu hiện thị")]
        public ShowType ShowType { get; set; }
        [Display(Name = "Đường dẫn")]
        public string Sename { get; set; }
        [Display(Name = "Position")]
        public Position Position { get; set; }
        public DateTime? OnUpdated { set; get; }
        public DateTime? OnDeleted { set; get; }
        public DateTime? OnCreated { set; get; }
        public DateTime? OnPublished { get; set; }
        [Display(Name = "Meta Title")]
        public string MetaTitle { get; set; }
        [Display(Name = "Meta Keywords")]
        public string MetaKeywords { get; set; }
        [Display(Name = "Meta Description")]
        public string MetaDescription { get; set; }
    }
}

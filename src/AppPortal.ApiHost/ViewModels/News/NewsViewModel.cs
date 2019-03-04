using AppPortal.AdminSite.Services.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace AppPortal.ApiHost.ViewModels.News
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
        [StringLength(2000, ErrorMessage = "Nội dung không vượt quá 2000 kí tự, vui lòng kiểm tra lại.")]
        public string Abstract { get; set; }
        [Display(Name = "Nội dung")]
        //[Required(ErrorMessage = "{0} không được để trống.")]
        public string Content { get; set; }
        [Display(Name = "Ảnh đại diện")]
        //[Required(ErrorMessage = "{0} không được để trống.")]
        public string Image { get; set; }
        [Display(Name = "Địa điểm diễn ra")]
        public string Link { get; set; }
        [Display(Name = "Đăng tin")]
        public bool IsShow { get; set; }
        public int? AddressId { get; set; }
        //[Required(ErrorMessage = "{0} không được để trống.")]
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
        public string AddressString { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string UserAddress { get; set; }
        public string UserPhone { get; set; }
        public string tinhthanhpho { get; set; }
        public string quanhuyen { get; set; }
        public string phuongxa { get; set; }
        public string fileUpload { get; set; }
        public int doituong { get; set; }
        public DateTime? Thoigianxayra { get; set; }
        public string TenCaNhanToChuc { get; set; }
        public string MaPakn { get; set; }
        public DateTime ngayxuly { get; set; }
        public string thamquyenxuly { get; set; }
        public string Noidungbosung { get; set; }
    }

    public class NewsViewModel3
    {
        [Required(ErrorMessage = "{0} không được để trống.")]
        public int Id { get; set; }

        [StringLength(2000, ErrorMessage = "Nội dung không vượt quá 2000 kí tự, vui lòng kiểm tra lại.")]
        public string Noidungbosung { get; set; }

        public string fileUpload { get; set; }

    }

    public class HomeNewsViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Chuyên mục")]
        [Required(ErrorMessage = "{0} không được để trống.")]
        public int CategoryId { get; set; }
        [Display(Name = "Tiêu đề")]
        [Required(ErrorMessage = "{0} không được để trống.")]
        public string Name { get; set; }
        [Display(Name = "Tóm tắt")]
        [StringLength(2000, ErrorMessage = "Nội dung không vượt quá 2000 kí tự, vui lòng kiểm tra lại.")]
        public string Abstract { get; set; }
        [Display(Name = "Nội dung")]
        //[Required(ErrorMessage = "{0} không được để trống.")]
        public string Content { get; set; }
        [Display(Name = "Ảnh đại diện")]
        //[Required(ErrorMessage = "{0} không được để trống.")]
        public string Image { get; set; }
        [Display(Name = "Địa điểm diễn ra")]
        public string Link { get; set; }
        [Display(Name = "Đăng tin")]
        public bool IsShow { get; set; }
        public int? AddressId { get; set; }
        //[Required(ErrorMessage = "{0} không được để trống.")]
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
        public string AddressString { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string UserAddress { get; set; }
        public string UserPhone { get; set; }
        public string tinhthanhpho { get; set; }
        public string quanhuyen { get; set; }
        public string phuongxa { get; set; }
        public string fileUpload { get; set; }
        public int doituong { get; set; }

        [Display(Name = "Số văn bản")]
        public string sovanban { get; set; }
        [Display(Name = "Tên văn bản")]
        public string tenvanban { get; set; }
        [Display(Name = "Ngày ban hành")]
        public DateTime? ngaybanhanh { get; set; }
        [Display(Name = "Loại văn bản")]
        public string loaivanban { get; set; }
        [Display(Name = "Cơ quan ban hành")]
        public string cqbanhanh { get; set; }
        [Display(Name = "Ngày hiệu lực")]
        public string ngayhieuluc { get; set; }
        [Display(Name = "Tình trạng hiệu lực")]
        public string tinhtranghieuluc { get; set; }
        [Display(Name = "Người ký")]
        public string nguoiky { get; set; }
        [Display(Name = "Chức danh")]
        public string chucdanh { get; set; }
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

    public class NewVew2 {
        [Required]
        public string ids { get; set; }
        [Required]
        public string username { get; set; }

        public string note { get; set; }

        public int type { get; set; }
    }

    public class NewVewTuchoi
    {
        [Required]
        public int news_id { get; set; }
        [Required]
        public string note { get; set; }
    }

    public class NewVew3
    {
        [Required]
        public string ids { get; set; }
        [Required]
        public string note { get; set; }
    }

    public class NewViewReport
    {
        public string[] ids { get; set; }
        public string username { get; set; }
        public int Id { get; set; }
        [Required]
        public int? NewsId { get; set; }
        public string data { get; set; }
        public string UserName { get; set; }
    }

    public class NewViewReport2
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Data { get; set; }
        public int typeStatus { get; set; }
    }

}

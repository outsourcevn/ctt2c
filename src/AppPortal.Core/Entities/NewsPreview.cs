using System;
using System.Collections.Generic;
using AppPortal.Core.Interfaces;

namespace AppPortal.Core.Entities
{
    public class NewsPreview : BaseEntity<int>, ISeoEntity, IDateEntity
    {
        public NewsPreview()
        {
            OnCreated = DateTime.Now;
            IsShow = false;
        }
        public string Name { get; set; }
        public string Sename { set; get; }
        public string Abstract { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public bool IsShow { get; set; }

        public IsStatus IsStatus { get; set; }
        public IsNew IsNew { get; set; }
        public IsView IsView { get; set; }
        public IsType IsType { get; set; }
        public IsPosition IsPosition { get; set; }

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }

        public int? CountView { get; set; }
        public int? CountLike { get; set; }
        public string SourceNews { get; set; }
        public string Note { get; set; }

        public int? CategoryId { get; set; }

        public int? AddressId { get; set; }

        public string AddressString { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string tinhthanhpho { get; set; }
        public string quanhuyen { get; set; }
        public string phuongxa { get; set; }
        public string fileUpload { get; set; }

        //van ban phap quy
        public string sovanban { get; set; }
        public string tenvanban { get; set; }
        public DateTime? ngaybanhanh { get; set; }
        public string loaivanban { get; set; }
        public string cqbanhanh { get; set; }
        public string ngayhieuluc { get; set; }
        public string tinhtranghieuluc { get; set; }
        public string nguoiky { get; set; }
        public string chucdanh { get; set; }

        //ISeoEntity implement
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublished { get; set; }
    }
}
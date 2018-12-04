using System;
using System.Collections.Generic;
using AppPortal.Core.Interfaces;

namespace AppPortal.Core.Entities
{
    public class News : BaseEntity<int>, ISeoEntity, IDateEntity
    {
        public News()
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
        public Category Category { get; set; }
        public virtual List<NewsCategory> NewsCategories { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public string AddressString { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string tinhthanhpho { get; set; }
        public string quanhuyen { get; set; }
        public string phuongxa { get; set; }
        public string fileUpload { get; set; }
        public int doituong { get; set; }

        //ISeoEntity implement
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public DateTime? OnCreated { get; set; }
        public DateTime? OnUpdated { get; set; }
        public DateTime? OnDeleted { get; set; }
        public DateTime? OnPublished { get; set; }
    }

    public enum IsStatus : int
    {
        pending,
        publish,
        draft,
        approved,
        deleted,
        phancong,
        baocao,
        tiepnhan,
        xacminh,
        tuchoi,
        baocaoldtc
    }

    public enum IsNew : int
    {
        isComment,
        isVideo,
        isAudio,
        isImage
    }

    public enum IsView : int
    {
        normal,
        image,
        video,
        info,
        other
    }

    public enum IsType : int
    {
        noType,
        production,
        translation,
        general,
        editors,
        topic,
        onhiemmoitruong,
        cochehanhchinh,
        giaiphapsangkien
    }

    public enum IsPosition : int
    {
        isNormal,
        isFocal,
        isMain,
        isHot
    }
}

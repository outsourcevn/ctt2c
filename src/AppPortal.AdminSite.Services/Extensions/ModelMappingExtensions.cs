using System.Collections.Generic;
using AppPortal.AdminSite.Services.Models.Addresses;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.Core;
using AppPortal.Core.Entities;

namespace AppPortal.AdminSite.Services.Extensions
{
    public static class ModelMappingExtensions
    {
        public static Category ModelToEntity(this CategoryModel model, Category item = null)
        {
            if (item == null) item = new Category();

            item.ParentId = model.ParentId;
            item.Name = model.Name ?? null;
            item.OrderSort = model.OrderSort;
            item.IsShow = model.IsShow;
            item.ShowType = model.ShowType;
            item.ShowChild = model.ShowChild;
            item.TargetUrl = model.TargetUrl;
            item.LinkHeader = model.LinkHeader;
            item.LinkFooter = model.LinkFooter;
            item.Sename = string.IsNullOrEmpty(item.Sename) ? $"/{CommonHelper.UltilityHelper.FillterChar(item.Name)}" : model.Sename;
            item.MetaTitle = string.IsNullOrEmpty(model.MetaTitle) ? model.Name : model.MetaTitle;
            item.MetaKeywords = string.IsNullOrEmpty(model.MetaKeywords) ? model.Name : model.MetaKeywords;
            item.MetaDescription = string.IsNullOrEmpty(model.MetaDescription) ? model.Name : model.MetaDescription;
            item.Position = model.Position;
            item.OnCreated = model.OnCreated ?? null;
            item.OnDeleted = model.OnDeleted ?? null;
            item.OnPublished = model.OnPublished ?? null;
            item.OnUpdated = model.OnUpdated ?? null;
            return item;
        }

        public static CategoryModel EntityToModel(this Category item)
        {
            if (item == null) return null;
            return new CategoryModel
            {
                Id = item.Id,
                Name = item.Name,
                ParentId = item.ParentId,
                IsShow = item.IsShow,
                ShowChild = item.ShowChild,
                ShowType = item.ShowType,
                OrderSort = item.OrderSort,
                TargetUrl = item.TargetUrl,
                LinkHeader = item.LinkHeader,
                LinkFooter = item.LinkFooter,
                Sename = item.Sename,
                MetaTitle = item.MetaTitle,
                MetaKeywords = item.MetaKeywords,
                MetaDescription = item.MetaDescription,
                Position = item.Position,
                OnCreated = item.OnCreated ?? null,
                OnDeleted = item.OnDeleted ?? null,
                OnPublished = item.OnPublished ?? null,
                OnUpdated = item.OnUpdated ?? null
            };
        }

        public static News ModelToEntity(this NewsModel model, News item = null)
        {
            if (item == null) item = new News();

            item.CategoryId = model.CategoryId ?? null;
            item.Name = model.Name ?? null;
            item.Content = model.Content ?? null;
            item.Image = model.Image ?? null;
            item.IsShow = model.IsShow;
            item.Link = model.Link ?? null;
            item.Abstract = model.Abstract ?? null;
            item.Sename = string.IsNullOrEmpty(item.Sename) ? $"/{ CommonHelper.UltilityHelper.FillterChar(item.Name)}" : model.Sename;
            item.MetaTitle = string.IsNullOrEmpty(model.MetaTitle) ? model.Name : model.MetaTitle;
            item.MetaKeywords = string.IsNullOrEmpty(model.MetaKeywords) ? model.Name : model.MetaKeywords;
            item.MetaDescription = string.IsNullOrEmpty(model.MetaDescription) ? model.Name : model.MetaDescription;
            item.AddressId = model.AddressId ?? null;
            item.UserName = model.UserName ?? null;
            item.UserId = model.UserId ?? null;
            item.UserFullName = model.UserFullName ?? null;
            item.UserEmail = model.UserEmail ?? null;
            item.CountLike = model.CountLike ?? null;
            item.CountView = model.CountView ?? null;
            item.AddressString = model.AddressString ?? null;
            item.UserAddress = model.UserAddress ?? null;
            item.UserPhone = model.UserPhone ?? null;
            item.Lat = model.Lat ?? null;
            item.Lng = model.Lng ?? null;
            item.SourceNews = model.SourceNews ?? null;
            item.Note = model.Note ?? null;
            item.OnCreated = model.OnCreated ?? null;
            item.OnDeleted = model.OnDeleted ?? null;
            item.OnPublished = model.OnPublished ?? null;
            item.OnUpdated = model.OnUpdated ?? null;
            item.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.pending;
            item.IsNew = model.IsNew != null ? (IsNew)model.IsNew : IsNew.isComment;
            item.IsPosition = model.IsPosition != null ? (IsPosition)model.IsPosition : IsPosition.isNormal;
            item.IsType = model.IsType != null ? (IsType)model.IsType : IsType.noType;
            item.IsView = model.IsView != null ? (IsView)model.IsView : IsView.normal;
            item.tinhthanhpho = model.tinhthanhpho;
            item.phuongxa = model.phuongxa;
            item.quanhuyen = model.quanhuyen;
            item.fileUpload = model.fileUpload;
            return item;
        }

        public static HomeNews ModelToEntityHome(this NewsModel model, HomeNews item = null)
        {
            if (item == null) item = new HomeNews();

            item.CategoryId = model.CategoryId ?? null;
            item.Name = model.Name ?? null;
            item.Content = model.Content ?? null;
            item.Image = model.Image ?? null;
            item.IsShow = model.IsShow;
            item.Link = model.Link ?? null;
            item.Abstract = model.Abstract ?? null;
            item.Sename = string.IsNullOrEmpty(item.Sename) ? $"/{ CommonHelper.UltilityHelper.FillterChar(item.Name)}" : model.Sename;
            item.MetaTitle = string.IsNullOrEmpty(model.MetaTitle) ? model.Name : model.MetaTitle;
            item.MetaKeywords = string.IsNullOrEmpty(model.MetaKeywords) ? model.Name : model.MetaKeywords;
            item.MetaDescription = string.IsNullOrEmpty(model.MetaDescription) ? model.Name : model.MetaDescription;
            item.AddressId = model.AddressId ?? null;
            item.UserName = model.UserName ?? null;
            item.UserId = model.UserId ?? null;
            item.UserFullName = model.UserFullName ?? null;
            item.UserEmail = model.UserEmail ?? null;
            item.CountLike = model.CountLike ?? null;
            item.CountView = model.CountView ?? null;
            item.AddressString = model.AddressString ?? null;
            item.UserAddress = model.UserAddress ?? null;
            item.UserPhone = model.UserPhone ?? null;
            item.Lat = model.Lat ?? null;
            item.Lng = model.Lng ?? null;
            item.SourceNews = model.SourceNews ?? null;
            item.Note = model.Note ?? null;
            item.OnCreated = model.OnCreated ?? null;
            item.OnDeleted = model.OnDeleted ?? null;
            item.OnPublished = model.OnPublished ?? null;
            item.OnUpdated = model.OnUpdated ?? null;
            item.IsStatus = model.IsStatus != null ? (IsStatus)model.IsStatus : IsStatus.pending;
            item.IsNew = model.IsNew != null ? (IsNew)model.IsNew : IsNew.isComment;
            item.IsPosition = model.IsPosition != null ? (IsPosition)model.IsPosition : IsPosition.isNormal;
            item.IsType = model.IsType != null ? (IsType)model.IsType : IsType.noType;
            item.IsView = model.IsView != null ? (IsView)model.IsView : IsView.normal;
            item.tinhthanhpho = model.tinhthanhpho;
            item.phuongxa = model.phuongxa;
            item.quanhuyen = model.quanhuyen;
            item.fileUpload = model.fileUpload;
            return item;
        }

        public static NewsModel EntityToModel(this News item)
        {
            if (item == null) return null;
            var decodeAbstract = System.Net.WebUtility.HtmlDecode(item.Abstract ?? "");
            var decodeContent = System.Net.WebUtility.HtmlDecode(item.Content ?? "");
            return new NewsModel
            {
                Id = item.Id,
                CategoryId = item.CategoryId ?? null,
                Name = item.Name ?? null,
                IsShow = item.IsShow,
                Abstract = decodeAbstract,
                Content = decodeContent,
                Link = item.Link ?? null,
                Image = item.Image ?? null,
                Sename = item.Sename ?? null,
                MetaTitle = item.MetaTitle ?? null,
                MetaKeywords = item.MetaKeywords ?? null,
                MetaDescription = item.MetaDescription ?? null,
                AddressId = item.AddressId ?? null,
                UserName = item.UserName ?? null,
                UserId = item.UserId ?? null,
                UserFullName = item.UserFullName ?? null,
                UserEmail = item.UserEmail ?? null,
                CountLike = item.CountLike ?? null,
                CountView = item.CountView ?? null,
                SourceNews = item.SourceNews ?? null,
                Note = item.Note ?? null,
                OnCreated = item.OnCreated ?? null,
                OnDeleted = item.OnDeleted ?? null,
                OnPublished = item.OnPublished ?? null,
                OnUpdated = item.OnUpdated ?? null,
                IsStatus = (int)item.IsStatus,
                IsNew = (int)item.IsNew,
                IsPosition = (int)item.IsPosition,
                IsType = (int)item.IsType,
                IsView = (int)item.IsView
            };
        }

        public static List<NewsModel> MapLstEntityToListModel(this List<News> lstItem)
        {
            List<NewsModel> datas = new List<NewsModel>();
            lstItem.ForEach(item =>
            {
                datas.Add(item.EntityToModel());
            });
            return datas;
        }

        public static NewsCategory ModelToEntity(this NewsCategoryModel model, NewsCategory item = null)
        {
            if (item == null) item = new NewsCategory();
            item.Id = model.Id;
            item.NewsId = model.NewsId ?? null;
            item.CategoryId = model.CategoryId ?? null;
            return item;
        }

        public static NewsCategoryModel EntityToModel(this NewsCategory item)
        {
            return new NewsCategoryModel
            {
                Id = item.Id,
                CategoryId = item.CategoryId ?? null,
                NewsId = item.NewsId ?? null
            };
        }
        public static NewsRelated ModelToEntity(this NewsRelatedModel model, NewsRelated item = null)
        {
            if (item == null) item = new NewsRelated();
            item.Id = model.Id;
            item.NewsId1 = model.NewsId1;
            item.NewsId2 = model.NewsId2;
            return item;
        }

        public static NewsRelatedModel EntityToModel(this NewsRelated item)
        {
            return new NewsRelatedModel
            {
                Id = item.Id,
                NewsId1 = item.NewsId1,
                NewsId2 = item.NewsId2
            };
        }
        public static Address ModelToEntity(this AddressModel model, Address item = null)
        {
            if (item == null) item = new Address();
            item.Id = model.Id;
            item.LatLong = model.LatLong ?? null;
            item.Name = model.Name ?? null;
            item.ProvinceId = model.ProvinceId ?? null;
            item.ProvinceType = model.ProvinceType ?? null;
            return item;
        }

        public static AddressModel EntityToModel(this Address item)
        {
            return new AddressModel
            {
                Id = item.Id,
                LatLong = item.LatLong ?? null,
                Name = item.Name ?? null,
                ProvinceId = item.ProvinceId ?? null,
                ProvinceType = item.ProvinceType ?? null
            };
        }
    }
}

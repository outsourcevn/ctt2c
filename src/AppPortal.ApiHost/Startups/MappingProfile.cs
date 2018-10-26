using AppPortal.AdminSite.Services.Models.Addresses;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.ApiHost.ViewModels.Addresses;
using AppPortal.ApiHost.ViewModels.Cats;
using AppPortal.ApiHost.ViewModels.News;
using AutoMapper;

namespace AppPortal.ApiHost
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewsModel, NewsViewModel>()
                .ForAllMembers(item =>
                    item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));

            CreateMap<NewsViewModel, NewsModel>()
               .ForAllMembers(item =>
                    item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));

            CreateMap<TreeCategoryModel, TreeCategoryViewModel>()
              .ForAllMembers(item =>
                    item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));

            CreateMap<CategoryModel, CategoryViewModel>()
              .ForAllMembers(item =>
                    item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));

            CreateMap<CategoryViewModel, CategoryModel>()
                .ForAllMembers(item =>
                    item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));

            CreateMap<ListItemNewsModel, ListItemNewsViewModel>()
             .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
             .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
             .ForMember(vm => vm.Image, map => map.MapFrom(m => m.Image))
             .ForMember(vm => vm.Abstract, map => map.MapFrom(m => m.Abstract))
             .ForMember(vm => vm.IsShow, map => map.MapFrom(m => m.IsShow))
             .ForMember(vm => vm.OnCreated, map => map.MapFrom(m => m.OnCreated))
             .ForMember(vm => vm.OnUpdated, map => map.MapFrom(m => m.OnUpdated))
             .ForMember(vm => vm.OnDeleted, map => map.MapFrom(m => m.OnDeleted))
             .ForMember(vm => vm.status, map => map.MapFrom(m => m.status));

            CreateMap<ListItemCategoryModel, ListItemCategoryViewModel>()
             .ForAllMembers(item =>
                   item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                   {
                       return true;
                   }));

            CreateMap<NewsRelatedViewModel, NewsRelatedModel>()
               .ForAllMembers(item =>
                   item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                   {
                       return true;
                   }));

            CreateMap<AddressModel, AddressViewModel>()
                .ForAllMembers(item =>
                    item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));

            CreateMap<AddressViewModel, AddressModel>()
            .ForAllMembers(item =>
                item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                {
                    return true;
                }));
        }
    }
}

using AppPortal.AdminSite.Services.Models;
using AppPortal.AdminSite.Services.Models.Cats;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.AdminSite.ViewModels;
using AppPortal.AdminSite.ViewModels.Cats;
using AppPortal.AdminSite.ViewModels.News;
using AutoMapper;

namespace AppPortal.AdminSite
{
    public class MappingControllerModelProfile : Profile
    {
        public MappingControllerModelProfile()
        {
            // Map From model => vm
            CreateMap<MvcActionInfo, MvcActionInfoViewModel>()
                .ForAllMembers(vm =>
                    vm.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));
            CreateMap<MvcControllerInfo, MvcControllerInfoViewModel>()
               .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
               .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
               .ForMember(vm => vm.DisplayName, map => map.MapFrom(m => m.DisplayName))
               .ForMember(vm => vm.AreaName, map => map.MapFrom(m => m.AreaName))
               .ForMember(vm => vm.Actions, map => map.MapFrom(m => m.Actions));

            // Map from vm => model
            CreateMap<MvcActionInfoViewModel, MvcActionInfo>()
                .ForAllMembers(vm =>
                    vm.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));
            CreateMap<MvcControllerInfoViewModel, MvcControllerInfo>()
               .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id))
               .ForMember(m => m.Name, map => map.MapFrom(vm => vm.Name))
               .ForMember(m => m.DisplayName, map => map.MapFrom(vm => vm.DisplayName))
               .ForMember(m => m.AreaName, map => map.MapFrom(vm => vm.AreaName))
               .ForMember(m => m.Actions, map => map.MapFrom(vm => vm.Actions));
        }
    }

    public class MappingModelProfile : Profile
    {
        public MappingModelProfile()
        {
            CreateMap<NewsModel, NewsViewModel>()
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
        }
    }
}

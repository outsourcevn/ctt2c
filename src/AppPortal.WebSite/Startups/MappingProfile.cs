using AppPortal.Website.Services.Models.Cats;
using AppPortal.Website.Services.Models.News;
using AppPortal.WebSite.ViewModels.Cats;
using AppPortal.WebSite.ViewModels.News;
using AutoMapper;

namespace AppPortal.WebSite.Startups
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

            CreateMap<TreeCategoryModel, TreeCategoryViewModel>()
               .ForAllMembers(item =>
                    item.Condition((source, destination, arg3, arg4, resolutionContext) =>
                    {
                        return true;
                    }));
            CreateMap<ItemsNewWithCategory, ItemsNewWithCategoryViewModel>()
                .ForMember(vm => vm.CategoryId, map => map.MapFrom(m => m.CategoryId))
                .ForMember(vm => vm.CatName, map => map.MapFrom(m => m.CatName))
                .ForMember(vm => vm.lstNewItems, map => map.MapFrom(m => m.lstNewItems));
        }
    }
}

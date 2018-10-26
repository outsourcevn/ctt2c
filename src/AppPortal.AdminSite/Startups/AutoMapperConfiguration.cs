using AutoMapper;

namespace AppPortal.AdminSite
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingControllerModelProfile>();
                x.AddProfile<MappingModelProfile>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}

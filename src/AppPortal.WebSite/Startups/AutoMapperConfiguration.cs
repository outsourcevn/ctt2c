using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace AppPortal.WebSite.Startups
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingProfile>();
            });

            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}

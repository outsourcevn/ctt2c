using AppPortal.Core.Interfaces;
using AppPortal.Core.Providers;
using AppPortal.Infrastructure.App;
using AppPortal.Infrastructure.Identity;
using AppPortal.Infrastructure.Logging;
using AppPortal.Website.Services.Interfaces;
using AppPortal.Website.Services.Websites;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Pioneer.Pagination;

namespace AppPortal.WebSite.Startups
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CatalogConnection"), b => b.UseRowNumberForPaging()));
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<AppIdentityDbContext>().AddDefaultTokenProviders();
            services.AddOptions();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
                });
            // Add memory cache services
            services.AddMemoryCache();
            //Configure Automapper
            AutoMapperConfiguration.Configure();
            // Add REPOSITORY
            services.AddScoped(typeof(IRepository<,>), typeof(EfRepository<,>));
            services.AddScoped(typeof(IAsyncRepository<,>), typeof(EfRepository<,>));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            // Add Configuration as Singleton
            services.AddSingleton(Configuration);
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IAddressService, AddressService>();
            // Provider
            services.AddSingleton<IDatetimeProvider, DatetimeProvider>();
            // Paging
            services.AddTransient<IPaginatedMetaService, PaginatedMetaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

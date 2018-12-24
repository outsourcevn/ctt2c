using System;
using System.Threading.Tasks;
using AppPortal.AdminSite;
using AppPortal.AdminSite.Authorization;
using AppPortal.AdminSite.Services.Administrator;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.Core.Interfaces;
using AppPortal.Core.Providers;
using AppPortal.Infrastructure.App;
using AppPortal.Infrastructure.Identity;
using AppPortal.Infrastructure.Logging;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using Pioneer.Pagination;

namespace AppPortal.WebAll
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
            services.AddDbContext<AppDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CatalogConnection"), b => { b.UseRowNumberForPaging(); b.MigrationsAssembly("AppPortal.Infrastructure"); }));
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection"), b => { b.UseRowNumberForPaging(); b.MigrationsAssembly("AppPortal.Infrastructure"); }));
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 2;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.User.RequireUniqueEmail = false;
            })
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.LoginPath = "/admin/Account/Login";
                options.LogoutPath = "/admin/Account/Logout";
                options.Cookie.Name = ".apt.cookie.cms.admin";
                options.Events = new Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationEvents()
                {
                    OnRedirectToLogin = context =>
                    {
                        if (context.Request.Path.Value.StartsWith("/api") && context.Response.StatusCode == StatusCodes.Status200OK)
                        {
                            context.Response.Clear();
                            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                            return Task.FromResult<object>(null);
                        }
                        context.Response.Redirect(context.RedirectUri);
                        return Task.FromResult<object>(null);
                    }
                };
            });
            // jwt server
            services.AddAuthorization(options => {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser().Build();
            });
            services.AddSession();
            //Configure Automapper
            AutoMapperConfiguration.Configure();
            // Configure mvc
            services
                .AddMvc(options => {
                    options.Filters.Add(typeof(DynamicAuthorizationFilter));
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    opt.SerializerSettings.SerializationBinder = new DefaultSerializationBinder();
                    opt.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                });

            // Add memory cache services
            services.AddMemoryCache();

            // efresponse
            services.AddScoped(typeof(IRepository<,>), typeof(EfRepository<,>));
            services.AddScoped(typeof(IAsyncRepository<,>), typeof(EfRepository<,>));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            // Add Configuration as Singleton
            // for admin site
            services.AddSingleton(Configuration);
            services.AddScoped<AppPortal.AdminSite.Services.Interfaces.ICategoryService, AppPortal.AdminSite.Services.Administrator.CategoryService>();
            services.AddScoped<AppPortal.AdminSite.Services.Interfaces.INewsService, AppPortal.AdminSite.Services.Administrator.NewsService>();
            services.AddScoped<AppPortal.AdminSite.Services.Interfaces.IMediaService, AppPortal.AdminSite.Services.Administrator.MediaService>();
            // for website
            services.AddScoped<AppPortal.Website.Services.Interfaces.ICategoryService, AppPortal.Website.Services.Websites.CategoryService>();
            services.AddScoped<AppPortal.Website.Services.Interfaces.INewsService, AppPortal.Website.Services.Websites.NewsService>();
            services.AddScoped<AppPortal.Website.Services.Interfaces.IAddressService, AppPortal.Website.Services.Websites.AddressService>();
            // Paging
            services.AddTransient<IPaginatedMetaService, PaginatedMetaService>();
            // provider other:
            services.AddSingleton<IDatetimeProvider, DatetimeProvider>();
            // register server dynamic Role based
            services.AddSingleton<IMvcControllerDiscovery, MvcControllerDiscovery>();
            services.AddSingleton<IClaimsTransformation, ClaimsTransformer>();
            services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, AppClaimsPrincipalFactory>();
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

            app.UseStatusCodePagesWithReExecute("/Error/{0}");

            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                     name: "administration",
                     template: "{area:exists}/admin/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

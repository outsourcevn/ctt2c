using System;
using System.IO;
using System.Linq;
using AppPortal.Host.Cdn.Extensions;
using AppPortal.Host.Cdn.Interfaces;
using AppPortal.Host.Cdn.Logging;
using Backload.MiddleWare;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Serialization;

namespace AppPortal.Host.Cdn
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
            services.AddDirectoryBrowser();

            // Setting up CORS
            var origins = Configuration.GetSection("AppSettings:CorsOrigins").Value
                            .Split(",", StringSplitOptions.RemoveEmptyEntries)
                                .Select(o => o.RemoveSuffix("/"))
                                .ToArray();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                        builder => builder.WithOrigins(origins)
                        .AllowAnyOrigin()
                        .AllowCredentials()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // ADD REPOSITORY
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            // Add Configuration as Singleton
            services.AddSingleton(Configuration);
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    opt.SerializerSettings.SerializationBinder = new DefaultSerializationBinder();
                    opt.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            // Shows UseCors with named policy.
            app.UseCors("AllowSpecificOrigin");

            // Serve my app-specific default file, if present.
            DefaultFilesOptions options = new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("index.html");
            app.UseDefaultFiles(options);

            // Default static file
            app.UseStaticFiles();

            app.UseBackload();

            app.UseFileServer(new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
            });

            // Serve files outside
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles", "UserFiles")),
                RequestPath = "/shared"
            });

            // Enable directory browsing
            app.UseFileServer(new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles", "UserFiles")),
                RequestPath = "/shared"
            });

            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=ImageBrowser}/{action=Index}/{id?}");
            });
        }
    }
}

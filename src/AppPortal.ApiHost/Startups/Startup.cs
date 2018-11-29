using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services;
using AppPortal.AdminSite.Services.Administrator;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.ApiHost.Authorization;
using AppPortal.ApiHost.Startups;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AppPortal.Core.Providers;
using AppPortal.Infrastructure.App;
using AppPortal.Infrastructure.Identity;
using AppPortal.Infrastructure.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;

namespace AppPortal.ApiHost
{
    public class Startup
    {
        private const string EmailConfirmationTokenProviderName = "ConfirmEmail";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {          
            services.AddDbContext<AppDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("CatalogConnection"), b => b.UseRowNumberForPaging()));
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection"), b => b.UseRowNumberForPaging()));
            
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
                .AddDefaultTokenProviders()
                .AddPasswordValidator<UsernameAsPasswordValidator<ApplicationUser>>()
                .AddTokenProvider<ConfirmEmailDataProtectorTokenProvider<ApplicationUser>>(EmailConfirmationTokenProviderName);

            services.AddOptions();
            // Setting up CORS
            var origins = new string[] {
                Configuration.GetSection("AppSettings:CorsSites:AdminSite").Value,
                Configuration.GetSection("AppSettings:CorsSites:PublishSite").Value
            };
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowSpecificOrigin",
            //            builder => builder.WithOrigins(origins)
            //            .AllowAnyOrigin()
            //            .AllowCredentials()
            //            .AllowAnyHeader()
            //            .AllowAnyMethod());
            //});

            var policy = new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy();

            policy.Headers.Add("*");
            policy.Methods.Add("*");
            policy.Origins.Add("*");
            policy.SupportsCredentials = true;

            services.AddCors(x => x.AddPolicy("corsGlobalPolicy", policy));

            // Add Authorization
            services.AddAuthorization(options =>
            {
                options.AddPolicy(PolicyRole.ADMINISTRATOR_ONLY, policyAdmin => policyAdmin.Requirements.Add(new CheckHasRoleRequiment(AppConst.ROLE_SYSADMIN, AppConst.ROLE_Mode)));
                options.AddPolicy(PolicyRole.EDIT_ONLY, policyEdit => policyEdit.Requirements.Add(new CheckHasRoleRequiment(AppConst.ROLE_SYSADMIN, AppConst.ROLE_Mode, AppConst.ROLE_Department, AppConst.ROLE_Editor)));
                options.AddPolicy(PolicyRole.EMPLOYEE_ID, policyUser => policyUser.RequireClaim("EmployeeId"));
            });
            // jwt server
            // ===== Add Jwt Authentication ========
            services.AddAuthentication(options =>
            {
                //options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        // The signing key must match!
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("AppSettings:AppConfiguration:Key").Value)),
                        // Validate the JWT Issuer (iss) claim  
                        ValidateIssuer = true,
                        ValidIssuer = Configuration.GetSection("AppSettings:AppConfiguration:Issuer").Value,
                        // Validate the JWT Audience (aud) claim  
                        ValidateAudience = true,
                        ValidAudience = Configuration.GetSection("AppSettings:AppConfiguration:Audience").Value,
                        // Validate the token expiry  
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                    };
                    // token expired
                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.Headers.Add("Token-Expired", "true");
                            }
                            return Task.CompletedTask;
                        }
                    };
                });

            // Add memory cache services
            services.AddMemoryCache();
            //Configure Automapper
            AutoMapperConfiguration.Configure();
            // Add REPOSITORY
            services.AddScoped(typeof(IRepository<,>), typeof(EfRepository<,>));
            services.AddScoped(typeof(IAsyncRepository<,>), typeof(EfRepository<,>));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<IEmailSender, AuthMessageSender>();

            // Add Configuration as Singleton
            services.AddSingleton(Configuration);
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<INewsLog, NewsLogService>();
            services.AddScoped<IMediaService, MediaService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddSingleton<IDatetimeProvider, DatetimeProvider>();
            // PasswordHasher
            services.AddScoped<PasswordHasher<ApplicationUser>>();
           
            // Add Mvc
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(opt =>
                {
                    opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    opt.SerializerSettings.SerializationBinder = new DefaultSerializationBinder();
                    opt.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                }); ;

            // Add Api
            services.AddMvcCore().AddApiExplorer();
            // Add SwaggerGen
            // Register the Swagger generator, defining one or more Swagger documents  
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info { Title = "Portal API", Version = "v1" });
                // Define the BearerAuth scheme that's in use
                options.AddSecurityDefinition("Bearer", new ApiKeyScheme()
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
                var security = new Dictionary<string, IEnumerable<string>>
                {
                    {"Bearer", new string[] { }},
                };
                options.AddSecurityRequirement(security);
                // Assign scope requirements to operations based on AuthorizeAttribute
                options.OperationFilter<AuthorizeCheckOperationFilter>();
            });

            //Confirm Email Token Expiration/Lifetime
            services.Configure<ConfirmEmailDataProtectionTokenProviderOptions>(options =>
            {
                options.Name = EmailConfirmationTokenProviderName;
                options.TokenLifespan = TimeSpan.FromMinutes(15);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            // Shows UseCors with named policy.
            app.UseCors("AllowSpecificOrigin");
            app.UseCors("corsGlobalPolicy");
            //app.UseMiddleware<ErrorHandlerMiddleware>();
            app.UseAuthentication();
            //app.UseMiddleware<TokenManagerMiddleware>();
            // Enable middleware to serve generated Swagger as a JSON endpoint.  
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.  
            app.UseSwaggerUI(c =>
            {
                //c.InjectJavascript("/swagger/ui/ngnam-auth.js");
                //c.InjectJavascript("/swagger/ui/on-complete.js");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Portal API");
                c.DocExpansion(DocExpansion.None);
                c.RoutePrefix = "api-docs";
                c.EnableFilter();
                c.SupportedSubmitMethods(SubmitMethod.Get, SubmitMethod.Head, SubmitMethod.Post, SubmitMethod.Put, SubmitMethod.Delete, SubmitMethod.Options);
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

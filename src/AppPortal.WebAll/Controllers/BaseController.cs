using AppPortal.Core.Interfaces;
using AppPortal.WebSite.Startups;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.WebSite.Controllers
{
    public class BaseController<T> : Controller
    {
        protected readonly IHostingEnvironment _hostingEnvironment;
        protected readonly IConfiguration _configuration;
        protected readonly IAppLogger<T> _logger;

        public BaseController(
        IHostingEnvironment environment,
        IConfiguration configuration,
        IAppLogger<T> logger)
        {
            _hostingEnvironment = environment;
            _configuration = configuration;
            _logger = logger;
        }

        private WebSettings _appSettings;
        protected WebSettings appSettings
        {
            get
            {
                if (_appSettings == null) this._appSettings = _configuration.GetSection("AppSettings").Get<WebSettings>();
                return this._appSettings;
            }
        }
    }
}

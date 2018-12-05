using System.Diagnostics;
using AppPortal.Core.Interfaces;
using AppPortal.Website.Services.Interfaces;
using AppPortal.WebSite.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.WebSite.Controllers
{
    public class NewsController : BaseController<HomeController>
    {
        private readonly INewsService _newsService;
        public NewsController(
            IHostingEnvironment environment,
            IConfiguration configuration,
            INewsService newsService,
            IAppLogger<HomeController> logger) : base(environment, configuration, logger)
        {
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            var data = _newsService.GetConfig("map");
            ViewData["map"] = data.url;
            return View();
        }

        public IActionResult vanban()
        {
            var data = _newsService.GetConfig("map");
            ViewData["map"] = data.url;
            return View();
        }

        public IActionResult detail()
        {
            return View();
        }
    }
}

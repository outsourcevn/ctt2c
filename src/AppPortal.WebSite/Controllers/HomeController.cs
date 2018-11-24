using System.Diagnostics;
using AppPortal.Core.Interfaces;
using AppPortal.Website.Services.Interfaces;
using AppPortal.WebSite.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppPortal.WebSite.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        private readonly INewsService _newsService;
        public HomeController(
            IHostingEnvironment environment, 
            IConfiguration configuration,
            INewsService newsService,
            IAppLogger<HomeController> logger) : base(environment, configuration, logger)
        {
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult index2()
        {
            return View(nameof(Index));
        }

        public IActionResult News()
        {
            return View(nameof(News));
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
           // ViewData["data"] = _newsService.GetNewsList();
          //  @ViewData["activeContact"] = "active";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Map()
        {
            //ViewData["activeMap"] = "active";
            return View();
        }

        public IActionResult TTQuantrac()
        {
           // ViewData["activeTTQT"] = "active";
            return View();
        }

        public IActionResult Tracuu()
        {
            // ViewData["activeTTQT"] = "active";
            return View();
        }
    }
}

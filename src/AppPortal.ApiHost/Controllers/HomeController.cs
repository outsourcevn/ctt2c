using Microsoft.AspNetCore.Mvc;

namespace AppPortal.ApiHost.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/api-docs");
        }
    }
}

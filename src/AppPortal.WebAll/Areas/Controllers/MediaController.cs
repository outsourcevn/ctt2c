using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppPortal.AdminSite.Controllers
{
    public class MediaController : Controller
    {
        public IActionResult IndexImage()
        {
            return View();
        }

        public IActionResult IndexVideo()
        {
            return View();
        }
    }
}
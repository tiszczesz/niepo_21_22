using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SamolotyzArk1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace SamolotyzArk1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private _3tisp_SamolotyArk1Context db;

        public HomeController(ILogger<HomeController> logger) {
            db = new _3tisp_SamolotyArk1Context();
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            var odloty = db.Odloties.ToList();
            Response.Cookies.Append(
                "moje",
                "smakowite",
                new Microsoft.AspNetCore.Http.CookieOptions()
                {
                    Path = "/"
                }
            );
            var cookies = Response.Cookies;
            if (cookies != null && Request.Cookies["moje"] != null) {
                ViewBag.cookie = Request.Cookies["moje"].ToString();
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

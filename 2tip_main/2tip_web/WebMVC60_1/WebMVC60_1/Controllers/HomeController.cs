using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using WebMVC60_1.Models;

namespace WebMVC60_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() {
            ViewBag.controller = ControllerContext.RouteData.Values["controller"]?.ToString();
            ViewBag.action = ControllerContext.RouteData.Values["action"]?.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string MyStringAction() {
            return "hello from string action";
        }

        public ViewResult MyViewAction() {
            return View("NewView");
        }

        public IActionResult Redirect() {
            return RedirectToAction("Privacy");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
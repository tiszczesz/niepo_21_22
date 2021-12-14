using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMysqlDb_3tip_sp.Data;
using WebMysqlDb_3tip_sp.Models;

namespace WebMysqlDb_3tip_sp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MySqlfilmDB _db;

        public HomeController(ILogger<HomeController> logger,MySqlfilmDB db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index() {
            var films = _db.Films.OrderBy(f => f.Title).ToList();
            return View(films);
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

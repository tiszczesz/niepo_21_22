using _3tisp_school1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _3tisp_school1.Data;
using Microsoft.EntityFrameworkCore;

namespace _3tisp_school1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SchoolContext _db;

        public HomeController(ILogger<HomeController> logger,SchoolContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task<IActionResult> IndexAsync() {
            var students = await _db.Students.ToListAsync();
            return View(students);
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

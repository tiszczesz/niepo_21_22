using _3ti_sp_2021_dbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _3ti_sp_2021_dbFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LibrarySP_2021Context _db;
        public HomeController(ILogger<HomeController> logger) {
            _db = new LibrarySP_2021Context();
            _logger = logger;
        }

        public IActionResult Index() {
            var cookies = HttpContext.Request.Cookies;
            IEnumerable<Book> books = _db.Books.ToList();
            return View(books);
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

        [HttpGet]
        public IActionResult Delete(int? id) {
            if (id == null) return NotFound();
            Book toDelete = _db.Books.FirstOrDefault(b => b.Id == id);
            if (toDelete == null) return NotFound();
            _db.Books.Remove(toDelete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int? id) {
            if (id == null) return NotFound();
            Book toShow = _db.Books.FirstOrDefault(b => b.Id == id);
            if (toShow == null) return NotFound();

            return View(toShow);
        }

        [HttpPost]
        public IActionResult Create(Book book) {
            if (book == null) return NotFound();
            if (ModelState.IsValid) {
                _db.Books.Add(book);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}

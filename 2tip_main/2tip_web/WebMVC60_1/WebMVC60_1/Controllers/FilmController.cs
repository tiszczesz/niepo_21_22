using Microsoft.AspNetCore.Mvc;
using WebMVC60_1.Models;

namespace WebMVC60_1.Controllers
{
    public class FilmController : Controller
    {
        
        public IActionResult Index() {
            //return RedirectToAction("Index", "Home");
            return View(FilmRepo.GeFilms());
        }
        [HttpGet]
        public IActionResult AddFilm() {
            ViewBag.IsPost = false;
            return View();
        }

        [HttpPost]
        public IActionResult AddFilm(Film film) {
            ViewBag.IsPost = true;
            return View(film);
        }
    }
}

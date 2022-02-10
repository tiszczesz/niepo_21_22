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
    }
}

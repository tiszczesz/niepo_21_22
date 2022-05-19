using Microsoft.AspNetCore.Mvc;
using MVCFormEx2.Models;

namespace MVCFormEx2.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() {
            return View();
        }
        public IActionResult CreatePost(PartyStuff ps)
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCFormEx2.Models;

namespace MVCFormEx2.Controllers
{
    public class SilniaController : Controller
    {
        [HttpGet]
        public IActionResult Index() {
            FacN n = new FacN();
            return View(n);
        }

        [HttpPost]
        public IActionResult Index(FacN n) {
            if (ModelState.IsValid) {

            }

            return View();
        }
    }
}

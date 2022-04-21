using Microsoft.AspNetCore.Mvc;
using WebWithForms.Models;

namespace WebWithForms.Controllers
{
    public class MyFormsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNew() {
            
            FillControls();
            Candidate candidate = new Candidate();
            candidate.Hobbies = new List<Item> {
                new Item { Name = "Sport" },
                new Item { Name = "Muzyka" },
                new Item { Name = "Książki" },
                new Item { Name = "Film" },
                new Item { Name = "Taniec" },
                new Item { Name = "Inne" }
            };
            return View(candidate);
        }

        [HttpPost]
        public IActionResult AddNew(Candidate candidate) {
            FillControls();
            if (ModelState.IsValid) {
                ViewBag.post = true;
            }
            else {
                ViewBag.post = false;
            }
            MyLogger.SaveFile(candidate);
            return View(candidate);
        }

        private void FillControls() {
            string[] genders = new string[] { "Kobieta", "Mężczyzna", "Inna" };
            string[] divisions = new string[] { "1A", "1B", "1C", "1TI", "1TH" };
            ViewBag.genders = genders;
            ViewBag.divisions = divisions;
        }
    }
}

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
            PartyStuff ps = new PartyStuff();
            ps.Items = new List<Item> {
                new Item { Name = "Żarcie" },
                new Item { Name = "Picie" },
                new Item { Name = "Muzyka" },
                new Item { Name = "Towarzystwo" },
                new Item { Name = "Inne" }
            };
            return View(ps);
        }
        public IActionResult CreatePost(PartyStuff ps)
        {
            if (ModelState.IsValid) {

                ViewBag.Result = "Zapisano do pliku";
            }
            else {
                ViewBag.Result = "Popraw dane!!!!";
            }

            return View(nameof(Create),ps);
            //return View("Create",ps);
        }
    }
}

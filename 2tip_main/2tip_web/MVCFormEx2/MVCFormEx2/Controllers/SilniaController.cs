using Microsoft.AspNetCore.Mvc;
using MVCFormEx2.Models;

namespace MVCFormEx2.Controllers
{
    public class SilniaController : Controller
    {
        [HttpGet]
        public IActionResult Index() {
            FacN model = new FacN();
            model.N = 12;
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(FacN model) {
            var formA = Request.Form["N"];
            if (ModelState.IsValid) {
                var result = model;
                int a = Factorial.FactorialIter(model.N);
            }

            return View(model);
        }
    }
}

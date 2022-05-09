using Microsoft.AspNetCore.Mvc;
using MVCFormEx2.Models;

namespace MVCFormEx2.Controllers
{
    public class SilniaController : Controller
    {
        [HttpGet]
        public IActionResult Index() {
            FacN model = new FacN();
            ViewBag.Choice = new String[]{"rekurencyjnie","iteracyjnie"};
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(FacN model) {
            
            if (ModelState.IsValid) {
                model.Result = Factorial.FactorialIter(model.N);
                ViewBag.OK = true;
            }

            return View(model);
        }
    }
}

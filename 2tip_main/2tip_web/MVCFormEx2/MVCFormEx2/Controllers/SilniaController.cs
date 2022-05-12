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
            ViewBag.Choice = new String[] { "rekurencyjnie", "iteracyjnie" };
            if (ModelState.IsValid) {
                
                model.Result = model.Choice== "rekurencyjnie" ? Factorial.FactorialRec(model.N):
                    Factorial.FactorialIter(model.N);
                ViewBag.OK = true;
            }

            return View(model);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

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
            string[] genders = new string[] { "Kobieta", "Mężczyzna", "Inna" };
            string[] divisions = new string[] { "1A", "1B", "1C","1TI","1TH" };
            //todo
            return View();
        }
    }
}

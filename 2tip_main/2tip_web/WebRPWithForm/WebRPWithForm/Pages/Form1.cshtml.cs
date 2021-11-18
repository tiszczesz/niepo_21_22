using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebRPWithForm.Pages
{
    public class Form1Model : PageModel
    {
        public void OnGet() {
            int a = 12;
        }

        public void OnPost(IFormCollection collection) {
            var firstname = Request.Form["firstname"].ToString();
            var lastname = Request.Form["lastname"].ToString();
            var date = Request.Form["birth"].ToString();
            ViewData["isPost"] = true;
            ViewData["firstname"] = firstname;
            ViewData["lastname"] = lastname;
            ViewData["birth"] = date;
            ViewData["colFirstName"] = collection["firstname"];
        }
    }
}

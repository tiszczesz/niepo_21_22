using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRPWithForm.Models;

namespace WebRPWithForm.Pages
{
    public class Form2Model : PageModel
    {
        [BindProperty]
        public User MyUser { get; set; }
        public void OnGet() {
            ViewData["isPost"] = false;
        }

        public void OnPost() {
            ViewData["isPost"] = true;
            var resut = MyUser;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RwzorPagesWithModel.Models;

namespace RwzorPagesWithModel.Pages
{
    public class FortuneModel : PageModel
    {
        public void OnGet() {
            ViewData["fortune"] = Fortune.GetNumber();
        }
    }
}

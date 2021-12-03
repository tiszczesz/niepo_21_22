using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorForms.Models;

namespace WebRazorForms.Pages
{
    public class ShowTableModel : PageModel
    {
        [BindProperty]
        public TableSize MyTableSize { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() {
            ViewData["IsPost"] = true;
            ViewData["html"] = generTab(MyTableSize.Rows, MyTableSize.Cols);
        }

        private string generTab(int? rows, int? cols) {
            return "<table></table>";
        }
    }
}

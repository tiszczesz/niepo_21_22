using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void OnGet() {
            MyTableSize = new TableSize();
        }

        public void OnPost() {
            ViewData["IsPost"] = true;
            ViewData["html"] = generTab(MyTableSize.Rows, MyTableSize.Cols);
        }

        private string generTab(int? rows, int? cols) {
            if (rows == null || cols == null) 
                return "<span style='color:red;'>B³êdne dane</span>";
            StringBuilder sb = new StringBuilder("<table class='table'>");
            int licznik = 1;
            for (int i = 1; i <= rows; i++) {
                sb.Append("<tr>");
                for (int j = 1; j <= cols; j++) {
                    string primalClass = Tools.IsPrimal(licznik) ? "class='primal'" : "";
                    sb.Append($"<td {primalClass}>{licznik++}</td>");
                }
                sb.Append("</tr>");
            }
            return sb.Append("</table>").ToString();
        }
    }
}

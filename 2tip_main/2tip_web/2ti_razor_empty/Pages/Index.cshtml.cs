using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        public List<string> imiona { get; set; }
        public void OnGet()
        {
            imiona = new List<string>{
                "Adam","Grażyna","Monika","Tomasz"
            };
        }
    }
}

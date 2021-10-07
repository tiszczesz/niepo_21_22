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
        public int RandomInt { get; set; }
        public void OnGet()
        {
            imiona = new List<string>{
                "Adam","Grażyna","Monika","Tomasz","Alojzy"
            };
            Random rnd = new Random();
            RandomInt = rnd.Next(5,100);
            int RandomIndex = rnd.Next(0,imiona.Count);
            ViewData["losowe"] = imiona[RandomIndex];
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCFormEx2.Models;
using PuppeteerSharp;
using PuppeteerSharp.Media;
using System.Text;

namespace MVCFormEx2.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult Index()
        {
            List<string> items = new List<string>();
            if (System.IO.File.Exists("dane.txt"))
            {
                items = FileOperations.LoadFromFile();
            }           
            return View(items);
            
        }

        public IActionResult Create() {
            PartyStuff ps = new PartyStuff();
            ps.Items = new List<Item> {
                new Item { Name = "Żarcie" },
                new Item { Name = "Picie" },
                new Item { Name = "Muzyka" },
                new Item { Name = "Towarzystwo" },
                new Item { Name = "Inne" }
            };
            return View(ps);
        }
        public IActionResult CreatePost(PartyStuff ps)
        {
            if (ModelState.IsValid) {
                FileOperations.SaveToFile(ps);
                ViewBag.Result = "Zapisano do pliku";
                return RedirectToAction("Index");
            }
            
            ViewBag.Result = "Popraw dane!!!!";
            return View(nameof(Create),ps);
            //return View("Create",ps);
        }

        public IActionResult ShowAll() {
            //pobierz z pliku do listy
            //wyslij do widoku liste aby byla numerowana
            List<string> items = FileOperations.LoadFromFile();
            return View(items);
        }
        [HttpGet]
        public async Task<IActionResult> Print()
        {
            await new BrowserFetcher().DownloadAsync(BrowserFetcher.DefaultRevision);
            await using var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true
            });
            await using var page = await browser.NewPageAsync();
            await page.EmulateMediaTypeAsync(MediaType.Screen);
            var items = FileOperations.LoadFromFile();
            StringBuilder sb = new StringBuilder();
            foreach (var item in items) {
                sb.Append(item).Append("<br>");
            }
            
            await page.SetContentAsync(sb.ToString());
            var pdfContent = await page.PdfStreamAsync(new PdfOptions
            {
                Format = PaperFormat.A4,
                PrintBackground = true
            });
            return File(pdfContent, "application/pdf", "converted.pdf");
        }
    }
}

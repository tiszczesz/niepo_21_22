using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _3ti_gim_FirstDB.Controllers
{
    public class GameController : Controller {
        private _3tip_gim_dbFirstContext _db;

        public GameController() {
           
        }
        public IActionResult Index()
        {
            _db = new _3tip_gim_dbFirstContext();
            var games = _db.Games.ToList();
            return View(games);
        }
    }
}

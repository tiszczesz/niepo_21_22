using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WFormsSqLite1.Data;
using WFormsSqLite1.ViewModel;

namespace WFormsSqLite1.Models
{
    public class RepoCake {
        private AppDbContext _db;

        public RepoCake(AppDbContext db) {
            _db = db;
        }
        public  List<CakesWithBakery> GetWithBakeries() {
            List<CakesWithBakery> result = new List<CakesWithBakery>();
            foreach (var cake in _db.Cakes.Include(c=>c.Bakery).ToList()) {
                result.Add(new CakesWithBakery(cake));
            }

            return result;
        }
    }
}

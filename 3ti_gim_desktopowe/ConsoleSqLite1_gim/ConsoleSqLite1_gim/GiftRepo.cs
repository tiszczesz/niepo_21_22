using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSqLite1_gim.Data;
using ConsoleSqLite1_gim.Models;

namespace ConsoleSqLite1_gim
{
    public class GiftRepo {
        private GiftDbContext _db;

        public GiftRepo() {
            _db = new GiftDbContext();
        }

        public void ShowAll() {
            List<Gift> gifts = _db.Gifts.ToList();
            foreach (Gift gift in gifts) {
                Console.WriteLine($"{gift.Name} dla {gift.Owner} za {gift.Price} PLN");
            }
        }
    }
}

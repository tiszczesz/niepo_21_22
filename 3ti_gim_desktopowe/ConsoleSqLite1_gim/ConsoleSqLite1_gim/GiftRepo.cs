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
                Console.WriteLine($"Id: {gift.Id} {gift.Name} dla {gift.Owner} za {gift.Price} PLN");
            }
        }

        public void AddNew(Gift gift) {
            _db.Gifts.Add(gift);
            _db.SaveChanges();
        }

        public void Delete(int id) {
            Gift gift = _db.Gifts.FirstOrDefault(g => g.Id == id);
            if(gift==null) return;
            _db.Gifts.Remove(gift);
            _db.SaveChanges();
        }
    }
}

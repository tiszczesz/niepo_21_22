using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithListVew.Models
{
    public class Gifts
    {
        public List<Gift> MyGifts { get; set; }

        public Gifts() {
            MyGifts = new List<Gift> {
                new Gift {Name = "Saneczki", Price = 34.89M},
                new Gift {Name = "Rowerek", Price = 120.00M},
                new Gift {Name = "Lalka Barbie", Price = 29.89M},
                new Gift {Name = "Samochodzik", Price = 12.89M},
                new Gift {Name = "Misiu", Price = 52.89M},
                new Gift {Name = "Narty", Price = 312.89M}
            };
        }

        public decimal GetTotalPrice() {
            return MyGifts.Sum(g=>g.Price);
        }
    }
}

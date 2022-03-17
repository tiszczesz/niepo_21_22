using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFormsSqLite1.Models;

namespace WFormsSqLite1.ViewModel
{
    public class CakesWithBakery {
        private Cake _cake;

        public CakesWithBakery(Cake cake) {
            _cake = cake;
            CakeName = cake.Name;
            CakePrice = cake.Price;
            BakeryName = cake.Bakery.Name;
            BakeryAddress = cake.Bakery.Address;
        }

        public string CakeName { get; set; }
        public decimal CakePrice { get; set; }
        public string BakeryName { get; set; }
        public string BakeryAddress { get; set; }
    }
}

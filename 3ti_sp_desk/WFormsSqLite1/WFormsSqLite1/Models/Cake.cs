using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormsSqLite1.Models
{
    public class Cake
    {
        [Key]
        public int CakeId { get; set; }

        [Required(ErrorMessage = "Podaj nazwę ciastka")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Podaj cenę")]
        public decimal Price { get; set; }
        public string Description { get; set; }

        public Bakery Bakery { get; set; }
        public int BakeryId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFormsSqLite1.Models
{
    public class Bakery
    {
        [Key]
        public int BakeryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual IEnumerable<Cake> Cakes { get; set; }
    }
}

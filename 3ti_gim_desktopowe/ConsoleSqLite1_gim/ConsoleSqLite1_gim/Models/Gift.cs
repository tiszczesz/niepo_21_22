using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSqLite1_gim.Models
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Owner { get; set; }

        public decimal Price { get; set; }

    }
}

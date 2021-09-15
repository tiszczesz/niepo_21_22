using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace _3ti_sp_cw1_2021_22.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Range(0,10000)]
        public decimal Price { get; set; }
    }
}

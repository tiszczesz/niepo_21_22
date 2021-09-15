using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace cw1_EF_all.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1_gim_ADO_1.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SpeciesId { get; set; }
        public string Image { get; set; }

        public Species Species { get; set; }
    }
}

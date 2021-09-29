using System;
using System.Collections.Generic;

#nullable disable

namespace _3ti_gim_FirstDB.Models
{
    public partial class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}

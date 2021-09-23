using System;
using System.Collections.Generic;

#nullable disable

namespace _3ti_sp_2021_dbFirst
{
    public partial class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RwzorPagesWithModel.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfRelease { get; set; }
    }
}

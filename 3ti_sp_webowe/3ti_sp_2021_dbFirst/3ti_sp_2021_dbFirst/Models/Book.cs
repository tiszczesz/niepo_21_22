using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace _3ti_sp_2021_dbFirst
{
    public partial class Book
    {
        public int Id { get; set; }
        
        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [DisplayName("Autor")]
        public string Author { get; set; }

        [DisplayName("Cena")]
        public decimal Price { get; set; }

        [DisplayName("Opis")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}

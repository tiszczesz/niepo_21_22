using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMysqlDb_3tip_sp.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Podaj tytuł")]
        [StringLength(50)]
        public string Title { get; set; }


        [Required(ErrorMessage = "Podaj autora")]
        [StringLength(50)]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}

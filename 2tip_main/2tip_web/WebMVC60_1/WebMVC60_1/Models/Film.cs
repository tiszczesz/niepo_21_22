using System.ComponentModel.DataAnnotations;

namespace WebMVC60_1.Models
{
    public class Film
    {
        public int Id { get; set; }
        
        [Display(Name = "Tytuł")]
        [Required]
        public string Title { get; set; }
        
        [Display(Name = "Data wydania")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }
    }
}

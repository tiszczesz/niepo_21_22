using System.ComponentModel.DataAnnotations;

namespace WebWithForms.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Podaj imię")]
        [MinLength(3,ErrorMessage = "Podaj conajmniej 3 litery")]
        public string Firstname { get; set; }

        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Podaj nazwisko")]
        [MinLength(3, ErrorMessage = "Podaj conajmniej 3 litery")]
        public string Lastname { get; set; }

        [Display(Name = "Płeć")] 
        public string Gender { get; set; } = "Kobieta";

        [Display(Name = "Klasa")] 
        public string Division { get; set; }

        [Display(Name = "Zainteresowania")]
        public List<Item> Hobbies { get; set; }

        [Display(Name = "Data urodzenia")] 
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}

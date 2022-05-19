using System.ComponentModel.DataAnnotations;

namespace MVCFormEx2.Models
{
    public class PartyStuff
    {
        [Required(ErrorMessage = "Musisz podać imię")]
        [MinLength(3,ErrorMessage = "Minimalnie 3 litery")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Musisz podać nazwisko")]
        [MinLength(3, ErrorMessage = "Minimalnie 3 litery")]
        public string LastName { get; set; }
        public List<Item> Items { get; set; }
    }
}

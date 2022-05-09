using System.ComponentModel.DataAnnotations;

namespace MVCFormEx2.Models
{
    public class FacN
    {
        [Display(Name = " n = ")]
        [Required(ErrorMessage = "Podaj liczbę dodatnią")]
        [Range(minimum:0,maximum:20,ErrorMessage = "Przedział (0,20)!")]
        public int? N { get; set; }
        public int Result { get; set; }

        [Display(Name = "Wybór metody")] 
        public string Choice { get; set; }

       
    }
}

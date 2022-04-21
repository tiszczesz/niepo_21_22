using System.ComponentModel.DataAnnotations;

namespace MVCFormEx2.Models
{
    public class FacN
    {
        [Display(Name = "n = ")]
        [Required(ErrorMessage = "Podaj liczbę dodatnią")]
        [Range(0,20,ErrorMessage = "Liczba (0,20)")]
        public int? N { get; set; }
        public int Result { get; set; }
    }
}

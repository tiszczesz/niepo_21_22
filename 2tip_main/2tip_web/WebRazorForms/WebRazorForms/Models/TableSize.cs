using System.ComponentModel.DataAnnotations;

namespace WebRazorForms.Models {
    public class TableSize {

        [Required(ErrorMessage = "Podaj ilość wierszy")]
        [Display(Name = "Podaj ilość wierszy")]
        [Range(5, 50, ErrorMessage = "Zakres 5,50")]
        public int? Rows { get; set; } = 20;

        [Required(ErrorMessage = "Podaj ilość kolumn")]
        [Display(Name = "Podaj ilość kolumn")]
        [Range(5, 50, ErrorMessage = "Zakres 5,50")]
        public int? Cols { get; set; } = 20;
    }
}
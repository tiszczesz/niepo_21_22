using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3tisp_school1.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        
        [Display(Name = "Ocena")]
        [Required(ErrorMessage = "Pole wymagane")]
        public string GradeName { get; set; }

        [Required(ErrorMessage = "Nazwa egzaminu")]
        public string Section { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}
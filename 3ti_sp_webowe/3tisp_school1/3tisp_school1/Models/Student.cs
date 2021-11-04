using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _3tisp_school1.Models
{
    public class Student
    {
        [Key]
        public int IdStudentId { get; set; }
        
        [Display(Name = "Nazwa studenta")]
        [Required(ErrorMessage = "Podaj nazwę")]
        public string StudentName { get; set; }
        
        [Display(Name = "Data urodzenia")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }

        [Display(Name = "Wysokość w cm")]
        [Range(0,300)]
        public decimal Height { get; set; }

        [Display(Name = "Masa w kg")]
        [Range(0,300)]
        public float Weight { get; set; }

        [Display(Name = "Egzamin")]
        public Grade Grade { get; set; }

 
        [Display(Name = "Egzamin")]
        public int GradeId { get; set; }
       
    }
}

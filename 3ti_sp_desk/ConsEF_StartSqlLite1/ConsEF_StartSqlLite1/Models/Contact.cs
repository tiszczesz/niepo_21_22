using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsEF_StartSqlLite1.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public string FirstName { get; set; } = String.Empty;

        [Required] 
        public string LastName { get; set; } = String.Empty;
        public string? Address { get; set; }
    }
}

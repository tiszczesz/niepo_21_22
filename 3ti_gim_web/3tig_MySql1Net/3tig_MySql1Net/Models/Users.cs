using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _3tig_MySql1Net.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOf { get; set; }
    }
}

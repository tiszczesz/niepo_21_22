using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SamolotyzArk1.Models
{
    public  class Odloty
    {
        [Key]
        public int Id { get; set; }
        
        public int SamolotyId { get; set; }
        public string NrRejsu { get; set; }
        public string Kierunek { get; set; }
        
        [DataType(DataType.Time)]
        public TimeSpan Czas { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? Dzien { get; set; }
        public string StatusLotu { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace SamolotyzArk1.Models
{
    public partial class Odloty
    {
        public int Id { get; set; }
        public int SamolotyId { get; set; }
        public string NrRejsu { get; set; }
        public string Kierunek { get; set; }
        public TimeSpan Czas { get; set; }
        public DateTime? Dzien { get; set; }
        public string StatusLotu { get; set; }
    }
}

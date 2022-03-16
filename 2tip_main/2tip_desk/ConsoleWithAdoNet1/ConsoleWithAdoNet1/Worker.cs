using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWithAdoNet1
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public override string ToString() {
            return $"Informacje o pracowniku: Id: {Id} {FirstName} {LastName} stanowisko: {Position}";
        }
    }
}

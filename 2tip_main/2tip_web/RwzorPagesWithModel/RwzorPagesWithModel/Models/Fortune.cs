using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RwzorPagesWithModel.Models
{
    public class Fortune
    {
        public static int GetNumber() {
            Random rnd = new Random();
            return rnd.Next(1, 31);
        }
    }
}

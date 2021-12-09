using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRazorForms.Models
{
    public class Tools
    {
        public static bool IsPrimal(int number) {
            if (number == 1) return false;
            for (int i = 2; i*i <= number; i++) {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}

namespace MVCFormEx2.Models
{
    public class Factorial
    {
        public static int FactorialRec(int? n) {
            return 10;
        }
        public static int FactorialIter(int? n) {
            int result = 1;
            for (int i = 1; i <= n; i++) {
                result *= i; //result = result * i;
            }

            return result;
        }
    }
}

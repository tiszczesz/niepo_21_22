namespace MVCFormEx2.Models
{
    public class Factorial
    {
        public static int FactorialRec(int? n) {
            if (n == null) return 1;
            if (n <= 1) return 1;
            return (int)(FactorialRec(n - 1) * n);
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

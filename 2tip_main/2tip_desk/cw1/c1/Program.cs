using System;

namespace c1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GetText());
            Console.WriteLine(GetSum(5,12));
            
        }
        static string GetText(){
            return "olalalla";
        }
        static int GetSum(int a, int b){
            return a+b;
        }
    }

}

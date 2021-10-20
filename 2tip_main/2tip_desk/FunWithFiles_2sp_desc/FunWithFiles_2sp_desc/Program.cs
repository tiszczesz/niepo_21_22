using System;

namespace FunWithFiles_2sp_desc
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1.WorkWithDir();
            Console.WriteLine("\n======================\n");
            Exercise1.ReadFile("dane.txt");
        }
    }
}

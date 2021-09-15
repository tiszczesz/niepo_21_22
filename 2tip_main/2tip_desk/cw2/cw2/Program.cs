using System;

namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Cw1();
          //  Cw2();
          Cw3();
        }

        static void Cw1() {
            const int adult = 18;
            Console.Write("Podaj swoje imie: ");
            string firstName = Console.ReadLine();
            Console.Write("Podaj swoje nazwisko: ");
            string lastName = Console.ReadLine();
            Console.Write("Podaj swoj wiek: ");
            try {
                
                int age = Convert.ToInt32(Console.ReadLine());
                if(age<=0){
                     Console.WriteLine($"Witaj {firstName} {lastName}.\nJeszcze sie nie urodziles");
                }
                else if (age >= adult) {
                    Console.WriteLine($"Witaj {firstName} {lastName}.\nTwoj wiek: {age} pelnoletni");
                }
                else {
                    Console.WriteLine($"Witaj {firstName} {lastName}.\nTwoj wiek: {age} malolat!!!");
                }
                
            }
            catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
            
           
        }

        static void Cw2() {
            Console.Write("Podaj login: ");
            string login = Console.ReadLine();

            string result = login.Length > 5 ? "odpowiednia dlugosc loginu" : "login jest za krotki!";
            Console.WriteLine(result);
        }

        static void Cw3() {
            Console.Write("Podaj liczbe poczatkowa: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj ilosc liczb: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i=start; i<=(start+count); i++) {
                Console.WriteLine($"\t{i}\t{i*i}");
            }
        }
    }
}

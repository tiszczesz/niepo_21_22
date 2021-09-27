using System;

namespace cw2 {
    internal class Program {
        private static void Main(string[] args) {
            // Cw1();
            //  Cw2();
            // Cw3();
            // Cw4();
           // Cw5_bis();
           // Cw6();
            Cw7();
        }

        private static void Cw6() {
            Random rnd = new Random();
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int licznik = 0;
            int suma = 0;
            int losowa = 0;
            do {
                losowa = rnd.Next(0, 30);
                Console.Write(losowa+" ");
                if (losowa != 0) {
                    licznik++;
                    suma += licznik;
                    if (losowa < min) min = losowa;
                    if (losowa > max) max = losowa;
                }
            } while (losowa!=0);

            if (licznik == 0) {
                Console.WriteLine("\nZbior pusty!!!");
            }
            else {
                Console.WriteLine($"\nIlosc elementow: {licznik}");
                Console.WriteLine($"Najwieksza wartosc: {max}");
                Console.WriteLine($"Najmniejsza wartosc: {min}");
                Console.WriteLine($"Srednia wartosc: {(double)suma/licznik}");
            }
        }

        private static void Cw7() {
            //Test();
            //Pytanie o poczatek przedzialu liczb
            Console.Write("Podaj poczatek przedzialu: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj ilosc liczb: ");
            int count = Convert.ToInt32(Console.ReadLine());
            //Pytanie o ilosc liczb    poczatet->7  ilosc->10  przedzial->(7,17)
            //  3 -> tak

            for (int i = first; i <= (first + count); i++) {
                string ok = IsPrimal(i) ? " -> tak" : "";
                Console.WriteLine(i+ok);
            }
            //  4

        }

        private static void Test() {
            Console.Write("Podaj liczbe calkowita dodatnia: ");
            int liczba = Convert.ToInt32(Console.ReadLine());
            if (IsPrimal(liczba)) Console.WriteLine($"Liczba: {liczba} jest pierwsza");
            else Console.WriteLine($"Liczba: {liczba} nie jest pierwsza");
        }
        private static bool IsPrimal(int number) {
            if (number == 1) return false;
            //if (number == 2) return true;
            for (int i = 2; (i * i) <= number; i++) {
                if (number % i == 0) return false;
            }
            return true;
        }
        private static void Cw1() {
            const int adult = 18;
            Console.Write("Podaj swoje imie: ");
            var firstName = Console.ReadLine();
            Console.Write("Podaj swoje nazwisko: ");
            var lastName = Console.ReadLine();
            Console.Write("Podaj swoj wiek: ");
            try {
                var age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                    Console.WriteLine($"Witaj {firstName} {lastName}.\nJeszcze sie nie urodziles");
                else if (age >= adult)
                    Console.WriteLine($"Witaj {firstName} {lastName}.\nTwoj wiek: {age} pelnoletni");
                else
                    Console.WriteLine($"Witaj {firstName} {lastName}.\nTwoj wiek: {age} malolat!!!");
            }
            catch (FormatException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Cw2() {
            Console.Write("Podaj login: ");
            var login = Console.ReadLine();

            var result = login.Length > 5 ? "odpowiednia dlugosc loginu" : "login jest za krotki!";
            Console.WriteLine(result);
        }

        private static void Cw3() {
            Console.Write("Podaj liczbe poczatkowa: ");
            var start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj ilosc liczb: ");
            var count = Convert.ToInt32(Console.ReadLine());
            for (var i = start; i <= start + count; i++) Console.WriteLine($"\t{i}\t{i * i}");
        }

        private static void Cw4() {
            for (var i = 0; i < 10; i++) {
                Console.WriteLine($"przed ifem i= {i}");
                if (i > 5) continue;
                Console.WriteLine($"po ifie i= {i}");
            }
        }

        private static void Cw5() {
            var sum = 0;
            const int RANGE = 100;
            var rnd = new Random();
            var number = 0;
            var count = 0;
            while (sum < RANGE) {
                number = rnd.Next(1, 30);
                Console.WriteLine(number + " ");
                sum += number; // sum = sum + number;
                count++;
            }
            Console.WriteLine($"Suma: {sum}");
            Console.WriteLine($"ilosc losowan: {count}");
        }
        private static void Cw5_bis()
        {
            var sum = 0;
            const int RANGE = 100;
            var rnd = new Random();
            var number = 0;
            int count =0;
           for(;true;count++) {
               if (sum >= RANGE) break;
                number = rnd.Next(1, 30);
                Console.WriteLine(number + " ");
                sum += number; // sum = sum + number;
               // count++;
            }
            Console.WriteLine($"Suma: {sum}");
            Console.WriteLine($"ilosc losowan: {count}");
        }
    }
}
using System;

namespace cw2 {
    internal class Program {
        private static void Main(string[] args) {
            // Cw1();
            //  Cw2();
            // Cw3();
            // Cw4();
            Cw5_bis();
           // Cw6();
        }

        private static void Cw6() {
            do {

            } while (true);
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
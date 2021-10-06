using System;

namespace _2ti_classFirst
{
    class Program
    {
        static void Main(string[] args) {
           //Ex1();
           //Ex2();
           Ex3();
        }

        public static void Ex2() {
            //klasa Circle ma miec property z dodatnim promieniem Radius -> Age
            // oraz metody ToString() GetArea() GetCircuit()
            //utworzenie obiektu c1 klasy Circle  
            // policzenie obwodu i pola dla Circle
           // Math.PI;
        }
        public static void Ex1() {
            User u1 = new User();//wywolanie konstruktora domyslnego
            //u1.name = "Jurek";
            u1.Age = -7;
            Console.WriteLine(u1.GetType());
            u1.SetName("Jurek");
            Console.WriteLine($"Zmienna u1 ma pole name: {u1.GetName()} " +
                              $"a pole age: {u1.Age} login: {u1.Login}");
            Console.WriteLine(u1);
            Console.WriteLine($"User {u1.GetName()} jest {u1.IsAdult()}");
        }

        public static void Ex3() {
            Point2D p1 = new Point2D(6,8);
            Point2D p2 = new Point2D(3,4);
            Console.WriteLine($"p1: {p1} p2: {p2}");
            Console.WriteLine($"Odleglosc punktu: {p2} od (0,0) wynosi: {p2.Distance()}");
            Console.WriteLine($"Odleglosc punktu: {p2} od {p1} wynosi: {p2.Distance(p1)}");

            Console.WriteLine(p1+p2);
            if (true) {
                Point2D p3 = new Point2D(4, 4);
                Console.WriteLine(p3);
            }
            Console.WriteLine("12"+"45");
        }

       
    }
}

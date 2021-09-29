using System;

namespace _2ti_classFirst
{
    class Program
    {
        static void Main(string[] args) {
           Ex1();
           Ex2();
        }

        public static void Ex2() {
            //klasa Circle ma miec property z dodatnim promieniem Radius -> Age
            // oraz metody ToString() GetArea() GetCircuit()
            //utworzenie obiektu c1 klasy Circle  
            // policzenie obwodu i pola dla Circle
           // Math.PI;
        }
        public static void Ex1() {
            User u1 = new User();
            //u1.name = "Jurek";
            u1.Age = -7;
            Console.WriteLine(u1.GetType());
            u1.SetName("Jurek");
            Console.WriteLine($"Zmienna u1 ma pole name: {u1.GetName()} " +
                              $"a pole age: {u1.Age} login: {u1.Login}");
            Console.WriteLine(u1);
            Console.WriteLine($"User {u1.GetName()} jest {u1.IsAdult()}");
        }
    }
}

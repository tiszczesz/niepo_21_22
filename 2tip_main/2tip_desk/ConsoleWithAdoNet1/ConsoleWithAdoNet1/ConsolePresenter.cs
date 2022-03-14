using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWithAdoNet1
{
    public class ConsolePresenter
    {
        public static void ShowWorkers(List<Worker> workers) {
            foreach (var worker in workers) {
                Console.WriteLine(worker);
            }
        }

        public static Worker GetWorker() {
            Console.Write("Podaj imie: ");
            string firstName = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();
            Console.Write("Podaj stanowisko: ");
            string position = Console.ReadLine();
            return new Worker { Id = -1, FirstName = firstName, LastName = lastName, Position = position };
        }
    }
}

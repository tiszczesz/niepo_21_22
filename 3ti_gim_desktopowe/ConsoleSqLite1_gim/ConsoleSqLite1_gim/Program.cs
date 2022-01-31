using System;
using ConsoleSqLite1_gim.Data;
using ConsoleSqLite1_gim.Models;

namespace ConsoleSqLite1_gim
{
    class Program
    {
        static void Main(string[] args) {
           
            GiftDbContext db = new GiftDbContext();
            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();
            GiftRepo repo = new GiftRepo();
             repo.ShowAll();
             Console.WriteLine("czy dodac nowy prezent (t/n)?: ");

             string question = Console.ReadLine();
             if (question!=null && question.StartsWith('t') ) {
                AddNewGift();
                repo.ShowAll();
             }
             Console.ReadKey();
        }

        public static void AddNewGift() {
            Console.WriteLine("Podaj nazwe prezentu: ");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj imie osoby: ");
            string owner = Console.ReadLine();
            Console.WriteLine("Podaj cenę: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Gift gift = new Gift { Name = name, Owner = owner, Price = price };
            GiftRepo repo = new GiftRepo();
            repo.AddNew(gift);
        }
    }
}

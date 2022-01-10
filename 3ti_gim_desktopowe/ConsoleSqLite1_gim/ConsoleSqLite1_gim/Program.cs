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
           // Gift g = new Gift {Name = "rrr", Owner = "gggg", Price = 23.7M};
           //db.Gifts.Add(g);
           //db.SaveChanges();
           //repo.ShowAll();
            Console.ReadKey();
        }
    }
}

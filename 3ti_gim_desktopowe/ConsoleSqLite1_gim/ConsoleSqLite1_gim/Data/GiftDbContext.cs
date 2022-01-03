using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSqLite1_gim.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleSqLite1_gim.Data
{
    public class GiftDbContext : DbContext
    {
        public GiftDbContext():base() {
        }
        public DbSet<Gift> Gifts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=myGifts_gim.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Gift>().HasData(
                new Gift {
                    Id = 1,
                    Name = "Samochodzik czerwony",
                    Owner = "Adaś Małecki",
                    Price = 12.67M
                },
                new Gift
                {
                    Id = 2,
                    Name = "Laleczka",
                    Owner = "Dominika Małecka",
                    Price = 52.67M
                },
                new Gift
                {
                    Id = 3,
                    Name = "Słodycze",
                    Owner = "Maria Małecka",
                    Price = 23.99M
                },
                new Gift
                {
                    Id = 4,
                    Name = "Płyn do znieczulania",
                    Owner = "Tomasz Małecki",
                    Price = 80.67M
                }
                );
        }
    }
}

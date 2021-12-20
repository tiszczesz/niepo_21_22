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
        public DbSet<Gift> Gifts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=myGifts_gim.db");
        }
    }
}

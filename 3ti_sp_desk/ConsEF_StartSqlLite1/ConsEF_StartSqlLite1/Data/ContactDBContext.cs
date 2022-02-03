using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsEF_StartSqlLite1.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsEF_StartSqlLite1.Data
{
    public class ContactDBContext : DbContext
    {
        public ContactDBContext():base() { }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=myContacts_lite.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().HasData(
                new Contact{Id = 1,FirstName = "Adam",LastName = "Nowak",Address = "kwitowa 12/7"},
                new Contact{Id = 2,FirstName = "Monika",LastName = "Nowak",Address = "kwitowa 12/7"},
                new Contact{Id = 3,FirstName = "Tomasz",LastName = "Bomasz",Address = "Długa 16/1"},
                new Contact{Id = 4,FirstName = "Roman",LastName = "Tomera",Address = "Grochowa 12/7"}
                
                
                );
        }
    }
}

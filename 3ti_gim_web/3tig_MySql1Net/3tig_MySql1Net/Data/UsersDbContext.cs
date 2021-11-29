using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _3tig_MySql1Net.Models;

namespace _3tig_MySql1Net.Data
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options)
        :base(options)
        {
            
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>().ToTable("UsersTable");

            modelBuilder.Entity<Users>().HasData(
                new Users {Id=1,Firstname = "Antoni",Lastname = "Małecki",DateOf = new DateTime(2012,12,12)},
                new Users {Id=2,Firstname = "Antoni",Lastname = "Małecki",DateOf = new DateTime(2012,12,12)},
                new Users {Id=3,Firstname = "Antoni",Lastname = "Małecki",DateOf = new DateTime(2012,12,12)}
       

              
                );
        }
    }
}

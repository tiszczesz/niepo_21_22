using System;
using Microsoft.EntityFrameworkCore;
using WebMysqlDb_3tip_sp.Models;

namespace WebMysqlDb_3tip_sp.Data {
    public class MySqlfilmDB : DbContext {
        public MySqlfilmDB(DbContextOptions<MySqlfilmDB> options) : base(options) {
        }

        public DbSet<Film> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Film>().HasData(
                new Film {
                    Id = 1, Title = "Samo zło", Author = "Tomasz Bomasz",
                    ReleaseDate = new DateTime(2012, 4, 12)
                },
                new Film {
                    Id = 2,
                    Title = "Rybacy",
                    Author = "Maurycy Murzecki",
                    ReleaseDate = new DateTime(2009, 3, 22)
                },
                new Film {
                    Id = 3, Title = "Wisna", Author = "Monika Małecka",
                    ReleaseDate = new DateTime(2004, 1, 7)
                },
                new Film {
                    Id = 4,
                    Title = "Nie wiem",
                    Author = "Egeniusz Pawlikowski",
                    ReleaseDate = new DateTime(2013, 4, 8)
                }
            );
        }
    }
}
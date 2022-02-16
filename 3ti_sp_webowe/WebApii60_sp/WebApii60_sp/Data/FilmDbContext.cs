using Microsoft.EntityFrameworkCore;
using WebApii60_sp.Models;

namespace WebApii60_sp.Data
{
    public class FilmDbContext :DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) :base(options)
        { }

        public DbSet<Film> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Film>().HasData(
                new Film
                {
                    Id = 1,
                    Title = "Szeregowiec Ryan",
                    Director = "Tomasz Bomasz",
                    CreateDate = new DateTime(2010, 5, 12)
                },
                new Film
                {
                    Id = 2,
                    Title = "Gwiezdne wojny 1",
                    Director = "Helena Melena",
                    CreateDate = new DateTime(2010, 5, 12)
                },
                new Film
                {
                    Id = 3,
                    Title = "Gwiezdne wojny 2",
                    Director = "Tomasz Małecki",
                    CreateDate = new DateTime(2010, 4, 23)
                },
                new Film
                {
                    Id = 4,
                    Title = "Gwinea",
                    Director = "Anna Wanna",
                    CreateDate = new DateTime(2008, 5, 12)
                },
                new Film
                {
                    Id = 5,
                    Title = "Wojna i Pokój",
                    Director = "Roman Polański",
                    CreateDate = new DateTime(1990, 8, 21)
                },
                new Film
                {
                    Id = 6,
                    Title = "Najnowszy Film",
                    Director = "Agta Bałata",
                    CreateDate = new DateTime(2022, 1, 21)
                }
                );
        }
    }
}

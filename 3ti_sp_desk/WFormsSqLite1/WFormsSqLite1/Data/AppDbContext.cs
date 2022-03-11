using Microsoft.EntityFrameworkCore;
using WFormsSqLite1.Models;

namespace WFormsSqLite1.Data; 

public class AppDbContext: DbContext {
    public AppDbContext():base() {
    }

    public DbSet<Cake> Cakes { get; set; }
    public DbSet<Bakery> Bakeries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=myCakes_sqlite.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Bakery>().HasData(
            new Bakery{BakeryId = 1,Name = "Piekarnia sądecka",Address = "Nowy Sącz 32-222"},
            new Bakery{BakeryId = 2,Name = "Piekarz i Spółka",Address = "Kraków 31-222"},
            new Bakery{BakeryId = 3,Name = "Staropolska Piekarnia",Address = "Bochnia 34-333"},
            new Bakery{BakeryId = 4,Name = "Wypieki własne",Address = "Kraków 31-233"}
        );
        modelBuilder.Entity<Cake>().HasData(
            new Cake { Name = "Mały Hiszpan",CakeId = 1,BakeryId = 1,Description = "długi opis piekarni",Price = 2.66M},
            new Cake { Name = "Rolada mała",CakeId = 2,BakeryId = 1,Description = "długi opis piekarni",Price = 12.99M},
            new Cake { Name = "Pączek średni",CakeId = 3,BakeryId = 2,Description = "długi opis piekarni",Price = 0.99M},
            new Cake { Name = "Torcik wenecki",CakeId = 4,BakeryId = 2,Description = "długi opis piekarni",Price = 8.99M},
            new Cake { Name = "Drożdżowe ciastko",CakeId = 5,BakeryId = 3,Description = "długi opis piekarni",Price = 1.66M},
            new Cake { Name = "Tort średni",CakeId = 6,BakeryId = 3,Description = "długi opis piekarni",Price = 7.66M},
            new Cake { Name = "Faworki",CakeId = 7,BakeryId = 3,Description = "długi opis piekarni",Price = 12.89M},
            new Cake { Name = "Napoleon",CakeId = 8,BakeryId = 4,Description = "długi opis piekarni",Price = 3.99M}
            );
    }
}
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace mysqlefcore
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Book { get; set; }

    public DbSet<Publisher> Publisher { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=Library_dotnet;user=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      
      modelBuilder.Entity<Publisher>(entity =>
      {
        entity.HasKey(e => e.ID);
        entity.Property(e => e.Name).IsRequired();
      });

      modelBuilder.Entity<Book>(entity =>
      {
        entity.HasKey(e => e.ISBN);
        entity.Property(e => e.Title).IsRequired();
        entity.HasOne(d => d.Publisher)
          .WithMany(p => p.Books);
      });
    //   Publisher publisher =  new Publisher
    //             {
    //                 Name = "Mariner Books"
    //             };
    //    modelBuilder.Entity<Publisher>().HasData(
    //       publisher
    //     );
    //      modelBuilder.Entity<Book>().HasData(
    //        new Book
    //             {
    //                 ISBN = "978-0544003415",
    //                 Title = "The Lord of the Rings",
    //                 Author = "J.R.R. Tolkien",
    //                 Language = "English",
    //                 Pages = 1216,
    //                 Publisher =  publisher
    //             },
    //             new Book
    //             {
    //                 ISBN = "978-0547247762",
    //                 Title = "The Sealed Letter",
    //                 Author = "Emma Donoghue",
    //                 Language = "English",
    //                 Pages = 416,
    //                 Publisher = publisher
    //             }
    //     );
    }
    }
}
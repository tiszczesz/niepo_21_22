using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SamolotyzArk1.Models;

#nullable disable

namespace SamolotyzArk1
{
    public partial class _3tisp_SamolotyArk1Context : DbContext
    {
        public _3tisp_SamolotyArk1Context()
        {
        }

        public _3tisp_SamolotyArk1Context(DbContextOptions<_3tisp_SamolotyArk1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Odloty> Odloties { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=3tisp_SamolotyArk1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Odloty>(entity =>
            {
                entity.HasKey("Id");

                entity.ToTable("odloty");

                entity.Property(e => e.Czas).HasColumnName("czas");

                entity.Property(e => e.Dzien)
                    .HasColumnType("date")
                    .HasColumnName("dzien");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Kierunek)
                    .HasMaxLength(10)
                    .HasColumnName("kierunek");

                entity.Property(e => e.NrRejsu)
                    .HasMaxLength(8)
                    .HasColumnName("nr_rejsu");

                entity.Property(e => e.SamolotyId).HasColumnName("samoloty_id");

                entity.Property(e => e.StatusLotu)
                    .HasMaxLength(50)
                    .HasColumnName("status_lotu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

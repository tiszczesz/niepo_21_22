﻿// <auto-generated />
using ConsoleSqLite1_gim.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleSqLite1_gim.Migrations
{
    [DbContext(typeof(GiftDbContext))]
    partial class GiftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("ConsoleSqLite1_gim.Models.Gift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Owner")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gifts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samochodzik czerwony",
                            Owner = "Adaś Małecki",
                            Price = 12.67m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laleczka",
                            Owner = "Dominika Małecka",
                            Price = 52.67m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Słodycze",
                            Owner = "Maria Małecka",
                            Price = 23.99m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Płyn do znieczulania",
                            Owner = "Tomasz Małecki",
                            Price = 80.67m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
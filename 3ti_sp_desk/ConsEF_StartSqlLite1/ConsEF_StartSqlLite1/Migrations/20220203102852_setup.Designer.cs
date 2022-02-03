﻿// <auto-generated />
using ConsEF_StartSqlLite1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsEF_StartSqlLite1.Migrations
{
    [DbContext(typeof(ContactDBContext))]
    [Migration("20220203102852_setup")]
    partial class setup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("ConsEF_StartSqlLite1.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "kwitowa 12/7",
                            FirstName = "Adam",
                            LastName = "Nowak"
                        },
                        new
                        {
                            Id = 2,
                            Address = "kwitowa 12/7",
                            FirstName = "Monika",
                            LastName = "Nowak"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Długa 16/1",
                            FirstName = "Tomasz",
                            LastName = "Bomasz"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Grochowa 12/7",
                            FirstName = "Roman",
                            LastName = "Tomera"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
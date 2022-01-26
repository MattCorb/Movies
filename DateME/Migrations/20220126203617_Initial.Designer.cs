﻿// <auto-generated />
using DateME.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DateME.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    [Migration("20220126203617_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("DateME.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Crepe")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Major")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("ApplicationId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            Age = (byte)23,
                            Crepe = false,
                            FirstName = "Matt",
                            LastName = "Corbett",
                            Major = "IS",
                            PhoneNumber = "555-555"
                        },
                        new
                        {
                            ApplicationId = 2,
                            Age = (byte)50,
                            Crepe = true,
                            FirstName = "Creed",
                            LastName = "Bratton",
                            Major = "N/A",
                            PhoneNumber = "0"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
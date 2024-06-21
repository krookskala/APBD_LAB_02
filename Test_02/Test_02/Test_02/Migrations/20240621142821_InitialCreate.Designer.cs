﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Test_02.Migrations
{
    [DbContext(typeof(RacingTournamentContext))]
    [Migration("20240621142821_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test_02.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarManufacturerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Test_02.Models.CarManufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarManufacturers");
                });

            modelBuilder.Entity("Test_02.Models.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("Test_02.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Test_02.Models.DriverCompetition", b =>
                {
                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("DriverId", "CompetitionId");

                    b.HasIndex("CompetitionId");

                    b.ToTable("DriverCompetitions");
                });

            modelBuilder.Entity("Test_02.Models.Car", b =>
                {
                    b.HasOne("Test_02.Models.CarManufacturer", "CarManufacturer")
                        .WithMany("Cars")
                        .HasForeignKey("CarManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarManufacturer");
                });

            modelBuilder.Entity("Test_02.Models.Driver", b =>
                {
                    b.HasOne("Test_02.Models.Car", "Car")
                        .WithMany("Drivers")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("Test_02.Models.DriverCompetition", b =>
                {
                    b.HasOne("Test_02.Models.Competition", "Competition")
                        .WithMany("DriverCompetitions")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_02.Models.Driver", "Driver")
                        .WithMany("DriverCompetitions")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Test_02.Models.Car", b =>
                {
                    b.Navigation("Drivers");
                });

            modelBuilder.Entity("Test_02.Models.CarManufacturer", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Test_02.Models.Competition", b =>
                {
                    b.Navigation("DriverCompetitions");
                });

            modelBuilder.Entity("Test_02.Models.Driver", b =>
                {
                    b.Navigation("DriverCompetitions");
                });
#pragma warning restore 612, 618
        }
    }
}

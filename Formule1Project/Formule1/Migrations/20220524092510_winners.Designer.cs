﻿// <auto-generated />
using System;
using F1MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace F1MVC.Migrations
{
    [DbContext(typeof(Formule1Context))]
    [Migration("20220524092510_winners")]
    partial class winners
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("F1Lib.Models.Circuit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .HasColumnType("char(2)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Wiki")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CountryCode");

                    b.ToTable("Circuit");
                });

            modelBuilder.Entity("F1Lib.Models.Country", b =>
                {
                    b.Property<string>("CountryCode")
                        .HasMaxLength(2)
                        .HasColumnType("char(2)");

                    b.Property<string>("Code3")
                        .HasMaxLength(3)
                        .HasColumnType("char(3)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CountryNumber")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("FlagUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CountryCode");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("F1Lib.Models.Driver", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CountryCode")
                        .HasColumnType("char(2)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("char(1)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Wiki")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("CountryCode");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("F1Lib.Models.Grandprix", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .HasColumnType("char(2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Wiki")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("CountryCode");

                    b.ToTable("Grandprix");
                });

            modelBuilder.Entity("F1Lib.Models.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CircuitID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DriverID")
                        .HasColumnType("int");

                    b.Property<int?>("GrandprixID")
                        .HasColumnType("int");

                    b.Property<byte>("Racenumber")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Rounds")
                        .HasColumnType("tinyint");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CircuitID");

                    b.HasIndex("DriverID");

                    b.HasIndex("GrandprixID");

                    b.HasIndex("TeamID");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("F1Lib.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .HasColumnType("char(2)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Wiki")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.HasIndex("CountryCode");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("F1Lib.Models.YearDistinct", b =>
                {
                    b.Property<int>("Years")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Years"), 1L, 1);

                    b.Property<int>("Totalraces")
                        .HasColumnType("int");

                    b.HasKey("Years");

                    b.ToTable("YearDistinct");
                });

            modelBuilder.Entity("F1Lib.Models.Circuit", b =>
                {
                    b.HasOne("F1Lib.Models.Country", "Country")
                        .WithMany("Circuits")
                        .HasForeignKey("CountryCode");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("F1Lib.Models.Driver", b =>
                {
                    b.HasOne("F1Lib.Models.Country", "Country")
                        .WithMany("Drivers")
                        .HasForeignKey("CountryCode");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("F1Lib.Models.Grandprix", b =>
                {
                    b.HasOne("F1Lib.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryCode");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("F1Lib.Models.Result", b =>
                {
                    b.HasOne("F1Lib.Models.Circuit", "Circuit")
                        .WithMany("Races")
                        .HasForeignKey("CircuitID");

                    b.HasOne("F1Lib.Models.Driver", "Driver")
                        .WithMany("Races")
                        .HasForeignKey("DriverID");

                    b.HasOne("F1Lib.Models.Grandprix", "Grandprix")
                        .WithMany("Races")
                        .HasForeignKey("GrandprixID");

                    b.HasOne("F1Lib.Models.Team", "Team")
                        .WithMany("Races")
                        .HasForeignKey("TeamID");

                    b.Navigation("Circuit");

                    b.Navigation("Driver");

                    b.Navigation("Grandprix");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("F1Lib.Models.Team", b =>
                {
                    b.HasOne("F1Lib.Models.Country", "Country")
                        .WithMany("Teams")
                        .HasForeignKey("CountryCode");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("F1Lib.Models.Circuit", b =>
                {
                    b.Navigation("Races");
                });

            modelBuilder.Entity("F1Lib.Models.Country", b =>
                {
                    b.Navigation("Circuits");

                    b.Navigation("Drivers");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("F1Lib.Models.Driver", b =>
                {
                    b.Navigation("Races");
                });

            modelBuilder.Entity("F1Lib.Models.Grandprix", b =>
                {
                    b.Navigation("Races");
                });

            modelBuilder.Entity("F1Lib.Models.Team", b =>
                {
                    b.Navigation("Races");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using AlSafar.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AlSafar.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AlSafar.Domain.Models.Client.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PassportId")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("TourId")
                        .HasColumnType("integer");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("TourId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Employee.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<int>("TourCompanyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TourCompanyId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Flight.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("FlightTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("GateNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Hotel.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("HotelName")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<int>("NumberOfStars")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Tour.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Destination")
                        .HasColumnType("text");

                    b.Property<decimal>("Duration")
                        .HasColumnType("numeric");

                    b.Property<int>("FlightId")
                        .HasColumnType("integer");

                    b.Property<int>("HotelId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("TourCompanyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("HotelId");

                    b.HasIndex("TourCompanyId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.TourCompany.TourCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TourCompanies");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Client.Client", b =>
                {
                    b.HasOne("AlSafar.Domain.Models.Tour.Tour", "Tour")
                        .WithMany("Clients")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Employee.Employee", b =>
                {
                    b.HasOne("AlSafar.Domain.Models.TourCompany.TourCompany", "TourCompany")
                        .WithMany("Employees")
                        .HasForeignKey("TourCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TourCompany");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Tour.Tour", b =>
                {
                    b.HasOne("AlSafar.Domain.Models.Flight.Flight", "Flight")
                        .WithMany("Tours")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlSafar.Domain.Models.Hotel.Hotel", "Hotel")
                        .WithMany("Tours")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlSafar.Domain.Models.TourCompany.TourCompany", "TourCompany")
                        .WithMany("Tours")
                        .HasForeignKey("TourCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Hotel");

                    b.Navigation("TourCompany");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Flight.Flight", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Hotel.Hotel", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.Tour.Tour", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("AlSafar.Domain.Models.TourCompany.TourCompany", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Tours");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using BrightwayBooking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BrightwayBooking.Migrations
{
    [DbContext(typeof(TripDbContext))]
    partial class TripDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("BrightwayBooking")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrightwayBooking.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyCode")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("CurrencyCode");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Country", "dbo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrencyCode = "SGD",
                            Name = "Singapore"
                        },
                        new
                        {
                            Id = 2,
                            CurrencyCode = "MYR",
                            Name = "Malaysia"
                        },
                        new
                        {
                            Id = 3,
                            CurrencyCode = "EUR",
                            Name = "Europe"
                        },
                        new
                        {
                            Id = 4,
                            CurrencyCode = "USD",
                            Name = "United States"
                        },
                        new
                        {
                            Id = 5,
                            CurrencyCode = "AUD",
                            Name = "Australian"
                        },
                        new
                        {
                            Id = 6,
                            CurrencyCode = "JPY",
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 7,
                            CurrencyCode = "CNH",
                            Name = "China"
                        },
                        new
                        {
                            Id = 8,
                            CurrencyCode = "CAD",
                            Name = "Canada"
                        },
                        new
                        {
                            Id = 9,
                            CurrencyCode = "INR",
                            Name = "India"
                        },
                        new
                        {
                            Id = 10,
                            CurrencyCode = "DKK",
                            Name = "Denmark"
                        },
                        new
                        {
                            Id = 11,
                            CurrencyCode = "GBP",
                            Name = "Great Britain"
                        },
                        new
                        {
                            Id = 12,
                            CurrencyCode = "RUB",
                            Name = "Russia"
                        },
                        new
                        {
                            Id = 13,
                            CurrencyCode = "NZD",
                            Name = "New Zealand"
                        },
                        new
                        {
                            Id = 14,
                            CurrencyCode = "MXN",
                            Name = "Mexico"
                        },
                        new
                        {
                            Id = 15,
                            CurrencyCode = "IDR",
                            Name = "Indonesia"
                        },
                        new
                        {
                            Id = 16,
                            CurrencyCode = "TWD",
                            Name = "Taiwan"
                        },
                        new
                        {
                            Id = 17,
                            CurrencyCode = "THB",
                            Name = "Thailand"
                        });
                });

            modelBuilder.Entity("BrightwayBooking.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountPerDay")
                        .HasColumnType("decimal(22,0)")
                        .HasColumnName("AmountPerDay");

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("CountryId");

                    b.Property<int>("Days")
                        .HasColumnType("int")
                        .HasColumnName("Days");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Email");

                    b.Property<Guid>("InvoiceNumber")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("InvoiceNumber");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("Name");

                    b.Property<decimal>("TotalTripAmount")
                        .HasColumnType("decimal(22,0)")
                        .HasColumnName("TotalTripAmount");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Invoice", "dbo");
                });

            modelBuilder.Entity("BrightwayBooking.Models.Invoice", b =>
                {
                    b.HasOne("BrightwayBooking.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}

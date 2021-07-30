using BrightwayBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace BrightwayBooking.Data
{
    public class TripDbContext : DbContext
    {
        public TripDbContext(): base()
        {

        }

        public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "BrightwayBooking");

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice", "dbo");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnName("InvoiceNumber")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryId")
                    .HasColumnType("int");

                entity.Property(e => e.Days)
                    .HasColumnName("Days")
                    .HasColumnType("int");

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("Email")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.AmountPerDay)
                    .HasColumnName("AmountPerDay")
                    .HasColumnType("decimal(22, 0)");

                entity.Property(e => e.TotalTripAmount)
                    .HasColumnName("TotalTripAmount")
                    .HasColumnType("decimal(22, 0)");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "dbo");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("CurrencyCode")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>().HasData(
                        new Country { Id = 1, Name = "Singapore", CurrencyCode = "SGD" },
                        new Country { Id = 2, Name = "Malaysia", CurrencyCode = "MYR" },
                        new Country { Id = 3, Name = "Europe", CurrencyCode = "EUR" },
                        new Country { Id = 4, Name = "United States", CurrencyCode = "USD" },
                        new Country { Id = 5, Name = "Australian", CurrencyCode = "AUD" },
                        new Country { Id = 6, Name = "Japan", CurrencyCode = "JPY" },
                        new Country { Id = 7, Name = "China", CurrencyCode = "CNH" },
                        new Country { Id = 8, Name = "Canada", CurrencyCode = "CAD" },
                        new Country { Id = 9, Name = "India", CurrencyCode = "INR" },
                        new Country { Id = 10, Name = "Denmark", CurrencyCode = "DKK" },
                        new Country { Id = 11, Name = "Great Britain", CurrencyCode = "GBP" },
                        new Country { Id = 12, Name = "Russia", CurrencyCode = "RUB" },
                        new Country { Id = 13, Name = "New Zealand", CurrencyCode = "NZD" },
                        new Country { Id = 14, Name = "Mexico", CurrencyCode = "MXN" },
                        new Country { Id = 15, Name = "Indonesia", CurrencyCode = "IDR" },
                        new Country { Id = 16, Name = "Taiwan", CurrencyCode = "TWD" },
                        new Country { Id = 17, Name = "Thailand", CurrencyCode = "THB" }
                );


            //OnModelCreatingPartial(modelBuilder);
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}

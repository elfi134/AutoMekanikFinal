using Microsoft.EntityFrameworkCore;
using AutoMekanik.Domain.Entities;
using System;

namespace AutoMekanik.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }

        // Override the OnModelCreating method to define relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define foreign key relationship between Booking and Car
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Car)  // A Booking has one Car
                .WithMany()           // Car can have many Bookings (if needed, adjust this as per your requirement)
                .HasForeignKey(b => b.CarId); // CarId is the foreign key in Booking

            // Define foreign key relationship between Booking and Mechanic
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Mechanic)  // A Booking has one Mechanic
                .WithMany()                // Mechanic can have many Bookings (if needed, adjust this as per your requirement)
                .HasForeignKey(b => b.MechanicId); // MechanicId is the foreign key in Booking
        }
    }
}

using AutoMekanik.Domain.Entities;
using AutoMekanik.Domain.IRepositories;
using AutoMekanik.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMekanik.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Add a new booking to the database
        public async Task<Booking> AddAsync(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        // Retrieve a booking by its ID with related Car and Mechanic data
        public async Task<Booking> GetByIdAsync(int id)
        {
            return await _context.Bookings
                .Include(b => b.Car)      // Include the Car entity
                .Include(b => b.Mechanic) // Include the Mechanic entity
                .FirstOrDefaultAsync(b => b.Id == id); // Get the first booking with the specified ID
        }

        // Retrieve all bookings with related Car and Mechanic data
        public async Task<IEnumerable<Booking>> GetAllAsync()
        {
            return await _context.Bookings
                .Include(b => b.Car)      // Include the Car entity
                .Include(b => b.Mechanic) // Include the Mechanic entity
                .ToListAsync();           // Fetch all bookings with their related data
        }

        // Update an existing booking
        public async Task<Booking> UpdateAsync(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        // Delete a booking by its ID
        public async Task<bool> DeleteAsync(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return false;
            }
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

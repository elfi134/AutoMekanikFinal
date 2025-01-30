using AutoMekanik.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMekanik.Domain.IServices;
namespace AutoMekanik.Domain.IServices
{
    public interface IBookingService
    {
        Task<Booking> CreateBookingAsync(Booking booking);
        Task<Booking> GetBookingByIdAsync(int id);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task<Booking> UpdateBookingAsync(int id, Booking booking);
        Task<bool> DeleteBookingAsync(int id);
    }


}

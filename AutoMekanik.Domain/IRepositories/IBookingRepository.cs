using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMekanik.Domain.Entities;

namespace AutoMekanik.Domain.IRepositories
{
    public interface IBookingRepository
    {
        Task<Booking> AddAsync(Booking booking);
        Task<Booking> GetByIdAsync(int id);
        Task<IEnumerable<Booking>> GetAllAsync();
        Task<Booking> UpdateAsync(Booking booking);
        Task<bool> DeleteAsync(int id);
    }
}

using AutoMekanik.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMekanik.Domain.IRepositories
{
    public interface ICarsRepository
    {
        Task<List<Car>> GetAllAsync();
        Task<Car> GetByIdAsync(int id);
        Task AddAsync(Car car);
        Task UpdateAsync(Car car);
        Task DeleteAsync(int id); // Add this method for deleting cars
    }
}
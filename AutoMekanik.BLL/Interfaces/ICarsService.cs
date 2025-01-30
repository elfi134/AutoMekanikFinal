using AutoMekanik.BLL.ResponseModels;
using AutoMekanik.BLL.RequestModels;
using AutoMekanik.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMekanik.BLL.Interfaces
{
    public interface ICarsService
    {
        Task UpdateCarAsync(Car car);              // Accept only a Car object
        Task<Car> GetCarByIdAsync(int id);
        Task<List<Car>> GetAllCarsAsync();         // Return List<Car> instead of IEnumerable<Car>
        Task AddCarAsync(Car car);
        Task DeleteCarAsync(int id);               // For deleting a car
    }
}
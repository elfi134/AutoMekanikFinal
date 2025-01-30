using AutoMekanik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMekanik.Domain.IServices
{

    public interface ICarsService
    {
        Task UpdateCarAsync(Car car);        // This is the missing method
        Task DeleteCarAsync(int id);         // This is the missing method
        Task<Car> GetCarByIdAsync(int id);
        Task<List<Car>> GetAllCarsAsync();
        Task AddCarAsync(Car car);
    }

}

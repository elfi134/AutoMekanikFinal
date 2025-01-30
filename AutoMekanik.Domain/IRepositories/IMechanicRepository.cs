using AutoMekanik.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMekanik.Domain.IRepositories
{
    public interface IMechanicRepository
    {
        Task<IEnumerable<Mechanic>> GetAllMechanics(); // Get all mechanics
        Task<Mechanic> GetMechanicByIdAsync(int id); // Get mechanic by ID
        Task AddMechanic(Mechanic mechanic); // Add new mechanic
        Task UpdateMechanic(Mechanic mechanic); // Update mechanic
        Task DeleteMechanic(int id); // Delete mechanic
    }
}

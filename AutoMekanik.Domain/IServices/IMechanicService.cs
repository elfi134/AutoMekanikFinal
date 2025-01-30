using AutoMekanik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMekanik.Domain.IServices
{
        public interface IMechanicService
        {
        Task<IEnumerable<Mechanic>> GetAllMechanics();
        Task<Mechanic> GetMechanicById(int id);
        Task CreateMechanic(Mechanic mechanic);  // Add this line
        Task UpdateMechanic(Mechanic mechanic);
        Task DeleteMechanic(int id);
    }
}

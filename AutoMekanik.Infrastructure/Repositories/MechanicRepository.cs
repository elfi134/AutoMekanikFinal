using AutoMekanik.Domain.Entities;
using AutoMekanik.Domain.IRepositories;
using AutoMekanik.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoMekanik.Infrastructure.Repositories
{
    public class MechanicRepository : IMechanicRepository
    {
        private readonly ApplicationDbContext _context;

        public MechanicRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mechanic>> GetAllMechanics()
        {
            return await _context.Mechanics.ToListAsync();  // Returns all mechanics
        }

        public async Task<Mechanic> GetMechanicByIdAsync(int id) // Corrected to async
        {
            return await _context.Mechanics.FindAsync(id);  // Fetches mechanic by ID asynchronously
        }

        public async Task AddMechanic(Mechanic mechanic)
        {
            await _context.Mechanics.AddAsync(mechanic);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMechanic(Mechanic mechanic)
        {
            _context.Mechanics.Update(mechanic);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMechanic(int id)
        {
            var mechanic = await _context.Mechanics.FindAsync(id);
            if (mechanic != null)
            {
                _context.Mechanics.Remove(mechanic);
                await _context.SaveChangesAsync();
            }
        }
    }
}

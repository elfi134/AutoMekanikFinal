using AutoMekanik.Domain.Entities;
using AutoMekanik.Domain.IRepositories;
using AutoMekanik.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AutoMekanik.Infrastructure.Repositories
{
    public class CarsRepository : ICarsRepository
    {
        private readonly ApplicationDbContext _context;

        public CarsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> GetAllAsync()
        {
            return await _context.Set<Car>().ToListAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _context.Set<Car>().FindAsync(id);
        }

        public async Task AddAsync(Car car)
        {
            await _context.Set<Car>().AddAsync(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Car car)
        {
            _context.Set<Car>().Update(car);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var car = await _context.Set<Car>().FindAsync(id);
            if (car != null)
            {
                _context.Set<Car>().Remove(car);
                await _context.SaveChangesAsync();
            }
        }
    }
}
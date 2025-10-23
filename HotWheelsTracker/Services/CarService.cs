using HotWheelsTracker.Data;
using HotWheelsTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HotWheelsTracker.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext _context;

        // Constructor injection of DbContext
        public CarService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Implementation of the interface method
        public IEnumerable<Car> GetAllCarsSortedByValue()
        {
            return _context.Cars.OrderByDescending(c => c.Value).ToList();
        }
    public async Task<List<Car>> GetCarsBySeriesAsync(string series)
        {
            return await _context.Cars
                .FromSqlInterpolated($"EXEC GetCarsBySeries {series}")
                .ToListAsync();
        }
    }
}
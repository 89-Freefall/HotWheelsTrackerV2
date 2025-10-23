using HotWheelsTracker.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HotWheelsTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
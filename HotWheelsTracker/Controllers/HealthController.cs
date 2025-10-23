using HotWheelsTracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotWheelsTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HealthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("/healthz")]
        public async Task<IActionResult> GetHealth()
        {
            try
            {
                // Check database connectivity
                await _context.Cars.FirstOrDefaultAsync();

                return Ok(new
                {
                    status = "Healthy",
                    dependencies = new
                    {
                        database = "Connected"
                    }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    status = "Unhealthy",
                    dependencies = new
                    {
                        database = "Failed"
                    },
                    message = ex.Message
                });
            }
        }
    }
}

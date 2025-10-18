using Microsoft.AspNetCore.Mvc;
using CarHub.Api.Data;
using CarHub.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarHub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CarHubContext _context;

        public CarController(CarHubContext context)
        {
            _context = context;
        }

        // GET: api/cars 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return Ok(cars);
        }

        // POST: api/cars
        [HttpPost]
        public async Task<ActionResult<Car>> AddCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCars), new { id = car.Id }, car);
        }
    }
}

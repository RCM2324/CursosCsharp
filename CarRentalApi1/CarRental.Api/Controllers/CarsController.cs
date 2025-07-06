using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Api.Data;
using CarRental.Api.Dto;
using CarRental.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CarsController(AppDbContext context)
        {
            _context = context;
        }
        private bool IsValidYear(int year)
        {
            int currentYear = DateTime.Now.Year;
            return year >= currentYear - 5;
        }
        private CarDto ToDto(Car car) => new CarDto
        {
            Id = car.Id,
            Brand = car.Brand,
            Model = car.Model,
            Price = car.Price,
            Year = car.Year
        };

        private Car ToEntity(CarDto dto) => new Car
        {
            Id = dto.Id,
            Brand = dto.Brand,
            Model = dto.Model,
            Price = dto.Price,
            Year = dto.Year
        };

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarDto>>> GetCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return cars.Select(ToDto).ToList();
        }

        // GET: api/cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarDto>> GetCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
                return NotFound();

            return ToDto(car);
        }

        // POST: api/cars
        [HttpPost]
        public async Task<ActionResult<CarDto>> CreateCar(CarDto carDto)
        {
            if (!IsValidYear(carDto.Year))
                return BadRequest("The car cannot be older than 5 years.");

            var car = ToEntity(carDto);
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            carDto.Id = car.Id;
            return CreatedAtAction(nameof(GetCar), new { id = car.Id }, carDto);
        }

        // PUT: api/cars/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar(int id, CarDto carDto)
        {
            if (id != carDto.Id)
                return BadRequest();

            if (!IsValidYear(carDto.Year))
                return BadRequest("The car cannot be older than 5 years.");

            var car = await _context.Cars.FindAsync(id);
            if (car == null)
                return NotFound();

            car.Brand = carDto.Brand;
            car.Model = carDto.Model;
            car.Price = carDto.Price;
            car.Year = carDto.Year;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car == null)
                return NotFound();

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
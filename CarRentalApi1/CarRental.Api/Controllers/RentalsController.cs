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
    public class RentalsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RentalsController(AppDbContext context)
        {
            _context = context;
        }

          [HttpPost]
        public async Task<IActionResult> CreateRental([FromBody] RentalDto rentalDto)
        {
            if (rentalDto.StartDate >= rentalDto.EndDate)
                return BadRequest("Invalid rental period.");

            var car = await _context.Cars.FindAsync(rentalDto.CarId);
            if (car == null)
                return NotFound("Car not found.");

            // Check availability
            bool isCarAvailable = !await _context.Rentals.AnyAsync(r =>
                r.CarId == rentalDto.CarId &&
                (
                    (rentalDto.StartDate >= r.StartDate && rentalDto.StartDate < r.EndDate) ||
                    (rentalDto.EndDate > r.StartDate && rentalDto.EndDate <= r.EndDate) ||
                    (rentalDto.StartDate <= r.StartDate && rentalDto.EndDate >= r.EndDate)
                ));

            if (!isCarAvailable)
                return Conflict("Car is not available for the selected period.");

            var totalDays = (rentalDto.EndDate - rentalDto.StartDate).Days;
            if (totalDays <= 0)
                return BadRequest("Rental must be at least one day.");

            var totalPrice = totalDays * car.Price;

            var rental = new Rental
            {
                UserId = rentalDto.UserId,
                CarId = rentalDto.CarId,
                StartDate = rentalDto.StartDate,
                EndDate = rentalDto.EndDate,
                Price = totalPrice
            };

            _context.Rentals.Add(rental);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                rental.Id,
                TotalPrice = totalPrice
            });
        }

    }
}
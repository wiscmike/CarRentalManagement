﻿using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    ////[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Bookings
        [HttpGet]
        public async Task<ActionResult> GetBookings()
        {
            var Bookings = await _unitOfWork.BookingsRepository.GetAll();

            if (Bookings != null && Bookings.Any())
            {
                return Ok(Bookings);
            }

            return NotFound("No Booking data found.");

        }

        // GET: /Bookings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var Booking = await _unitOfWork.BookingsRepository.Get(m => m.Id == id);

            if (Booking != null)
            {
                return Ok(Booking);
            }
            return NotFound($"Booking Id {id} not found.");

        }

        // PUT: /Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking Booking)
        {
            if (id != Booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.BookingsRepository.Update(Booking);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: /Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking Booking)
        {
            await _unitOfWork.BookingsRepository.Insert(Booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = Booking.Id }, Booking);
        }

        // DELETE: /Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var Booking = await _unitOfWork.BookingsRepository.Get(m => m.Id == id);

            if (Booking == null)
            {
                return NotFound();
            }
            await _unitOfWork.BookingsRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var Booking = await _unitOfWork.BookingsRepository.Get(m => m.Id == id);

            return Booking != null;
        }
    }
}

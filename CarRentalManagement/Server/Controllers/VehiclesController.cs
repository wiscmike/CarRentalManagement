using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VehiclesController(IUnitOfWork unitOfWork, 
                                    IWebHostEnvironment webHostEnvironment,
                                    IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: /Vehicles
        [HttpGet]
        public async Task<ActionResult> GetVehicles()
        {
            List<string> includes = new List<string> { "Make", "Model", "Color" };

            var Vehicles = await _unitOfWork.VehiclesRepository.GetAll(includes: includes);

            return Ok(Vehicles);
        }

        // GET: /Vehicles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicle(int id)
        {
            List<string> includes = new List<string> { "Make", "Model", "Color" };

            var Vehicle = await _unitOfWork.VehiclesRepository.Get(m => m.Id == id, includes: includes);

            if (Vehicle != null)
            {
                return Ok(Vehicle);
            }
            return NotFound($"Vehicle Id {id} not found.");
        }

        // GET: /Vehicles/5
        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetVehicleDetails(int id)
        {
            // List<string> includes = new List<string> { "Make", "Model", "Color" };

            //var Vehicle = await _unitOfWork.VehiclesRepository.Get(m => m.Id == id, includes: includes);

            var Vehicle = await _unitOfWork.VehiclesRepository.Get(m => m.Id == id, includes: v => v.Include(x => x.Make ).Include(x => x.Model).Include(x => x.Color));

            if (Vehicle != null)
            {
                return Ok(Vehicle);
            }
            return NotFound($"Vehicle Id {id} not found.");
        }
        // PUT: /Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle Vehicle)
        {
            if (id != Vehicle.Id)
            {
                return BadRequest();
            }


            if (Vehicle.VehicleImage != null)
            {
                Vehicle.VehicleImageName = CreateImageFile(Vehicle);
            }

            _unitOfWork.VehiclesRepository.Update(Vehicle);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
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

        // POST: /Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle Vehicle)
        {
            if (Vehicle.VehicleImage != null)
            {
                Vehicle.VehicleImageName = CreateImageFile(Vehicle);
            }

            await _unitOfWork.VehiclesRepository.Insert(Vehicle);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetVehicle", new { id = Vehicle.Id }, Vehicle);
        }

        // DELETE: /Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var Vehicle = await _unitOfWork.VehiclesRepository.Get(m => m.Id == id);

            if (Vehicle == null)
            {
                return NotFound();
            }
            await _unitOfWork.VehiclesRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            var Vehicle = await _unitOfWork.VehiclesRepository.Get(m => m.Id == id);

            return Vehicle != null;
        }

        private string CreateImageFile(Vehicle vehicle)
        {
            var url = _httpContextAccessor.HttpContext.Request.Host.Value;
            var path = $"{_webHostEnvironment.WebRootPath}\\uploads\\{vehicle.VehicleImageName}";

            try
            {
                var fileStream = System.IO.File.Create(path);
                fileStream.Write(vehicle.VehicleImage, 0, vehicle.VehicleImage.Length);
                fileStream.Close();
            }
            catch (Exception)
            {
                throw;
            }

            return $"https://{url}/uploads/{vehicle.VehicleImageName}";
        }
    }
}

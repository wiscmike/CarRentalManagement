using CarRentalManagement.Server.IRepository;
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
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<ActionResult> GetMakes()
        {
            var makes = await _unitOfWork.MakesRepository.GetAll();

            if (makes != null && makes.Any())
            {
                return Ok(makes);
            }
            
            return NotFound("No Make data found.");
            
        }

        // GET: /Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            var make = await _unitOfWork.MakesRepository.Get(m => m.Id == id);

            if (make != null)
            {
                return Ok(make);
            }
            return NotFound($"Make Id {id} not found.");
            
        }

        // PUT: /Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _unitOfWork.MakesRepository.Update(make);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id))
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

        // POST: /Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            await _unitOfWork.MakesRepository.Insert(make);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: /Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var make = await _unitOfWork.MakesRepository.Get(m => m.Id == id);

            if (make == null)
            {
                return NotFound();
            }
            await _unitOfWork.MakesRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var make = await _unitOfWork.MakesRepository.Get(m => m.Id == id);

            return make != null;
        }
    }
}

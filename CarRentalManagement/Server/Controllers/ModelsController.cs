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
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Models
        [HttpGet]
        public async Task<ActionResult> GetModels()
        {
            var Models = await _unitOfWork.ModelsRepository.GetAll();

            if (Models != null && Models.Any())
            {
                return Ok(Models);
            }

            return NotFound("No Model data found.");

        }

        // GET: /Models/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModel(int id)
        {
            var Model = await _unitOfWork.ModelsRepository.Get(m => m.Id == id);

            if (Model != null)
            {
                return Ok(Model);
            }
            return NotFound($"Model Id {id} not found.");

        }

        // PUT: /Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model Model)
        {
            if (id != Model.Id)
            {
                return BadRequest();
            }

            _unitOfWork.ModelsRepository.Update(Model);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelExists(id))
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

        // POST: /Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model Model)
        {
            await _unitOfWork.ModelsRepository.Insert(Model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetModel", new { id = Model.Id }, Model);
        }

        // DELETE: /Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var Model = await _unitOfWork.ModelsRepository.Get(m => m.Id == id);

            if (Model == null)
            {
                return NotFound();
            }
            await _unitOfWork.ModelsRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ModelExists(int id)
        {
            var Model = await _unitOfWork.ModelsRepository.Get(m => m.Id == id);

            return Model != null;
        }
    }
}

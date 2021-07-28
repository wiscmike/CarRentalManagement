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
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Customers
        [HttpGet]
        public async Task<ActionResult> GetCustomers()
        {
            var Customers = await _unitOfWork.CustomersRepository.GetAll();

            if (Customers != null && Customers.Any())
            {
                return Ok(Customers);
            }

            return NotFound("No Customer data found.");

        }

        // GET: /Customers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var Customer = await _unitOfWork.CustomersRepository.Get(m => m.Id == id);

            if (Customer != null)
            {
                return Ok(Customer);
            }
            return NotFound($"Customer Id {id} not found.");

        }

        // PUT: /Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer Customer)
        {
            if (id != Customer.Id)
            {
                return BadRequest();
            }

            _unitOfWork.CustomersRepository.Update(Customer);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
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

        // POST: /Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer Customer)
        {
            await _unitOfWork.CustomersRepository.Insert(Customer);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCustomer", new { id = Customer.Id }, Customer);
        }

        // DELETE: /Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var Customer = await _unitOfWork.CustomersRepository.Get(m => m.Id == id);

            if (Customer == null)
            {
                return NotFound();
            }
            await _unitOfWork.CustomersRepository.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            var Customer = await _unitOfWork.CustomersRepository.Get(m => m.Id == id);

            return Customer != null;
        }
    }
}

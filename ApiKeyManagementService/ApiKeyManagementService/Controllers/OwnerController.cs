using ApiKeyManagementService.Models;
using ApiKeyManagementService.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiKeyManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly OwnerService _ownerService;

        public OwnerController(OwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        // GET: api/Owner
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Owner>>> GetOwners()
        {
            var owners = await _ownerService.GetAllOwnersAsync();
            return Ok(owners);
        }

        // GET: api/Owner/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Owner>> GetOwner(int id)
        {
            var owner = await _ownerService.GetOwnerByIdAsync(id);

            if (owner == null)
                return NotFound();

            return Ok(owner);
        }

        // POST: api/Owner
        [HttpPost]
        public async Task<IActionResult> CreateOwner([FromBody] Owner owner)
        {
            if (owner == null || string.IsNullOrEmpty(owner.Name) || string.IsNullOrEmpty(owner.Type))
            {
                return BadRequest("Owner bilgileri eksik.");
            }

            await _ownerService.AddOwnerAsync(owner);
            return Ok(new { Message = "Owner başarıyla oluşturuldu.", Owner = owner });
        }

        // PUT: api/Owner/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOwner(int id, Owner owner)
        {
            var updatedOwner = await _ownerService.UpdateOwnerAsync(id, owner);
            if (updatedOwner == null)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/Owner/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwner(int id)
        {
            var success = await _ownerService.DeleteOwnerAsync(id);
            if (!success)
                return NotFound();

            return NoContent();
        }
    }
}

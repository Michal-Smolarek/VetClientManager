using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VetClientManager.Models;
using VetClientManager.Repositories;

namespace VetClientManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PetsController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetsController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        // GET: api/pets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPets()
        {
            var pets = await _petRepository.GetPetsAsync();
            return Ok(pets);
        }

        // GET: api/pets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetPet(int id)
        {
            var pet = await _petRepository.GetPetByIdAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            return Ok(pet);
        }

        // POST: api/pets
        [HttpPost]
        public async Task<ActionResult<Pet>> PostPet(Pet pet)
        {
            var petId = await _petRepository.AddPetAsync(pet);
            pet.Id = petId;
            return CreatedAtAction(nameof(GetPet), new { id = pet.Id }, pet);
        }

        // PUT: api/pets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPet(int id, Pet pet)
        {
            if (id != pet.Id)
            {
                return BadRequest();
            }

            var result = await _petRepository.UpdatePetAsync(pet);
            if (result == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/pets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePet(int id)
        {
            var result = await _petRepository.DeletePetAsync(id);
            if (result == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

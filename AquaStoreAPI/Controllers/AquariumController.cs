using AquaStoreAPI.Models;
using AquaStoreAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AquariumController : ControllerBase
    {
        private readonly IAquariumRepository _aquariumRepository;
        public AquariumController(IAquariumRepository aquariumRepository)
        {
            this._aquariumRepository = aquariumRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Aquarium>> GetAquarium()
        {
            return await _aquariumRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aquarium>> GetAquarium(int id)
        {
            return await _aquariumRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Aquarium>> PostAquarium([FromBody] Aquarium aquarium)
        {
            var newAquarium = await _aquariumRepository.Create(aquarium);
            return CreatedAtAction(nameof(GetAquarium), new { id = newAquarium.AquariumID }, newAquarium);
        }

        [HttpPut]
        public async Task<ActionResult> PutAquarium(int id,[FromBody] Aquarium aquarium)
        {
            if(id != aquarium.AquariumID)
            {
                return BadRequest();
            }
            await _aquariumRepository.Update(aquarium);

            return NoContent();  
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletAquarium(int id)
        {
            var itemToDelete = await _aquariumRepository.Get(id);
            if (itemToDelete == null)
                return NotFound();

            await _aquariumRepository.Delete(itemToDelete.AquariumID);
            return NoContent();
        }

    }

    


}

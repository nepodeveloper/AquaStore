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
    public class FishController : ControllerBase
    {
        private readonly IFishRepository _fishRepository;

        public FishController(IFishRepository  fishRepository)
        {
            this._fishRepository = fishRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Fish>> GetFish()
        {
            return await _fishRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fish>> GetFish(int id)
        {
            return await _fishRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Fish>> PostFish([FromBody] Fish fish)
        {
            var newFish = await _fishRepository.Create(fish);
            return CreatedAtAction(nameof(GetFish), new { id = newFish.FishID }, newFish);
        }

        [HttpPut]
        public async Task<ActionResult> PutFish(int id, [FromBody] Fish fish)
        {
            if (id != fish.FishID)
            {
                return BadRequest();
            }
            await _fishRepository.Update(fish);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletFish(int id)
        {
            var itemToDelete = await _fishRepository.Get(id);
            if (itemToDelete == null)
                return NotFound();

            await _fishRepository.Delete(itemToDelete.FishID);
            return NoContent();
        }

    }

}

using AquaStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Repositories
{
    public class FishRepository : IFishRepository
    {
        private readonly AquaStoreDBContext _context;
        public FishRepository(AquaStoreDBContext context)
        {
            _context = context;
        }

        public async Task<Fish> Create(Fish fish)
        {
            _context.Fish.Add(fish);
            await _context.SaveChangesAsync();
            return fish;
        }

        public async Task Delete(int id)
        {
            var fishToDelete = await _context.Fish.FindAsync(id);
            _context.Fish.Remove(fishToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Fish>> Get()
        {
            return await _context.Fish.ToListAsync();
        }

        public async Task<Fish> Get(int id)
        {
            return await _context.Fish.FindAsync(id);
        }

        public async Task Update(Fish fish)
        {
            _context.Entry(fish).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

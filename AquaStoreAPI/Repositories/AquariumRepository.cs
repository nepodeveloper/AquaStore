using AquaStoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Repositories
{
    public class AquariumRepository : IAquariumRepository
    {
        private readonly AquaStoreDBContext _context;

        public AquariumRepository(AquaStoreDBContext context)
        {
            _context = context;
        }

        public async Task<Aquarium> Create(Aquarium aquarium)
        {
            _context.Aquaria.Add(aquarium);
            await _context.SaveChangesAsync();
            return aquarium;
        }

        public async Task Delete(int id)
        {
            var AquariaToDelete = await _context.Aquaria.FindAsync(id);
            _context.Aquaria.Remove(AquariaToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Aquarium>> Get()
        {
            return await _context.Aquaria.ToListAsync();
        }

        public async Task<Aquarium> Get(int id)
        {
            return await _context.Aquaria.FindAsync(id);
        }

        public async Task Update(Aquarium aquarium)
        {
            _context.Entry(aquarium).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

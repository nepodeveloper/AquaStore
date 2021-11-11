using AquaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Repositories
{
    public interface IAquariumRepository
    {
        Task<IEnumerable<Aquarium>> Get();
        Task<Aquarium> Get(int id);
        Task<Aquarium> Create(Aquarium aquarium);
        Task Update(Aquarium aquarium);
        Task Delete(int id);
    }
}

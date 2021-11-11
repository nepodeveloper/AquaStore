using AquaStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Repositories
{
    public interface IFishRepository
    {
        Task<IEnumerable<Fish>> Get();
        Task<Fish> Get(int id);
        Task<Fish> Create(Fish fish);
        Task Update(Fish fish);
        Task Delete(int id);
    }
}

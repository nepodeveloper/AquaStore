using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Models
{
    public class AquaStoreDBContext : DbContext
    {
        public AquaStoreDBContext(DbContextOptions<AquaStoreDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Fish> Fish { get; set; }

        public DbSet<Aquarium> Aquaria { get; set; }
    }
}

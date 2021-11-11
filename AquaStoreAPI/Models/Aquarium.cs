using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Models
{
    public class Aquarium
    {
        public int AquariumID { get; set; }

        public string GlassType { get; set; }

        public int Size { get; set; }

        public string Shape { get; set; }

    }
}

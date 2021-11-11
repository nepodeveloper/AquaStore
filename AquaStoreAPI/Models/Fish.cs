using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStoreAPI.Models
{
    public class Fish
    {
        
        public int FishID { get; set; }

        public string Species { get; set; }

        public string Color { get; set; }

        public int Fins { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStore.Models
{
    public class Aquarium
    {
        [Key]
        public int AquariumlId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string GlassType { get; set; }

        public int Size { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Shape { get; set; }

        //Foregien Key Constrain
        public int FishlId { get; set; }
        public Fish Fish { get; set; }

    }
}

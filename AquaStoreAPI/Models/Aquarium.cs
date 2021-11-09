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
        [Key]
        public int AquariumID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string GlassType { get; set; }

        public decimal Size { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Shape { get; set; }

        //Foreign Key
        public int FishID { get; set; }
        public Fish Fish { get; set; }


    }
}

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
        [Key]
        public int FishID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Species { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Color { get; set; }

        public int Fins { get; set; }

    }
}

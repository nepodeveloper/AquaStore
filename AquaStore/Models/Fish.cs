using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AquaStore.Models
{
    public class Fish
    {
        [Key]
        public int FishlId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Species { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Color { get; set; }

        public int Fins { get; set; }



    }
}

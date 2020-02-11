using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2019113001.Data.Entites
{
    public class ProductVariant
    {
        public int ProductId { get; set; }
        public int ColourId { get; set; }
        public int StorageId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Product Product { get; set; }
        public Colour Colour { get; set; }
        public Storage Storage { get; set; }

    }
}

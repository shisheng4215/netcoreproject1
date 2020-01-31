using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Data.Entites
{
    public class Colour
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
    }
}

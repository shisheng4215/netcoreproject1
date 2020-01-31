using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2019113001.Data.Entites
{
    public class Feature
    {
        public int Id { get; set; }
        
        [Required]
        public string  Name { get; set; }

        public List<ProductFeature> ProductFeature { get; set; } = new List<ProductFeature>();
    }
}

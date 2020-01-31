using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Data.Entites
{
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();

    }
}

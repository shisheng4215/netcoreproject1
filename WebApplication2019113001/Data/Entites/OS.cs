using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2019113001.Data.Entites
{
    public class OS
    {
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        public List<Product> Products = new List<Product>();
    }
}

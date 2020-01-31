using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2019113001.Data.Entites
{
    public class ProductFeature
    {
        public int ProductId { get; set; }
        public int FeatureId { get; set; }
        public Product Product { get; set; }
        public Feature Feature { get; set; }
    }
}

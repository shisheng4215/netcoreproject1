using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Features.Products
{
    public class CreateProductViewModel
    {
        public string  Name { get; set; }
        public string  ShortDescription { get; set; }
        public string  Description { get; set; }
        public Decimal TalkTime { get; set; }
        public decimal StandbyTime { get; set; }
        public decimal ScreenSize { get; set; }
        public string  Brand { get; set; }
        public String OS { get; set; }

        public List<string> Features { get; set; }
        public List<CreateProductVariantViewModel> Variants { get; set; }
    }
}

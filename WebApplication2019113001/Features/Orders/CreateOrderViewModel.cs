using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Features.Orders
{
    public class CreateOrderViewModel
    {
        [Required]
        public string  StripeToken { get; set; }

        [Required]
        public string  FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        [Required]
        public string TownCity { get; set; }

        [Required]
        public string County { get; set; }

        [Required]
        public string Postcode { get; set; }

        public List<OrderItemViewModel> Items { get; set; }
    }
}

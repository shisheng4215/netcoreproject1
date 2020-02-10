using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Features.Orders
{
    public class OrderListViewModel
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime Placed { get; set; }
        public int Items { get; set; }
        public decimal Total { get; set; }
        public string PaymentStatus { get; set; }
    }
}

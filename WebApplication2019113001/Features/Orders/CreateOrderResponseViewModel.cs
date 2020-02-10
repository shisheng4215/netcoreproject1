using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2019113001.Data.Entites;

namespace WebApplication2019113001.Features.Orders
{
    public class CreateOrderResponseViewModel
    {
        public int OrderId { get; set; }
        public string PaymentStatus { get; set; }

        public CreateOrderResponseViewModel(int orderId,PaymentStatus paymentStatus)
        {
            this.OrderId = orderId;
            this.PaymentStatus = paymentStatus.ToString();
        }
    }
}

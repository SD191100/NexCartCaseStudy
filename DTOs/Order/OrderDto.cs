using NexCart.DTOs.Order;
using System;
using System.Collections.Generic;

namespace NexCart.DTOs.Order
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}

using NexCart.DTOs;
using NexCart.DTOs.Order;

namespace NexCart.Services.Interfaces
{
    public interface IOrderService
    {
        OrderDto GetOrderById(int orderId);
        IEnumerable<OrderDto> GetOrdersByUserId(int userId);
        void PlaceOrder(CreateOrderDto createOrderDto);
    }
}
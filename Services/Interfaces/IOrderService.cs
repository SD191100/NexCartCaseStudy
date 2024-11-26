using NexCart.Models;

namespace NexCart.Services.Interfaces
{
    public interface IOrderService
    {
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetOrdersByUserId(int userId);
        void PlaceOrder(Order order);
    }
}

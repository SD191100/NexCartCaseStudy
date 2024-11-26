using NexCart.Models;

namespace NexCart.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetOrdersByUserId(int userId);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
    }
}

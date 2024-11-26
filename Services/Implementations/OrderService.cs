using NexCart.Models;
using NexCart.Repositories.Interfaces;
using NexCart.Services.Interfaces;

namespace NexCart.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Order GetOrderById(int orderId)
        {
            return _orderRepository.GetOrderById(orderId);
        }

        public IEnumerable<Order> GetOrdersByUserId(int userId)
        {
            return _orderRepository.GetOrdersByUserId(userId);
        }

        public void PlaceOrder(Order order)
        {
            _orderRepository.AddOrder(order);
        }
    }
}

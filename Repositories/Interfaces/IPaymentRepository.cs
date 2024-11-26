using NexCart.Models;

namespace NexCart.Repositories.Interfaces
{
    public interface IPaymentRepository
    {
        Payment GetPaymentById(int paymentId);
        IEnumerable<Payment> GetPaymentsByOrderId(int orderId);
        void AddPayment(Payment payment);
    }
}

using NexCart.Models;

namespace NexCart.Services.Interfaces
{
    public interface IPaymentService
    {
        Payment GetPaymentById(int paymentId);
        IEnumerable<Payment> GetPaymentsByOrderId(int orderId);
        void AddPayment(Payment payment);
    }
}

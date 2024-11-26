using NexCart.Models;
using NexCart.Repositories.Interfaces;
using NexCart.Services.Interfaces;

namespace NexCart.Services.Implementations
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public Payment GetPaymentById(int paymentId)
        {
            return _paymentRepository.GetPaymentById(paymentId);
        }

        public IEnumerable<Payment> GetPaymentsByOrderId(int orderId)
        {
            return _paymentRepository.GetPaymentsByOrderId(orderId);
        }

        public void AddPayment(Payment payment)
        {
            _paymentRepository.AddPayment(payment);
        }
    }
}

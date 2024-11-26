using NexCart.Data;
using NexCart.Models;
using NexCart.Repositories.Interfaces;

namespace NexCart.Repositories.Implementations
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly NexCartDBContext _context;

        public PaymentRepository(NexCartDBContext context)
        {
            _context = context;
        }

        public Payment GetPaymentById(int paymentId)
        {
            return _context.Payments.FirstOrDefault(p => p.PaymentId == paymentId);
        }

        public IEnumerable<Payment> GetPaymentsByOrderId(int orderId)
        {
            return _context.Payments.Where(p => p.OrderId == orderId).ToList();
        }

        public void AddPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NexCart.Data;
using NexCart.Models;
using NexCart.Repositories.Interfaces;

namespace NexCart.Repositories.Implementations
{
    public class CartRepository : ICartRepository
    {
        private readonly NexCartDBContext _context;

        public CartRepository(NexCartDBContext context)
        {
            _context = context;
        }

        public Cart GetCartByUserId(int userId)
        {
            return _context.Carts.Include(c => c.CartItems).FirstOrDefault(c => c.UserId == userId);
        }

        public void AddToCart(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
            _context.SaveChanges();
        }

        public void RemoveFromCart(int cartItemId)
        {
            var cartItem = _context.CartItems.Find(cartItemId);
            if (cartItem != null)
            {
                _context.CartItems.Remove(cartItem);
                _context.SaveChanges();
            }
        }

        public void ClearCart(int userId)
        {
            var cart = GetCartByUserId(userId);
            if (cart != null)
            {
                _context.CartItems.RemoveRange(cart.CartItems);
                _context.SaveChanges();
            }
        }
    }
}

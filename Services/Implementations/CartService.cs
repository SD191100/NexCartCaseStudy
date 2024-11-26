using NexCart.Models;
using NexCart.Repositories.Interfaces;
using NexCart.Services.Interfaces;

namespace NexCart.Services.Implementations
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public Cart GetCartByUserId(int userId)
        {
            return _cartRepository.GetCartByUserId(userId);
        }

        public void AddToCart(CartItem cartItem)
        {
            _cartRepository.AddToCart(cartItem);
        }

        public void RemoveFromCart(int cartItemId)
        {
            _cartRepository.RemoveFromCart(cartItemId);
        }

        public void ClearCart(int userId)
        {
            _cartRepository.ClearCart(userId);
        }
    }
}

using NexCart.Models;

namespace NexCart.Services.Interfaces
{
    public interface ICartService
    {
        Cart GetCartByUserId(int userId);
        void AddToCart(CartItem cartItem);
        void RemoveFromCart(int cartItemId);
        void ClearCart(int userId);
    }
}

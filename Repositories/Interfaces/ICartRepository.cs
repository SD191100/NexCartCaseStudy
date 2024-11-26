using NexCart.Models;

namespace NexCart.Repositories.Interfaces
{
    public interface ICartRepository
    {
        Cart GetCartByUserId(int userId);
        void AddToCart(CartItem cartItem);
        void RemoveFromCart(int cartItemId);
        void ClearCart(int userId);
    }
}

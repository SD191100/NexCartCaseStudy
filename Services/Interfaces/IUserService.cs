using NexCart.Models;

namespace NexCart.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserById(int userId);
        User GetUserByEmail(string email);
        void RegisterUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
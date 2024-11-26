using NexCart.Models;

namespace NexCart.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        void Add(User user);
        User GetUserById(int userId);
        void Update(User user);
        void Delete(int userId);
    }
}

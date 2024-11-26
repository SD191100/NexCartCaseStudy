using Microsoft.EntityFrameworkCore;
using NexCart.Data;
using NexCart.Models;
using NexCart.Repositories.Interfaces;

namespace NexCart.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly NexCartDBContext _context;

        public UserRepository(NexCartDBContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == userId);
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int userId)
        {
            var user = GetUserById(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}

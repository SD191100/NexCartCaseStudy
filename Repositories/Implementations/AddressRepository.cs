using NexCart.Data;
using NexCart.Models;
using NexCart.Repositories.Interfaces;

namespace NexCart.Repositories.Implementations
{
    public class AddressRepository : IAddressRepository
    {
        private readonly NexCartDBContext _context;

        public AddressRepository(NexCartDBContext context)
        {
            _context = context;
        }

        public Address GetAddressById(int addressId)
        {
            return _context.Addresses.FirstOrDefault(a => a.AddressId == addressId);
        }

        public IEnumerable<Address> GetAddressesByUserId(int userId)
        {
            return _context.Addresses.Where(a => a.UserId == userId).ToList();
        }

        public void AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void UpdateAddress(Address address)
        {
            _context.Addresses.Update(address);
            _context.SaveChanges();
        }

        public void DeleteAddress(int addressId)
        {
            var address = GetAddressById(addressId);
            if (address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
            }
        }
    }
}

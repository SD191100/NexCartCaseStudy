using NexCart.Models;

namespace NexCart.Repositories.Interfaces
{
    public interface IAddressRepository
    {
        Address GetAddressById(int addressId);
        IEnumerable<Address> GetAddressesByUserId(int userId);
        void AddAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(int addressId);
    }
}

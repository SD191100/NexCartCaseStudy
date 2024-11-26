using NexCart.Models;

namespace NexCart.Services.Interfaces
{
    public interface IAddressService
    {
        Address GetAddressById(int addressId);
        IEnumerable<Address> GetAddressesByUserId(int userId);
        void AddAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(int addressId);
    }
}

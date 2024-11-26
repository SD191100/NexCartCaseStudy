using NexCart.Models;
using NexCart.Repositories.Interfaces;
using NexCart.Services.Interfaces;

namespace NexCart.Services.Implementations
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public Address GetAddressById(int addressId)
        {
            return _addressRepository.GetAddressById(addressId);
        }

        public IEnumerable<Address> GetAddressesByUserId(int userId)
        {
            return _addressRepository.GetAddressesByUserId(userId);
        }

        public void AddAddress(Address address)
        {
            _addressRepository.AddAddress(address);
        }

        public void UpdateAddress(Address address)
        {
            _addressRepository.UpdateAddress(address);
        }

        public void DeleteAddress(int addressId)
        {
            _addressRepository.DeleteAddress(addressId);
        }
    }
}

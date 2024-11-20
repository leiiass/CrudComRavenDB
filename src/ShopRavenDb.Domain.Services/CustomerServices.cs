using ShopRavenDb.Domain.Core.Interfaces.Repositories;
using ShopRavenDb.Domain.Core.Interfaces.Services;
using ShopRavenDb.Domain.Model;

namespace ShopRavenDb.Domain.Services
{
    public class CustomerServices : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void AddCustomer(Customer customer)
        {
            customer.Address.IsActive = true;
            customer.IsActive = true;
            _customerRepository.AddCustomer(customer);
        }

        public void DeleteCustomer(string id)
        {
            _customerRepository.DeleteCustomer(id);
        }

        public Customer GetCustomerById(string id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository.UpdateCustomer(customer);
        }
    }
}

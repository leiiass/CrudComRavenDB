using ShopRavenDb.Application.Dtos;

namespace ShopRavenDb.Application.Interfaces
{
    public interface ICustomerApplication
    {
        void AddCustomer(CustomerDto customer);
        void UpdateCustomer(CustomerDto customer);
        void DeleteCustomer(string id);
        IEnumerable<CustomerDto> GetCustomers();
        CustomerDto GetCustomerById(string id);
    }
}

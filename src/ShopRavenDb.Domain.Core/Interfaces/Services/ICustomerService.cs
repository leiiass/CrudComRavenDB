﻿using ShopRavenDb.Domain.Model;

namespace ShopRavenDb.Domain.Core.Interfaces.Services
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(string id);
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(string id);
    }
}

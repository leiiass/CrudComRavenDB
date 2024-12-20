﻿using AutoMapper;
using ShopRavenDb.Application.Dtos;
using ShopRavenDb.Application.Interfaces;
using ShopRavenDb.Domain.Core.Interfaces.Services;
using ShopRavenDb.Domain.Model;

namespace ShopRavenDb.Application
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerApplication(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        public void AddCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerService.AddCustomer(customer);
        }

        public void DeleteCustomer(string id)
        {
            _customerService.DeleteCustomer(id);
        }

        public CustomerDto GetCustomerById(string id)
        {
            var customer = _customerService.GetCustomerById(id);
            var customerDto = _mapper.Map<CustomerDto>(customer);
            return customerDto;
        }

        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customers = _customerService.GetCustomers();
            var customersDto = _mapper.Map<IEnumerable<CustomerDto>>(customers);
            return customersDto;
        }

        public void UpdateCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerService.UpdateCustomer(customer);
        }
    }
}

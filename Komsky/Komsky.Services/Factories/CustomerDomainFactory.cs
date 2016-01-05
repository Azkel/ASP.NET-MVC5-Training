using Komsky.Data.Entities;
using Komsky.Domain.Models;

namespace Komsky.Domain.Factories
{
    public static class CustomerDomainFactory
    {
        public static CustomerDomain Create(Customer customer)
        {
            return new CustomerDomain
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                PIN = customer.PIN
            };
        }

        public static CustomerDomain CreateCustomerDomain(this Customer customer)
        {
            return Create(customer);
        }
    }
}

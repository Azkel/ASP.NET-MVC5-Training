using Komsky.Data.Entities;
using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komsky.Domain.Factories
{
    public static class CustomerFactory
    {
        public static Customer Create(CustomerDomain customerDomain)
        {
            return new Customer
            {
                Id = customerDomain.Id,
                Name = customerDomain.Name,
                Email = customerDomain.Email,
                Phone = customerDomain.Phone,
                PIN = customerDomain.PIN
                //Products = customerDomain.Products.GetAll().Select(ProductFactory.Create);
            };
        }

        public static Customer CreateCustomer(this CustomerDomain customerDomain)
        {
            return Create(customerDomain);
        }
    }
}

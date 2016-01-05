using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komsky.Web.Models.Factories
{
    public static class CustomerViewModelFactory
    {
        public static CustomerViewModel Create(CustomerDomain customerDomain)
        {
            return new CustomerViewModel
            {
                Id = customerDomain.Id,
                Name = customerDomain.Name
            };
        }

        public static CustomerViewModel CreateCustomerViewModel(this CustomerDomain customerDomain)
        {
            return Create(customerDomain);
        }
    }
}
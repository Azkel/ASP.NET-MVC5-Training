using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komsky.Web.Models.Factories
{
    public static class CustomerDomainFactory
    {
        public static CustomerDomain Create(CustomerViewModel customerViewModel)
        {
            return new CustomerDomain
            {
                Id = customerViewModel.Id,
                Name = customerViewModel.Name
            };
        }

        public static CustomerDomain CreateCustomerDomain(this CustomerViewModel customerViewModel)
        {
            return Create(customerViewModel);
        }
    }
}
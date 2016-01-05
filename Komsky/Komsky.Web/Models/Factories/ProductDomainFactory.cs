using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komsky.Web.Models.Factories
{
    public static class ProductDomainFactory
    {
        public static ProductDomain Create(ProductViewModel productViewModel)
        {
            return new ProductDomain
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                ReleaseDate = productViewModel.ReleaseDate,
                Type = productViewModel.Type,
                Customer = CustomerDomainFactory.Create(productViewModel.Customer)
            };
        }

        public static ProductDomain CreateCustomerDomain(this ProductViewModel productViewModel)
        {
            return Create(productViewModel);
        }
    }
}
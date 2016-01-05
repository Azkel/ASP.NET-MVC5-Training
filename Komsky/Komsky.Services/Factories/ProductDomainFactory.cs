using Komsky.Data.Entities;
using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komsky.Domain.Factories
{
    public static class ProductDomainFactory
    {
        public static ProductDomain Create(Product product)
        {
            return new ProductDomain
            {
                Type = product.Type,
                ReleaseDate = product.ReleaseDate,
                Id = product.Id,
                Name = product.Name,
                Customer = CustomerDomainFactory.Create(product.Customer)
            };
        }

        public static ProductDomain CreateProductDomain(this Product product)
        {
            return Create(product);
        }
    }
}

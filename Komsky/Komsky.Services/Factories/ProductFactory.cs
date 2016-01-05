using Komsky.Data.Entities;
using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komsky.Domain.Factories
{
    public static class ProductFactory
    {
        public static Product Create(ProductDomain productDomain)
        {
            return new Product
            {
                Id = productDomain.Id,
                ReleaseDate = productDomain.ReleaseDate,
                Name = productDomain.Name,
                Type = productDomain.Type,
                Customer = CustomerFactory.CreateCustomer(productDomain.Customer)
            };
        }

        public static Product CreateProduct(this ProductDomain productDomain)
        {
            return Create(productDomain);
        }
    }
}

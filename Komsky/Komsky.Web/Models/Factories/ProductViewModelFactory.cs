using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komsky.Web.Models.Factories
{
    public static class ProductViewModelFactory
    {
        public static ProductViewModel Create(ProductDomain productViewModel)
        {
            return new ProductViewModel
            {
                Id = productViewModel.Id,
                Name = productViewModel.Name,
                ReleaseDate = productViewModel.ReleaseDate,
                Type = productViewModel.Type,
                Customer = CustomerViewModelFactory.Create(productViewModel.Customer)
            };
        }

        public static ProductViewModel CreateProductViewModel(this ProductDomain productViewModel)
        {
            return Create(productViewModel);
        }
    }
}
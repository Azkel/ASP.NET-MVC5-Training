using Komsky.Domain.Factories;
using Komsky.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komsky.Services.Handlers
{
    public class ProductHandler : BaseHandler<ProductDomain>
    {
        public override void Add(ProductDomain domainObject)
        {

            _dataSource.Products.Add(domainObject.CreateProduct());
        }

        public override void Delete(ProductDomain domainObject)
        {
            _dataSource.Products.Delete(domainObject.CreateProduct());
        }

        public override void Delete(int domainObjectId)
        {
            _dataSource.Products.Delete(domainObjectId);
        }

        public override IEnumerable<ProductDomain> GetAll()
        {
            return _dataSource.Products.GetAll().Select(ProductDomainFactory.Create);
        }

        public override ProductDomain GetById(int id)
        {
            return _dataSource.Products.GetById(id).CreateProductDomain();
        }

        public override void Update(ProductDomain domainObject)
        {
            _dataSource.Products.Update(domainObject.CreateProduct());
        }
    }
}

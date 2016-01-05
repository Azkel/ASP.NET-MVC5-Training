using Komsky.Domain.Factories;
using Komsky.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Komsky.Services.Handlers
{
    public class CustomerHandler : BaseHandler<CustomerDomain>
    {
        public override void Add(CustomerDomain domainObject)
        {

            _dataSource.Customers.Add(domainObject.CreateCustomer());
        }

        public override void Delete(CustomerDomain domainObject)
        {
            _dataSource.Customers.Delete(domainObject.CreateCustomer());
        }

        public override void Delete(int domainObjectId)
        {
            _dataSource.Customers.Delete(domainObjectId);
        }

        public override IEnumerable<CustomerDomain> GetAll()
        {
            return _dataSource.Customers.GetAll().Select(CustomerDomainFactory.Create);
        }

        public override CustomerDomain GetById(int id)
        {
            return _dataSource.Customers.GetById(id).CreateCustomerDomain();
        }

        public override void Update(CustomerDomain domainObject)
        {
            _dataSource.Customers.Update(domainObject.CreateCustomer());
        }
    }
}

using Komsky.Data.Entities;
using System.Data.Entity;

namespace Komsky.Data.DataAccess.Repositories
{
    public class CustomerRepository: GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext) : base (dbContext)
        {

        }
    }
}

using Komsky.Data.Entities;
using Komsky.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komsky.Data.DataAccess.Repositories
{
    public interface IProductRepository: IRepository<Product>
    {
    }
}

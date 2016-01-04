using Komsky.Data.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komsky.Data.DataAccess.UnitOfWork
{
    public interface IDataFacade: IDisposable
    {
        void Commit();
        Task CommitAsync();
        ApplicationUserRepository ApplicationUsers { get; }
    }
}

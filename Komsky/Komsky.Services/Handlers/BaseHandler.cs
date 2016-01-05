using Komsky.Data.DataAccess.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Komsky.Services.Handlers
{
    public abstract class BaseHandler<T> : IBaseHandler<T>
    {
        protected IDataFacade _dataSource;

        public BaseHandler(IDataFacade dataSource)
        {
            _dataSource = dataSource;
        }

        public BaseHandler()
        {
            _dataSource = new DataFacade(new Data.Entities.ApplicationDbContext());
        }

        public abstract void Add(T domainObject);

        public void Commit()
        {
            _dataSource.Commit();
        }

        public Task CommitAsync()
        {
            return _dataSource.CommitAsync();
        }

        public abstract void Delete(int domainObjectId);

        public abstract void Delete(T domainObject);

        public abstract IEnumerable<T> GetAll();

        public abstract T GetById(int id);

        public abstract void Update(T domainObject);

        public void Dispose()
        {
            _dataSource.Dispose();
        }
    }
}

using System;
using System.Threading.Tasks;
using Komsky.Data.DataAccess.Repositories;
using Komsky.Data.Entities;

namespace Komsky.Data.DataAccess.UnitOfWork
{
    public class DataFacade : IDataFacade
    {
        #region Fields
        private ApplicationDbContext _dbContext;
        private ApplicationUserRepository _applicationUsers;
        private CustomerRepository _customerRepository;
        private ProductRepository _productRepository;
        #endregion

        #region Constructors
        public DataFacade(ApplicationDbContext dbContext)
        {
            CreateDbContext(dbContext);
        }

        protected void CreateDbContext(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? new ApplicationDbContext();

            _dbContext.Configuration.ProxyCreationEnabled = false;
            _dbContext.Configuration.LazyLoadingEnabled = false;
            _dbContext.Configuration.ValidateOnSaveEnabled = false;
        }
        #endregion

        public ApplicationUserRepository ApplicationUsers
        {
            get
            {
                return _applicationUsers ?? (_applicationUsers = new ApplicationUserRepository(_dbContext));
            }
        }

        public CustomerRepository Customers
        {
            get
            {
                return _customerRepository ?? (_customerRepository = new CustomerRepository(_dbContext));
            }
        }

        public ProductRepository Products
        {
            get
            {
                return _productRepository ?? (_productRepository = new ProductRepository(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public Task CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        #region Dispose pattern
        private bool _disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if(disposing)
                {
                    _dbContext.Dispose();
                }
            }
            _disposed = true;
        }
        #endregion
    }
}

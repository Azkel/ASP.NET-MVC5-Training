using System;
using System.Linq;

namespace Komsky.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        T GetById(int id);

        T GetById(Guid id);

        T GetById(string id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        void Delete(Guid id);

        void Delete(string id);
    }
}

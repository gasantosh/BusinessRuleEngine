using System;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessRuleEngine.DAL.Repositories.Contracts
{
    public interface IRepository<T>
    {
        T GetByID(Guid id);

        IQueryable<T> GetAll();

        IQueryable<T> GetByFilter(Expression<Func<T, bool>> expression);

        void Add(T entity);

        void Add(T[] entities);

        void Update(T entity);

        void Update(T[] entities);

        void Remove(T entity);

        void Remove(T[] entities);

        void Save();
    }
}

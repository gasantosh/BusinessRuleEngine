using System;
using System.Linq;
using System.Linq.Expressions;

using BusinessRuleEngine.DAL.Context;
using BusinessRuleEngine.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BusinessRuleEngine.DAL.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private readonly BusinessRuleEngineContext dbContext;

        public RepositoryBase(BusinessRuleEngineContext dbContext)
        {
            this.dbContext = dbContext;
        }

        protected BusinessRuleEngineContext Context => this.dbContext;

        public T GetByID(Guid id)
        {
            return this.dbContext.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return this.dbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetByFilter(Expression<Func<T, bool>> expression)
        {
            return this.dbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Add(T entity)
        {
            this.dbContext.Set<T>().Add(entity);
        }

        public void Add(T[] entities)
        {
            this.dbContext.Set<T>().AddRange(entities);
        }

        public void Update(T entity)
        {
            this.dbContext.Set<T>().Update(entity);
        }

        public void Update(T[] entities)
        {
            this.dbContext.Set<T>().UpdateRange(entities);
        }

        public void Remove(T entity)
        {
            this.dbContext.Set<T>().Remove(entity);
        }

        public void Remove(T[] entities)
        {
            this.dbContext.Set<T>().RemoveRange(entities);
        }

        public void Save()
        {
            this.dbContext.SaveChangesAsync();
        }
    }
}

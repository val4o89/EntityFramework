using Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Data;
using System.Data.Entity.Migrations;
using EntityFramework.Extensions;

namespace Repos.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ProductsShopContext context;

        public Repository(ProductsShopContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().FirstOrDefault(predicate);
        }

        public IQueryable<T> FindMany(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public void Update(IQueryable<T> entities , Expression<Func<T,T>> updateExpression)
        {
            this.context.Set<T>().Update(entities, updateExpression);
        }
    }
}

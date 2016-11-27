using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Contracts
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);

        T Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> FindMany(Expression<Func<T, bool>> predicate);

        void Update(IQueryable<T> entities, Expression<Func<T, T>> updateExpression);
    }
}

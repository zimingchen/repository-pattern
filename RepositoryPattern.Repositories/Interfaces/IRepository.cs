using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int primaryKey);        
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}

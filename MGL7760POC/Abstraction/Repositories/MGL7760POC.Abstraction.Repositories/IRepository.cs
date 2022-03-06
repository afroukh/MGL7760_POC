using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MGL7760POC.Abstraction.Repositories
{
    public interface IRepository<T> where T : class, new()
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
        void Delete(T entity);
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includes);
        IQueryable<T> Query();
        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes);
    }
}

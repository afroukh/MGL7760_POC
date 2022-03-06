using MGL7760POC.Abstraction.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MGL7760POC.Implementation.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly ImpotsContext _context;

        public Repository(ImpotsContext context)
        {
            this._context = context;
        }

        private T FindById(params object[] keyValues)
        {
            return _context.Set<T>().Find(keyValues);
        }

        public void Delete(int id)
        {
            var entity = FindById(id);
            Delete(entity);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {

            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> Query()
        {
            return _context.Set<T>().AsQueryable();
        }

        private IQueryable<T> IncludeProperties(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> entities = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                entities = entities.Include(includeProperty);
            }
            return entities;
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _context.Set<T>().Attach(entity);
            }
            _context.Entry(entity).State = EntityState.Deleted;
        }



        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {

            var query = IncludeProperties(includes);

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            var query = IncludeProperties(includes);

            return query.FirstOrDefault(filter);
        }

     }
}

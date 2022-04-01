
using CoreData.Abstract;
using CoreData.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using System.Threading.Tasks;

namespace CoreData.Concrete.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {

        public void Add(T entity)
        {
            using var context = new CoreContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            using var context = new CoreContext();
            return context.Set<T>().Any(filter);
        }

        public void Delete(T entity)
        {
            using var context = new CoreContext();
            context.Set<T>().Remove(entity);
        }
        public IList<T> GetAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] property)
        {
            using var context = new CoreContext();
            IQueryable<T> sorgu = context.Set<T>();
            if (filter != null)
            {
                sorgu = sorgu.Where(filter);
            }
            if (property.Any())
            {
                foreach (var item in property)
                {
                    sorgu.Include(item);
                }
            }
            return sorgu.ToList();
        }

        public T Get(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] property)
        {
            using var context = new CoreContext();
            IQueryable<T> sorgu = context.Set<T>().Where(filter);
            if (property.Any())
            {
                foreach (var item in property)
                {
                    sorgu = sorgu.Include(item);
                }
            }
            return sorgu.FirstOrDefault();
        }
        public void Update(T entity)
        {
            using var context = new CoreContext();
            context.Set<T>().Update(entity);

        }
    }
}

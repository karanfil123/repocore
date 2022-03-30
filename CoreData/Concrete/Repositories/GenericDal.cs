using CoreData.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Concrete.Repositories
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        private readonly DbContext context;

        public GenericDal(DbContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
        public T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] property)
        {
            IQueryable<T> sorgu = context.Set<T>().Where(predicate);            
            foreach (var prop in property)
            {
                sorgu = sorgu.Include(prop);
            }
            return sorgu.FirstOrDefault();           
        }

        public IList<T> GetAll(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] property)
        {
            IQueryable<T> sorgu = context.Set<T>().Where(predicate);
            foreach (var prop in property)
            {
                sorgu = sorgu.Include(prop);
            }
            return sorgu.ToList();
        }
        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}

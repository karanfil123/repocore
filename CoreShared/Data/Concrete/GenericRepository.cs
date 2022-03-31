using CoreShared.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreShared.Data.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DbContext context;
        public GenericRepository(DbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await context.Set<T>().AnyAsync(filter);
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() =>
            {
                context.Set<T>().Remove(entity);
            });
        }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] property)
        {
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
            return await sorgu.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] property)
        {
            IQueryable<T> sorgu = context.Set<T>().Where(filter);
            if (property.Any())
            {
                foreach (var item in property)
                {
                    sorgu = sorgu.Include(item);
                }
            }
            return await sorgu.FirstOrDefaultAsync();
        }
        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() =>
            {
                context.Set<T>().Update(entity);
            });
        }
    }
}

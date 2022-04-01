using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Abstract
{
    public interface IGenericRepository<T> where T : class, new()
    {
        T Get(Expression<Func<T, bool>> filter, params Expression<Func<T, object>>[] property);
        IList<T> GetAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] property);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        bool Any(Expression<Func<T, bool>> filter);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> predicate ,params Expression<Func<T,object>>[] property);
        IList<T> GetAll(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] property);
        
    }
}

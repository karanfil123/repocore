using CoreEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Abstract
{
    public interface ICategoryService
    {
        Task<Category> GetId(int categoryId);
        Task<IList<Category>> GetAll();
        Task<IList<Category>> GetAllIsActive();
        Task Add(Category category);
        Task Delete(int categoryId);
        Task Update(Category category);
    }
}

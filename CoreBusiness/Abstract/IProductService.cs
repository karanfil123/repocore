using CoreEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Abstract
{
    public interface IProductService
    {
        Task<Product> GetId(int productId);
        Task<IList<Product>> GetAll();
        Task<IList<Product>> GetAllIsActive();
        Task Add(Product product);
        Task Delete(Product product);
        Task Update(Product product);
    }
}

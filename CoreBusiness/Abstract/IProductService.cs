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
        Product GetId(int productId);
        IList<Product> GetAll();
        IList<Product> GetAllIsActive();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}

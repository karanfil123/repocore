using CoreBusiness.Abstract;
using CoreData.Abstract;
using CoreEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Concrete.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Add(Product product)
        {
             productRepository.Add(product);
        }

        public void Delete(Product product)
        {
             productRepository.Delete(product);
        }

        public IList<Product> GetAll()
        {
            return  productRepository.GetAll();
        }

        public  IList<Product> GetAllIsActive()
        {
            return  productRepository.GetAll(x => x.IsActive);
        }

        public Product GetId(int productId)
        {
            return  productRepository.Get(x => x.ID == productId);
        }
        public void Update(Product product)
        {
             productRepository.Update(product);
        }
    }
}

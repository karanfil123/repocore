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

        public async Task Add(Product product)
        {
            await productRepository.AddAsync(product);
        }

        public async Task Delete(Product product)
        {
            await productRepository.DeleteAsync(product);
        }

        public async Task<IList<Product>> GetAll()
        {
            return await productRepository.GetAllAsync();
        }

        public async Task<IList<Product>> GetAllIsActive()
        {
            return await productRepository.GetAllAsync(x => x.IsActive);
        }

        public async Task<Product> GetId(int productId)
        {
            return await productRepository.GetAsync(x => x.ID == productId);
        }

        public async Task Update(Product product)
        {
            await productRepository.UpdateAsync(product);
        }
    }
}

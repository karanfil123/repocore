using CoreData.Abstract;
using CoreEntity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreData.Concrete.Repositories
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepository
    {       
    }
}

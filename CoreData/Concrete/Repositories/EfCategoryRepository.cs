using CoreData.Abstract;
using CoreEntity.Concrete;
using CoreShared.Data.Abstract;
using CoreShared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreData.Concrete.Repositories
{
    public class EfCategoryRepository : GenericRepository<Category>,ICategoryRepository
    {
        public EfCategoryRepository(DbContext context):base(context)
        {
        }
    }
}

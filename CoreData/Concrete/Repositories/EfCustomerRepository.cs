using CoreData.Abstract;
using CoreEntity.Concrete;
using CoreShared.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Concrete.Repositories
{
    public class EfCustomerRepository: GenericRepository<Customer>, ICustomerRepository
    {
        public EfCustomerRepository(DbContext context):base(context)
        {

        }
    }
}

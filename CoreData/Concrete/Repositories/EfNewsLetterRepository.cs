using CoreData.Abstract;
using CoreEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Concrete.Repositories
{
    public class EfNewsLetterRepository:GenericRepository<NewsLetter>,INewsLetterRepository
    {
    }
}

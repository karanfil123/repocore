using CoreShared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntity.Concrete
{
    public class Role:EntityBase
    {
        public string CustomerType { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}

using CoreShared.Entities.Abstract;
using System.Collections.Generic;

namespace CoreEntity.Concrete
{
    public class Category : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}

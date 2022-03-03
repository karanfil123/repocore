using CoreShared.Entities.Abstract;

namespace CoreEntity.Concrete
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}

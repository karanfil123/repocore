using CoreShared.Entities.Abstract;
using System.Collections.Generic;

namespace CoreEntity.Concrete
{
    public class Customer : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public ICollection<Product> Products { get; set; }

    }
   
}

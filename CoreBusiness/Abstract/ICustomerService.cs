using CoreEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Abstract
{
    public interface ICustomerService
    {
        Task<Customer> GetId(int customerId);
        Task<IList<Customer>> GetAll();
        Task<IList<Customer>> GetAllIsActive();
        Task Add(Customer customer);
        Task Delete(int customerId);
        Task Update(Customer category);
    }
}

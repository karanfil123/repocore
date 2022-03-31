﻿using CoreEntity.Concrete;
using CoreShared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.Abstract
{
    public interface ICustomerRepository:IGenericRepository<Customer>
    {
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreShared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public virtual int ID { get; set; }
        public virtual string CreateName { get; set; } = "Admin";
        public virtual DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
    }
}

using CoreEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Abstract
{
    public interface INewsLetterService
    {
        void Add(NewsLetter newsLetter);
    }
}

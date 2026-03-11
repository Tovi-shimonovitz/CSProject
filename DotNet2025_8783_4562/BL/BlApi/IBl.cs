using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BlApi
{
    public interface IBl
    {
        public ICustomer Customer { get; set; }
        public IProduct Product{ get; set; }
        public ISale Sale { get; set; }

    }
}

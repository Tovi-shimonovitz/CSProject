using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    sealed  internal  class DalXml : IDal
    {
        public ICustomer Customer => new CustomerImplementation();
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
        private static readonly DalXml instance = new DalXml();

        public static DalXml Instance
        {
            get{ return instance; }
        }


        private DalXml() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class Order
    {
        public bool TypeCustomer {  get; set; }
        public ProductInOrder? productInOrder { get; set; }
        public double? FinalPrice { get; set; }
    }
}

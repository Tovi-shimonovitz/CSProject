using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class SaleInProduct
    {
        public int SaleId { get; set; }
        public int AmountForSale { get; set; }
        public double Price { get; set; }
        public bool AllCustomer {  get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class ProductInOrder
    {
        public int ProductId {  get; set; }
        public string? ProductName { get; set; }
        public double? BasePrice { get; set; }
        public int AmountInOrder    { get; set; }
        public SaleInProduct? ListSale { get; set; }
        public double FinalPrice  { get; set; }

    }
}

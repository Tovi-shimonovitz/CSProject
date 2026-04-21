using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    public class SaleInProduct
    {
        public int SaleId { get; init; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public  bool IsPreferred { get; init; }
        public override string ToString() => this.ToStringProperty();

    }
}

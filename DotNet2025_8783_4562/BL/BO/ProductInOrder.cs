using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BL.BO
{
    public class ProductInOrder
    {
        public int ProductId {  get; init; }
        public string? ProductName { get; init; }
        public double? BasePrice { get; init; }
        public int AmountInOrder    { get; set; }
        public List<SaleInProduct>? ListSale { get; set; }
        public double TotalPrice { get; set; }
        public override string ToString() => this.ToStringProperty();
    }
}

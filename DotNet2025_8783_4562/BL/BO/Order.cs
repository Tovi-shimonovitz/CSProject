using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO;

public class Order
{
    public bool IsPreferred {  get; set; }
    public List<ProductInOrder>? productInOrder { get; set; }
    public double? TotalPrice { get; set; }
    public override string ToString() => this.ToStringProperty();
}

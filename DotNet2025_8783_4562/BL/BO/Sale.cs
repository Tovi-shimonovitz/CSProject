using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO;

public class Sale
{
    public int SaleId { get; init; }
    public int ProductId { get; init; }
    public int AmountForSale { get; set; }
    public double PriceSale { get; set; }
    public bool JustForClub { get; set; }
    public DateTime? SaleStart { get; set; }
    public DateTime? SaleEnd { get; set; }
    public override string ToString() => this.ToStringProperty();


}

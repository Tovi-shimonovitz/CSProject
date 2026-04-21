using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BL.BO;

public class Product
{
    public int ProductId { get; init; }
    public string? ProductName { get; init; }
    public Category? Category { get; set; }
    public double Price { get; set; }
    public int InStock { get; set; }
    public List<SaleInProduct>? SaleInProduct { get; set; }
    public override string ToString() => this.ToStringProperty();
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO;

public class Product
{
    public int ProductId { get; init; }
    public string? ProductName { get; set; }
    public Category? Category { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }

}

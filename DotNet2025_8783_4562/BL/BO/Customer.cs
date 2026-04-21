using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BL.BO;

public class Customer
{

    public int CustomerId { get; init; }
    public string? CustomerName { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public override string ToString() => this.ToStringProperty();
}

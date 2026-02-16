using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Customer
        (int CustomerId,
        string? CustomerName,
        string? Adress,
        string? Phone

        )
    {

        public Customer():this(0,null,null,null)
            {
           }
        public override string ToString()
        {
            return $"Customer ID: {CustomerId}\n" +
                   $"Name: {CustomerName ?? "N/A"}\n" +
                   $"Address: {Adress ?? "N/A"}\n" +
                   $"Phone: {Phone ?? "N/A"}";
        }

    }
}

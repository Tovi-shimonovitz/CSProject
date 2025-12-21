using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale
        (
        int SaleId,
        int ProductId,
        int AmountForSale,
        double PriceSale,
        bool JustForClub,
        DateTime? SaleStart,
        DateTime? SaleEnd

        )

    {

        public Sale() : this(0, 0, 0, 0, false, null, null) { }
    }
}

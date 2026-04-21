using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.BO
{
    internal static class Tools
    {
        public static string ToStringProperty<T>(this T obj)
        {
            if (obj == null) return "";

            StringBuilder sb = new StringBuilder();
            var properties = obj.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var value = prop.GetValue(obj, null);
                sb.Append($"{prop.Name}: ");

                if (value is IEnumerable collection && value is not string)
                {
                    sb.Append("\n  [");
                    foreach (var item in collection)
                    {
                        sb.Append($"\n    {item}");
                    }
                    sb.Append("\n  ]\n");
                }
                else
                {
                    sb.Append($"{value}\n");
                }
            }
            return sb.ToString();
        }

        // --- Product Mappings ---
        public static BO.Product ToBO(this DO.Product dalProd)
        {
            return new BO.Product
            {
                ProductId = dalProd.ProductId,
                ProductName = dalProd.ProductName,
                Price = dalProd.Price,
                Category = (BO.Category?)dalProd.Category,
                InStock = dalProd.Amount
            };
        }

        public static DO.Product ToDO(this BO.Product boProd)
        {
            return new DO.Product
            (
                ProductId: boProd.ProductId,
                ProductName: boProd.ProductName,
                Category: (DO.Category?)boProd.Category,
                Price: boProd.Price,
                Amount: boProd.InStock
            );
        }

        // --- Customer Mappings ---
        public static BO.Customer ToBO(this DO.Customer dalCust)
        {
            return new BO.Customer
            {
                CustomerId = dalCust.CustomerId,
                CustomerName = dalCust.CustomerName,
                Address = dalCust.Adress,
                Phone = dalCust.Phone
            };
        }

        public static DO.Customer ToDO(this BO.Customer boCust)
        {
            return new DO.Customer
            (
                CustomerId: boCust.CustomerId,
                CustomerName: boCust.CustomerName,
                Adress: boCust.Address,
                Phone: boCust.Phone
            );
        }

        // --- Sale Mappings ---
        public static BO.Sale ToBO(this DO.Sale dalSale)
        {
            return new BO.Sale
            {
                SaleId = dalSale.SaleId,
                ProductId = dalSale.ProductId,
                AmountForSale = dalSale.AmountForSale,
                PriceSale = dalSale.PriceSale,
                JustForClub = dalSale.JustForClub,
                SaleStart = dalSale.SaleStart,
                SaleEnd = dalSale.SaleEnd
            };
        }

        public static DO.Sale ToDO(this BO.Sale boSale)
        {
            return new DO.Sale
            (
                SaleId: boSale.SaleId,
                ProductId: boSale.ProductId,
                AmountForSale: boSale.AmountForSale,
                PriceSale: boSale.PriceSale,
                JustForClub: boSale.JustForClub,
                SaleStart: boSale.SaleStart,
                SaleEnd: boSale.SaleEnd
            );
        }

        public static BO.SaleInProduct ToSaleInProduct(this DO.Sale dalSale)
        {
            return new BO.SaleInProduct
            {
                SaleId = dalSale.SaleId,
                Quantity = dalSale.AmountForSale,
                Price = dalSale.PriceSale,
                IsPreferred = dalSale.JustForClub
            };
        }
    }
    

}

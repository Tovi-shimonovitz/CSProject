using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BO;

namespace BL.BlApi
{
    public interface IOrder
    {
        public List<SaleInProduct> AddProductToOrder(Order oredr, int productId, int amount);
        public void CalcTotalPriceForProduct(ProductInOrder productInOrder);
        public void CalcTotalPrice(Order oredr);
        public void DoOrder(Order oredr);
        public void SearchSaleForProduct(ProductInOrder productInOrder,bool isPreferred);
    }
}

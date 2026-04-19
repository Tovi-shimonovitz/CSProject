using System;
using System.Collections.Generic;
using System.Linq;
using BL.BlApi;

namespace BL.BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public void SearchSaleForProduct(BO.ProductInOrder productInOrder, bool isPreferred)
    {
        var validSales = from s in _dal.Sale.ReadAll()
                         where s.ProductId == productInOrder.ProductId
                         && (s.SaleStart == null || s.SaleStart <= DateTime.Now)
                         && (s.SaleEnd == null || s.SaleEnd >= DateTime.Now)
                         && (s.AmountForSale <= productInOrder.AmountInOrder)
                         && (isPreferred || !s.JustForClub)
                         orderby s.PriceSale 
                         select new BO.SaleInProduct
                         {
                             SaleId = s.SaleId,
                             Quantity = s.AmountForSale,
                             Price = s.PriceSale,
                             IsPreferred = s.JustForClub
                         };

        productInOrder.ListSale = [.. validSales];
    }

       public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
    {
        int count = productInOrder.AmountInOrder;
        double accumulatedPrice = 0;
        List<BO.SaleInProduct> appliedSales = new();

        if (productInOrder.ListSale != null)
        {
            foreach (var sale in productInOrder.ListSale)
            {
                if (count < sale.Quantity) continue;

                int timesToApply = count / sale.Quantity;
                accumulatedPrice += timesToApply * sale.Price;

                count %= sale.Quantity;

                appliedSales.Add(sale);

                if (count == 0) break;
            }
        }

        accumulatedPrice += count * (productInOrder.BasePrice ?? 0);

        productInOrder.ListSale = appliedSales;
        productInOrder.TotalPrice = accumulatedPrice;
    }

    
    public void CalcTotalPrice(BO.Order oredr)
    {
        oredr.TotalPrice = oredr.productInOrder?.Sum(item => item.TotalPrice) ?? 0;
    }

 
    public List<BO.SaleInProduct> AddProductToOrder(BO.Order oredr, int productId, int amount)
    {
        try
        {
            DO.Product? dalProduct = _dal.Product.Read(productId);

            BO.ProductInOrder? item = oredr.productInOrder?.FirstOrDefault(i => i.ProductId == productId);

            if (item != null)
            {
                if (dalProduct?.Amount < item.AmountInOrder + amount)
                    throw new BO.BlIneligibleException("Insufficient stock for the requested update");

                item.AmountInOrder += amount;
            }
            else
            {
                if (dalProduct?.Amount < amount)
                    throw new BO.BlIneligibleException("Insufficient stock for new item");

                item = new BO.ProductInOrder
                {
                    ProductId = productId,
                    ProductName = dalProduct.ProductName,
                    BasePrice = dalProduct.Price,
                    AmountInOrder = amount
                };

                oredr.productInOrder ??= new List<BO.ProductInOrder>();
                oredr.productInOrder.Add(item);
            }

            SearchSaleForProduct(item, oredr.IsPreferred);
            CalcTotalPriceForProduct(item);
            CalcTotalPrice(oredr);

            return item.ListSale ?? new List<BO.SaleInProduct>();
        }
        catch (DO.ObjectNotFoundExeption ex)
        {
            throw new BO.BlObjectNotFoundException("The requested product does not exist in the system", ex);
        }
    }

  public void DoOrder(BO.Order oredr)
    {
        if (oredr.productInOrder == null || !oredr.productInOrder.Any())
            throw new BO.BlInvalidInputException("Cannot complete an order with no items");

        foreach (var item in oredr.productInOrder)
        {
            try
            {
                DO.Product? dalProduct = _dal.Product.Read(item.ProductId);

                DO.Product? updatedProduct = dalProduct with { Amount = dalProduct.Amount - item.AmountInOrder };
                _dal.Product.Update(updatedProduct);
            }
            catch (DO.ObjectNotFoundExeption ex)
            {
                throw new BO.BlObjectNotFoundException($"Product {item.ProductId} not found", ex);
            }
        }
    }
}
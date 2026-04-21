using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BlApi;

namespace BL.BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Product item)
        {
            try
            {
                DO.Product dalProduct = BO.Tools.ToDO(item);
                int id = _dal.Product.Create(dalProduct);
                return id;
            }
            catch (DO.ObjectExistExeption ex)
            {
                throw new BO.BlObjectExistException("Product already exists in the system", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var sales = _dal.Sale.ReadAll(s => s.ProductId == id);
                if (sales.Any())
                    throw new BO.BlIneligibleException("Cannot delete product with active sales");

                _dal.Product.Delete(id);
            }
            catch (DO.ObjectNotFoundExeption ex)
            {
                throw new BO.BlObjectNotFoundException("Product not found", ex);
            }
        }

        public BO.Product? Read(int id)
        {
            try
            {
                DO.Product? dalProduct = _dal.Product.Read(id);
                if (dalProduct == null) return null;

                BO.Product boProduct = BO.Tools.ToBO(dalProduct);

                var productSales = from sale in _dal.Sale.ReadAll()
                                   where sale.ProductId == id
                                   select BO.Tools.ToSaleInProduct(sale);

                boProduct.SaleInProduct = productSales.ToList();
                return boProduct;
            }
            catch (DO.ObjectNotFoundExeption ex)
            {
                throw new BO.BlObjectNotFoundException("Product not found", ex);
            }
        }
        public BO.Product? Read(Func<BO.Product, bool>? filter)
        {
            return ReadAll().FirstOrDefault(filter!);
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            var products = _dal.Product.ReadAll()
                .Select(dalP => BO.Tools.ToBO(dalP!));

            if (filter != null)
            {
                products = products.Where(filter);
            }

            return products.ToList()!;
        }

        public void Sales(BO.ProductInOrder productInOrder, bool IsPreferred)
        {
           
            var validSales = from s in _dal.Sale.ReadAll()
                             where s.ProductId == productInOrder.ProductId
                             && (s.SaleStart == null || s.SaleStart <= DateTime.Now)
                             && (s.SaleEnd == null || s.SaleEnd >= DateTime.Now)
                             && (s.AmountForSale <= productInOrder.AmountInOrder)
                             && (IsPreferred || !s.JustForClub) 
                             orderby s.PriceSale 
                             select BO.Tools.ToSaleInProduct(s);

            productInOrder.ListSale = validSales.Cast<BO.SaleInProduct>().ToList();
        }


        public void Update(BO.Product item)
        {
            try
            {
                if (item.Price < 0) throw new BO.BlInvalidInputException("Price cannot be negative");

                DO.Product dalProduct = BO.Tools.ToDO(item);
                _dal.Product.Update(dalProduct);
            }
            catch (DO.ObjectNotFoundExeption ex)
            {
                throw new BO.BlObjectNotFoundException("Product not found for update", ex);
            }
        }
    }
}

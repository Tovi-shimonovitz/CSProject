

namespace Dal;
using DO;
using DalApi;
using static Dal.DataSource;
using System.Collections.Generic;
using System.Reflection;
using Tools;

internal class ProductImplementation:IProduct
{
    public int Create(Product item)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        Product p = item with { ProductId = Config.GetProductId };
        Products.Add(p);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return p.ProductId;

    }
    public Product? Read(int id)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from p in Products
                where p.ProductId == id
                select p;
        Product? product = q.FirstOrDefault();
  
        if(product == null) 
            throw new ObjectNotFoundExeption("notContainThisIdException");
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return product;
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from p in Products where filter != null && filter(p) || filter == null select p;
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return q.ToList().FirstOrDefault();
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from p in Products where filter != null && filter(p) == true || filter == null select p;
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
     MethodBase.GetCurrentMethod().Name, "finish func");
        return q.ToList();
    }
 
    public void Update(Product item)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        Delete(item.ProductId);
        Products.Add(item);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");

    }
    public void Delete(int id)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q=from p in Products
              where p.ProductId == id
              select p;
        Product? product = q.FirstOrDefault();
        if (product == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        Products.Remove(product);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");

    }
}

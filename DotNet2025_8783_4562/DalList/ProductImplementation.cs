

namespace Dal;
using DO;
using DalApi;
using static Dal.DataSource;
using System.Collections.Generic;

internal class ProductImplementation:IProduct
{
    public int Create(Product item)
    {
        Product p = item with { ProductId = Config.GetProductId };
        Products.Add(p);
        return p.ProductId;

    }
    public Product? Read(int id)
    {
        var q = from p in Products
                where p.ProductId == id
                select p;
        Product? product = q.FirstOrDefault();
  
        if(product == null) 
            throw new ObjectNotFoundExeption("notContainThisIdException");
        return product;
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        var q = from p in Products where filter != null && filter(p) || filter == null select p;

        return q.ToList().FirstOrDefault();
    }
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        var q = from p in Products where filter != null && filter(p) == true || filter == null select p;
       
        return q.ToList();
    }
 
    public void Update(Product item)
    {
        Delete(item.ProductId);
        Products.Add(item);
        
    }
    public void Delete(int id)
    {
        var q=from p in Products
              where p.ProductId == id
              select p;
        Product? product = q.FirstOrDefault();
        if (product == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        Products.Remove(product);

    }
}

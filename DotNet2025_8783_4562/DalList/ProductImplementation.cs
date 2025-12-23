

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
        Product? p = Products.SingleOrDefault(i => id == i.ProductId);
        if(p == null) 
            throw new Exception("notContainThisIdException");
        return p;
    }
    public List<Product?> ReadAll()
    {
        List < Product > list = new List<Product>();

        foreach (Product p in Products)
        {
            list.Add(p);
        }
        return list;
    }
    public void Update(Product item)
    {
        Product? p = Products.SingleOrDefault(i => item.ProductId == i.ProductId);
        if (p == null)
            throw new Exception("notContainThisIdException");
        Products.Remove(p);
        Products.Add(item);
        
    }
    public void Delete(int id)
    {
        Product? p = Products.SingleOrDefault(i => id == i.ProductId);
        if (p == null)
            throw new Exception("notContainThisIdException");
        Products.Remove(p);

    }
}

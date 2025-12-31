
using DO;
using DalApi;
using static Dal.DataSource;

namespace Dal;

internal class SaleImplementation : ISale
{

    public int Create(Sale item)
    {
        Sale c = item with
        {
            SaleId = Config.GetSaleId
        };
        Sales.Add(c);
        return c.SaleId;

    }
    public Sale? Read(int id)
    {
        Sale? s = Sales.SingleOrDefault(s => s.SaleId == id);
        if (s == null)
        {
            throw new ObjectNotFoundExeption($"this  sale not exists");
        }
        return s;
    }
    public List<Sale?> ReadAll()
    {
        List<Sale?> newList = new List<Sale?>();
        foreach (Sale sale in Sales)
        {
            newList.Add(sale);
        }
        return newList;
    }
    public void Update(Sale item)
    {
        Sale? existing = Sales.SingleOrDefault(s => s.SaleId == item.SaleId);
        if (existing is null)
            throw new ObjectNotFoundExeption($"Sale with Id {item.SaleId} not found.");

        Delete(item.SaleId);
        Sales.Add(item);

    }
    public void Delete(int id)
    {
        Sale? s = Sales.SingleOrDefault(s => s.SaleId == id);
        if (s is null)
        {
            throw new ObjectNotFoundExeption($"Sale with Id {id} not found.");
        }
        Sales.Remove(s);
    }


}

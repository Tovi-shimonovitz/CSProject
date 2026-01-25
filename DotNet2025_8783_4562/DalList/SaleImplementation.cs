
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
        var q = from sl in Sales where sl.SaleId == id   select sl;
        Sale? s = q.FirstOrDefault();
        if (s == null)
        {
            throw new ObjectNotFoundExeption($"this  sale not exists");
        }
        return s;
    }
    public List<Sale?> ReadAll()
    {
        var q = from s in Sales select s;
       
        return q.ToList();
    }
    public void Update(Sale item)
    {
        Delete(item.SaleId);
        Sales.Add(item);

    }
    public void Delete(int id)
    {
       var q = from s in Sales where s.SaleId == id select s;
        Sale? sl = q.FirstOrDefault();
        if (sl is null)
        {
            throw new ObjectNotFoundExeption($"Sale with Id {id} not found.");
        }
        Sales.Remove(sl);
    }


}

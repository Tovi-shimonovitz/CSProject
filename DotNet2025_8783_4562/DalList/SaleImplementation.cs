
using DO;
using DalApi;
using static Dal.DataSource;
using System.Reflection;
using Tools;

namespace Dal;

internal class SaleImplementation : ISale
{

    public int Create(Sale item)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        Sale c = item with
        {
            SaleId = Config.GetSaleId
        };
        Sales.Add(c);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return c.SaleId;

    }
    public Sale? Read(int id)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from sl in Sales where sl.SaleId == id   select sl;
        Sale? s = q.FirstOrDefault();
        if (s == null)
        {
            throw new ObjectNotFoundExeption($"this  sale not exists");
        }
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return s;
    }

  
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from s in Sales where filter != null && filter(s) == true || filter == null select s;
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
     MethodBase.GetCurrentMethod().Name, "finish func");
        return q.ToList();
    }
   

    public void Update(Sale item)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        Delete(item.SaleId);
        Sales.Add(item);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
    }
    public void Delete(int id)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from s in Sales where s.SaleId == id select s;
        Sale? sl = q.FirstOrDefault();
        if (sl is null)
        {
            throw new ObjectNotFoundExeption($"Sale with Id {id} not found.");
        }
        Sales.Remove(sl);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
    }

    public Sale? Read(Func<Sale, bool>? filter)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from s in Sales where filter != null && filter(s) || filter == null select s;
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return q.ToList().FirstOrDefault();
    }
}

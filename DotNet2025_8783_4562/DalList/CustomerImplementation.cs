using DalApi;
using DO;
using static Dal.DataSource;
using Tools;
using System.Reflection;

namespace Dal;
internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name,"start func");
        
        int id = item.CustomerId;
        var q = from c in Customers where c.CustomerId == id select c;
        if (q.FirstOrDefault() != null)
                throw new ObjectExistExeption ("this customer already exists exeption");
        Customers.Add(item);

        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
            MethodBase.GetCurrentMethod().Name, "finish func");

        return id;
    }
    public Customer? Read(int id)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from c in Customers where c.CustomerId == id select c;
        Customer? cu = q.FirstOrDefault();

        if (cu == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return cu;
    }
    public Customer? Read(Func<Customer, bool>? filter)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from c in Customers where filter!=null && filter(c)||filter==null select c;
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return q.ToList().FirstOrDefault();
    }

    public List<Customer?> ReadAll(Func < Customer,bool>? filter=null)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from c in Customers where filter!=null && filter(c)==true || filter==null select c  ;
        var list = q.ToList();
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
        return list;
    }
    public void Update(Customer item)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        Delete(item.CustomerId);
        Customers.Add(item);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");

    }
    public void Delete(int id)
    {
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "start func");
        var q = from c in Customers where c.CustomerId ==id select c;
        Customer cus = q.FirstOrDefault();
         
        if (cus == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        Customers.Remove(cus);
        LogManager.writeLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
    MethodBase.GetCurrentMethod().Name, "finish func");
    }

}

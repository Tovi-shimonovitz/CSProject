using DalApi;
using DO;
using static Dal.DataSource;

namespace Dal;
internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        int id = item.CustomerId;

        var q = from c in Customers where c.CustomerId == id select c;

            if (q.FirstOrDefault() != null)
                throw new ObjectExistExeption ("this customer already exists exeption");

        Customers.Add(item);
        return id;
    }
    public Customer? Read(int id)
    {
        var q = from c in Customers where c.CustomerId == id select c;
        Customer? cu = q.FirstOrDefault();

        if (cu == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        return cu;
    }
    public Customer? Read(Func<Customer, bool>? filter)
    {
        var q = from c in Customers where filter!=null && filter(c)||filter==null select c;

        return q.ToList().FirstOrDefault();
    }


    public List<Customer?> ReadAll(Func < Customer,bool>? filter=null)
    {
        var q = from c in Customers where filter!=null && filter(c)==true || filter==null select c  ;
        var list = q.ToList();
        return list;
    }
    public void Update(Customer item)
    {
        Delete(item.CustomerId);
        Customers.Add(item);

    }
    public void Delete(int id)
    {
        var q = from c in Customers where c.CustomerId ==id select c;
        Customer cus = q.FirstOrDefault();
         
        if (cus == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        Customers.Remove(cus);
    }

}

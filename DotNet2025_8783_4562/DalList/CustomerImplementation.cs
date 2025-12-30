using DalApi;
using DO;
using static Dal.DataSource;

namespace Dal;
internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        int id = item.CustomerId;
        foreach (Customer c in Customers)

        {


            if (c.CustomerId == id)
                throw new ObjectExistExeption ("this customer already exists exeption");
        }
        Customers.Add(item);
        return id;
    }
    public Customer? Read(int id)
    {
        Customer? c = Customers.SingleOrDefault(i => id == i.CustomerId);
        if (c == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        return c;
    }
    public List<Customer?> ReadAll()
    {
        List<Customer?> list = new List<Customer>();

        foreach (Customer c in Customers)
        {
            list.Add(c);
        }
        return list;
    }
    public void Update(Customer item)
    {
        Customer? c = Customers.SingleOrDefault(i => item.CustomerId == i.CustomerId);
        if (c == null)
            throw new ObjectNotFoundExeption("notContainThisId");
        Customers.Remove(c);
        Customers.Add(item);

    }
    public void Delete(int id)
    {
        Customer? c = Customers.SingleOrDefault(i => id == i.CustomerId);
        if (c == null)
            throw new ObjectNotFoundExeption("notContainThisIdException");
        Customers.Remove(c);
    }

}

using DalApi;
using DO;
using static Dal.DataSource;

namespace Dal;
class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        int id = item.CustomerId;
        foreach (Customer c in Customers)
        {
            if (c.CustomerId == id)
                throw new Exception("this customer already exists");
        }
        Customers.Add(item);
        return id;
    }
    public Customer? Read(int id)
    {
        return null;
    }
    public List<Customer?> ReadAll()
    {
        return null;
    }
    public void Update(Customer item)
    {

    }
    public void Delete(int id)
    {

    }

}

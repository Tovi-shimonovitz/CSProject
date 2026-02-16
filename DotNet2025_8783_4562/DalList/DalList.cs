
using DalApi;
namespace Dal
{
    public class DalList:IDal
    {

        public ICustomer Customer => new CustomerImplementation();
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
    }
}

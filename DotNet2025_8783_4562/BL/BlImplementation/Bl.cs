using BL.BlApi;

namespace BL.BlImplementation
{
    internal class Bl : IBl
    {
        public ICustomer Customer => new CustomerImplementation();

        public IOrder Order => new OrderImplementation();

        public IProduct Product => new ProductImplementation();

        public ISale Sale => throw new NotImplementedException();
    }
}

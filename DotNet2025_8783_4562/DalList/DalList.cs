
using DalApi;
namespace Dal
{
    sealed internal class DalList : IDal
    {
        private static DalList instance = new DalList();
        private DalList()
        {
        }

        public static DalList Instance
        {
            get
            { 
                return instance;
            }
        }


        public ICustomer Customer => new CustomerImplementation();
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
    }
}

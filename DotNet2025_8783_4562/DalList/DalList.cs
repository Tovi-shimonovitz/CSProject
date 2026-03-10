
using DalApi;
namespace Dal
{
    sealed internal class DalList : IDal
    {
        private static DalList instance;
        private DalList()
        {
        }

        public static DalList Instance
        {
            get
            {
                if (instance == null)
                    instance = new DalList();
                return instance;
            }
        }


        public ICustomer Customer => new CustomerImplementation();
        public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
    }
}

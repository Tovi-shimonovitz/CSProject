using DO;

namespace Dal
{
    internal static class DataSource
    {

       internal static List<Customer> Customers = new List<Customer>();
        internal static List<Sale> Sales = new List<Sale>();
        internal static List<Product> Products = new List<Product>();
        
      
        internal static class  Config
        {
            internal const int SaleId = 0;
            private static int staticSaleId = SaleId;

            public static int GetSaleId
            {
                get { return staticSaleId++; }
            }

            internal const int ProductId = 0;
            private static int staticProductId = ProductId;

            public static int GetProductId
            {
                get { return staticProductId++; }
            }

        }
    }
}

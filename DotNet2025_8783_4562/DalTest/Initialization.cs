
using DO;
using DalApi;

     namespace DalTest;

public static class  Initialization
{
   private static IDal s_dal;
    public static void initialize(IDal dal)
    {
        s_dal = dal;
        creatCustomer();
        creatProduct();
        creatSale();
    }
    public static void creatCustomer()
    { 
        s_dal.Customer.Create(new Customer(1,"tovi","Mesilat Yosef","0534168961"));
        s_dal.Customer.Create(new Customer(2,"yehudit","gefen","0534178779"));
        s_dal.Customer.Create(new Customer(3,"rnh","rerynd","465132"));
        s_dal.Customer.Create(new Customer(4,"nebtrg","etnbr","98654"));
    }
    public static void creatProduct()//TODO
    {
        s_dal.Product.Create(new Product(1,"pinkWatch",Category.WATCH,100,30));
        s_dal.Product.Create(new Product(2, "womenBag", Category.BAG, 200, 20));
        s_dal.Product.Create(new Product(3,"narkis",Category.FLOWER,30,5));
        s_dal.Product.Create(new Product(4,"handCream",Category.BEAUTY,25,10));

    }
    public static void creatSale()
    {
        s_dal.Sale.Create(new Sale(1,1,1,80,true,DateTime.Now,DateTime.Now.AddMonths(1)));
        s_dal.Sale.Create(new Sale(2,2,2,150,false,DateTime.Now,DateTime.Now.AddMonths(2)));
        s_dal.Sale.Create(new Sale(3,3,3,25,true,new DateTime(2025,12,24),new DateTime(2026,12,12)));
        s_dal.Sale.Create(new Sale(4,4,4,18,false,new DateTime(2025,11,22),new DateTime(2026,2,22)));

    }
}

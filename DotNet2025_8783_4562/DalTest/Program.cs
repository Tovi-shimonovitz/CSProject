using Dal;
using DalApi;
using DalList;
using DO;
using DO;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace DalTest
{
    internal class Program
    {
        static IDal s_dal = new Dal.DalList();
        static void Main(string[] args)
        {
           
            try
            {
                Initialization.initialize(s_dal);

            }
            catch (ObjectNotFoundExeption e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ObjectExistExeption e)
            {
                Console.WriteLine(e.Message);
            }
            displayMainMenue();

        }
        public static void displayMainMenue()
        {
            Console.WriteLine("hello to the styleGift store");
            Console.WriteLine("your good choice");
            Console.WriteLine("customer press 1");
            Console.WriteLine("product press 2");
            Console.WriteLine("sale press 3");
            int myChoice = int.Parse(Console.ReadLine());
        
            switch (myChoice)
            {
                
                case 1:displayCrud("Customer", s_dal.Customer);
                    break;
                    case 2:displayCrud("Product", s_dal.Product);
                    break;
                    case 3: displayCrud("Sale", s_dal.Sale);
                    break;
            }
            
        }
        public static void displayCrud<T>(string myChoiceString, ICrud<T> inter)
        {
            Console.WriteLine($"to create {myChoiceString}press 1");
            Console.WriteLine($"to delete {myChoiceString} press 2");
            Console.WriteLine($"to update {myChoiceString} press 3");
            Console.WriteLine($"to show {myChoiceString}press 4");
            Console.WriteLine($"to show list press 5");


            int myChoice = int.Parse(Console.ReadLine());
            switch (myChoice)
            {
                case 1:
                    Create(myChoiceString);
                    break;
                case 2:
                    Delete<T>(inter);
                    break;
                case 3:
                    Update(myChoiceString);
                    break;
                    case 4:Read(inter);
                    break;
                    case 5: ReadAll(inter);
                    break;
            }
        }
        public static Customer inputCustomer()
        {
            Console.WriteLine("insert identity");
            int CustomerId = int.Parse(Console.ReadLine());
            Console.WriteLine("insert full name");
            string? CustomerName = Console.ReadLine();
            Console.WriteLine("insert adress");
            string? Adress = Console.ReadLine();
            Console.WriteLine("insert phone");
            string? Phone = Console.ReadLine();
          return new Customer(CustomerId, CustomerName, Adress, Phone);
        }
        public static Sale inputSale()
        {
            Console.WriteLine("Enter product code for the promotion:");
            int ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of products for the promotion:");
            int AmountForSale = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sale price:");
            double PriceSale = Double.Parse(Console.ReadLine());
            Console.WriteLine("If the promotion is for club members only, press 1; for all customers press 2:");
            int isClub = int.Parse(Console.ReadLine());
            bool JustForClub = isClub == 1 ? true : false;
            Console.WriteLine("Enter sale start date:");
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Day:");
            int day = int.Parse(Console.ReadLine());
            DateTime? SaleStart = new DateTime(year, month, day);
            Console.WriteLine("Enter sale end date:");
            Console.WriteLine("Year:");
            int yearf = int.Parse(Console.ReadLine());
            Console.WriteLine("Month:");
            int monthf = int.Parse(Console.ReadLine());
            Console.WriteLine("Day:");
            int dayf = int.Parse(Console.ReadLine());
            DateTime? SaleEnd = new DateTime(yearf, monthf, dayf);
            return new Sale(1, ProductId, AmountForSale, PriceSale
                , JustForClub, SaleStart, SaleEnd);
        }
        public static Product inputProduct()
        {
            Console.WriteLine("Enter id of product");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name:");
            string? ProductName = Console.ReadLine();
            Console.WriteLine("For watches press 1");
            Console.WriteLine("For flowers press 2");
            Console.WriteLine("For beauty products press 3");
            Console.WriteLine("For tools press 4");
            Console.WriteLine("For bags press 5");
            int chooseCategory = int.Parse(Console.ReadLine());
            Category? category = Category.FLOWER;
            switch (chooseCategory)
            {
                case 1:
                    category = DO.Category.WATCH;
                    break;
                case 2:
                    category = DO.Category.FLOWER;
                    break;
                case 3:
                    category = DO.Category.BEAUTY;
                    break;
                case 4:
                    category = DO.Category.DISH;
                    break;
                case 5:
                    category = DO.Category.BAG;
                    break;
            }
            Console.WriteLine("Enter price:");
            double Price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount:");

            int Amount = int.Parse(Console.ReadLine());
            return new Product(id, ProductName, category, Price, Amount);
        }

        public static  void Create(string whichObject)
        {
            if (whichObject == "Customer") {
                s_dal.Customer.Create(inputCustomer());
            }
            if(whichObject=="Product")
            {
               
                s_dal.Product.Create(inputProduct());

            }
            if (whichObject=="Sale")
            {
               
                s_dal.Sale.Create(inputSale());
            }
            displayMainMenue();
        }
        public static void Update(string whichObject) 
        {

            if (whichObject == "Customer")
            {        
                s_dal.Customer.Update(inputCustomer());
            }
            if (whichObject == "Product")
            {
                s_dal.Product.Update(inputProduct());
            }
            if (whichObject == "Sale")
            {

                s_dal.Sale.Update(inputSale());
            }
            displayMainMenue();

        }

        public static void Delete<T>( ICrud<T> inter)
        {
            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            inter.Delete(id);
            displayMainMenue();

        }
        public static void Read<T>(ICrud<T> inter)
        {

            Console.WriteLine("enter id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(inter.Read(id));
            displayMainMenue();

        }

        public static void ReadAll<T>(ICrud<T> inter)
        {

            var customers = inter.ReadAll();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
            displayMainMenue();

        }



    }
}

using DalApi;
using DO;
using DalList;


using System.Runtime.CompilerServices;
using Dal;
using System.Numerics;
using System.Diagnostics;

namespace DalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDal s_dal = new Dal.DalList();
            try
            {
                Initialization.initialize(s_dal);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            displayMainMenue();

        }
        public static void displayMainMenue()
        {
            Console.WriteLine("hello to the styleGift store");
            Console.WriteLine("your good choice");
            Console.WriteLine("לקוחות הקש 1");
            Console.WriteLine("למוצרים הקש 2");
            Console.WriteLine("למבצעים הקש 3");
            int myChoice = int.Parse(Console.ReadLine());
            string myChoiceString = "";
            switch (myChoice)
            {
                case 1:
                    myChoiceString = "Customer";
                    break;
                    case 2:myChoiceString = "Product";
                    break;
                    case 3: myChoiceString = "Sale";
                    break;
            }
            displayCrud(myChoiceString);
        }
        public static void displayCrud(string myChoiceString)
        {
            Console.WriteLine($"ליצירת {myChoiceString}הקש 1");
            Console.WriteLine($"למחיקת {myChoiceString} הקש 2");
            Console.WriteLine($"לעדכון {myChoiceString} הקש 3");
            Console.WriteLine($"להצגת {myChoiceString}הקש 4");
            Console.WriteLine($"להצגת הרשימה הקש 5");


            int myChoice = int.Parse(Console.ReadLine());
            switch (myChoice)
            {
                case 1:

                    inputAndCreate(myChoiceString);
                    
                    break;
                case 2:
                    inputAndDelete(myChoiceString);


                    break;
                case 3:
                    inputAndCreate(myChoiceString);
                    break;
                    case 4:ReadObject(myChoiceString);
                    break;
                    case 5: ReadAllObjects(myChoiceString);
                    break;
            }
        }
        public static  void inputAndCreate(string whichObject)
        {
            IDal s_dal = new Dal.DalList();

            if (whichObject=="Customer")
            {
                Console.WriteLine("הכנס תעודת זהות");
                int  CustomerId= int.Parse(Console.ReadLine()) ;
                Console.WriteLine("הכנס שם מלא");
                string? CustomerName = Console.ReadLine() ;
                Console.WriteLine("הכנס כתובת");
                string? Adress = Console.ReadLine() ;
                Console.WriteLine("הכנס טלפון");
                string? Phone = Console.ReadLine() ;

                s_dal.Customer.Create(new Customer(CustomerId, CustomerName, Adress, Phone));


            }

            if(whichObject=="Product")
            {
                Console.WriteLine("הכנס שם מוצר");
                string? ProductName= Console.ReadLine() ;
                Console.WriteLine("לשעונים הקש 1");
                Console.WriteLine("לפרחים הקש 2");
                Console.WriteLine("למוצרי טיפוח הקש 3");
                Console.WriteLine("לכלים הקש 4");
                Console.WriteLine("לתיקים הקש 5");
                int chooseCategory = int.Parse(Console.ReadLine()) ;
                Category? category=Category.FLOWER;
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
                Console.WriteLine("הכנס מחיר");

                double Price= Double.Parse(Console.ReadLine()) ;
                Console.WriteLine("הכנס כמות");

                int Amount = int.Parse(Console.ReadLine()) ;
                s_dal.Product.Create(new Product(1, ProductName, category, Price, Amount));

            }

            if (whichObject=="Sale")
            {
                Console.WriteLine("הכנס קוד מוצר למבצע");
                int ProductId=int.Parse(Console.ReadLine()) ;
                Console.WriteLine("הכנס כמות מוצרים למבצע");
                int AmountForSale=int.Parse(Console.ReadLine()) ;
                Console.WriteLine("הכנס מחיר מבצע");
                double PriceSale=Double.Parse(Console.ReadLine()) ;
                Console.WriteLine("אם המבצע ללקוחות מועדון בלבד הקש 1 לכל הלקוחות הקש 2");
                int isClub = int.Parse(Console.ReadLine());
                bool JustForClub=isClub==1?true:false;
                Console.WriteLine("הכנס תאריך התחלת המבצע");
                Console.WriteLine("שנה:");
                int year=int.Parse(Console.ReadLine()) ;
                Console.WriteLine("חודש:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("יום:");
                int day = int.Parse(Console.ReadLine());
                DateTime? SaleStart=new DateTime(year, month, day);
                Console.WriteLine("הכנס תאריך סיום המבצע");
                Console.WriteLine("שנה:");
                int yearf = int.Parse(Console.ReadLine());
                Console.WriteLine("חודש:");
                int monthf = int.Parse(Console.ReadLine());
                Console.WriteLine("יום:");
                int dayf = int.Parse(Console.ReadLine());
                DateTime? SaleEnd = new DateTime(yearf, monthf, dayf);
                s_dal.Sale.Create(new Sale(1, ProductId, AmountForSale, PriceSale
                    , JustForClub, SaleStart, SaleEnd));
            }
        }
        public static void inputAndUpdate(string whichObject) 
        {
            IDal s_dal = new Dal.DalList();

            if (whichObject == "Customer")
            {
                Console.WriteLine("הכנס תעודת זהות");
                int CustomerId = int.Parse(Console.ReadLine());
                Console.WriteLine("הכנס שם מלא");
                string? CustomerName = Console.ReadLine();
                Console.WriteLine("הכנס כתובת");
                string? Adress = Console.ReadLine();
                Console.WriteLine("הכנס טלפון");
                string? Phone = Console.ReadLine();

                s_dal.Customer.Create(new Customer(CustomerId, CustomerName, Adress, Phone));


            }

            if (whichObject == "Product")
            {
                Console.WriteLine("הכנס שם מוצר");
                string? ProductName = Console.ReadLine();
                Console.WriteLine("לשעונים הקש 1");
                Console.WriteLine("לפרחים הקש 2");
                Console.WriteLine("למוצרי טיפוח הקש 3");
                Console.WriteLine("לכלים הקש 4");
                Console.WriteLine("לתיקים הקש 5");
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
                Console.WriteLine("הכנס מחיר");

                double Price = Double.Parse(Console.ReadLine());
                Console.WriteLine("הכנס כמות");

                int Amount = int.Parse(Console.ReadLine());
                s_dal.Product.Create(new Product(1, ProductName, category, Price, Amount));

            }

            if (whichObject == "Sale")
            {
                Console.WriteLine("הכנס קוד מוצר למבצע");
                int ProductId = int.Parse(Console.ReadLine());
                Console.WriteLine("הכנס כמות מוצרים למבצע");
                int AmountForSale = int.Parse(Console.ReadLine());
                Console.WriteLine("הכנס מחיר מבצע");
                double PriceSale = Double.Parse(Console.ReadLine());
                Console.WriteLine("אם המבצע ללקוחות מועדון בלבד הקש 1 לכל הלקוחות הקש 2");
                int isClub = int.Parse(Console.ReadLine());
                bool JustForClub = isClub == 1 ? true : false;
                Console.WriteLine("הכנס תאריך התחלת המבצע");
                Console.WriteLine("שנה:");
                int year = int.Parse(Console.ReadLine());
                Console.WriteLine("חודש:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("יום:");
                int day = int.Parse(Console.ReadLine());
                DateTime? SaleStart = new DateTime(year, month, day);
                Console.WriteLine("הכנס תאריך סיום המבצע");
                Console.WriteLine("שנה:");
                int yearf = int.Parse(Console.ReadLine());
                Console.WriteLine("חודש:");
                int monthf = int.Parse(Console.ReadLine());
                Console.WriteLine("יום:");
                int dayf = int.Parse(Console.ReadLine());
                DateTime? SaleEnd = new DateTime(yearf, monthf, dayf);
                s_dal.Sale.Create(new Sale(1, ProductId, AmountForSale, PriceSale
                    , JustForClub, SaleStart, SaleEnd));
            }
        }

        public static void inputAndDelete(string whichObject)
        {

        }
        public static void ReadObject(string whichObject)
        {

        }
        
        public static void ReadAllObjects(string whichObject)
        {

        }



    }
}

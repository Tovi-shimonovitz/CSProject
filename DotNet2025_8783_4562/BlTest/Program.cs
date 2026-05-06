using BL.BlApi;
using BL.BO;
using DalTest;
using DalApi;
using System.Threading.Channels;
using System.Xml.Serialization;
using System.Numerics;

namespace BlTest;

internal class Program
{
    private static readonly IBl s_bl = BL.BlApi.Factory.Get();

    static void Main(string[] args)
    {
       // Initialization.initialize();
        displayMenu();
    }
    public static void displayMenu()
    {
        Console.WriteLine("Hello to butiq store!\n to start orders press 1");
        int choice = 0;
        bool isPreferred;
        int pId;
        choice = int.Parse(Console.ReadLine());
        while (choice != 1)
        {
            Console.WriteLine("please press 1");
            choice = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Are you one of our preferred customers? yes press 1 no press 2");
        choice = int.Parse(Console.ReadLine());
        while (choice != 1 && choice != 2)
        {
            Console.WriteLine("invalid input please press again!");
            choice = int.Parse(Console.ReadLine());
        }
        if (choice == 1)
        {
            isPreferred = true;
            Console.WriteLine("please enter id customer");
            choice = int.Parse(Console.ReadLine());
            while (!s_bl.Customer.IsExists(choice))
            {
                Console.WriteLine("id not exists please enter again");
                choice = int.Parse(Console.ReadLine());
            }
        }
        else
        {
            isPreferred = false;
        }
        BL.BO.Order myNewOrder = new BL.BO.Order()
        {
            IsPreferred = isPreferred,            
            productInOrder = new List<BL.BO.ProductInOrder>(), 
            TotalPrice = 0                 
        };
        while (choice != 3)
        {
            Console.WriteLine("To add product press 1");
            Console.WriteLine("To do order press 2");
            Console.WriteLine("To exit press 3");
            choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.WriteLine("enter product id");
                    pId = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter amount of product");
                    int amount= int.Parse(Console.ReadLine());
                    s_bl.Order.AddProductToOrder(myNewOrder,pId,amount); break;
                case 2:
                   s_bl.Order.DoOrder(myNewOrder);
                    Console.WriteLine($"total price for your shop: {myNewOrder.TotalPrice} dolllar\n" +
                        $"thank you! ");
                    myNewOrder= new BL.BO.Order()
                    {
                        IsPreferred = isPreferred,
                        productInOrder = new List<BL.BO.ProductInOrder>(),
                        TotalPrice = 0
                    };
                    break;
                case 3:break; 
                default: Console.WriteLine("Your input not valid! please press again");break;
                   
            }
        }
        
    }
}


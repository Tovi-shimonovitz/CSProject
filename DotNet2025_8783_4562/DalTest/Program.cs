using DO;

namespace DalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Product p = new Product(1, "watch", Category.WATCH, 10, 20);
            Console.WriteLine(p);

        }
    }
}

using ClassOefening;

namespace ShopGreeterOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ShopGreeter shopGreeter= new ShopGreeter();
            shopGreeter.GreetCustomer();

            Console.WriteLine(shopGreeter);
        }
    }
}
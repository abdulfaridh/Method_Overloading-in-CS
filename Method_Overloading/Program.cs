// See https://aka.ms/new-console-template for more information
namespace Overloading
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("after adding 1+2:");
            int res1 = overloading.Add(1, 2);
            Console.WriteLine(res1);
            Console.WriteLine("after adding 1+2+3:");
            int res2 = overloading.Add(1,2,3);
            Console.WriteLine(res2);
        }
    }
}
// See https://aka.ms/new-console-template for more information
namespace Overloading
{
    public class overloading
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public static int Add()
        {
            return 0;
        }

    }
}
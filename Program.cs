using System;
using System.Text;

namespace Reshaprer
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var orderNumber = new StringBuilder();

            for (int x = 0; x < 100; x++)
            {
                orderNumber.Append(x.ToString() + ", ");
            }

            Console.WriteLine(orderNumber);
            Console.ReadLine();
        }
    }
}

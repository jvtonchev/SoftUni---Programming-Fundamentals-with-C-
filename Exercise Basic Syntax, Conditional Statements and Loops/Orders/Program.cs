using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int order = int.Parse(Console.ReadLine());
            for (int i = 1; i <= order; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                double orderP = price * days * count;
                Console.WriteLine($"The price for the coffee is: ${orderP:F2}");
                total += orderP;
            }
            Console.WriteLine($"Total: ${total:F2}");
        }
    }
}

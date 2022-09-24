using System;
using System.Numerics;

namespace division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inpN = int.Parse(Console.ReadLine());
            if ((inpN % 10) == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else
            if ((inpN % 7) == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else
                if ((inpN % 6) == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else
                if (inpN % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else
                if (inpN % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
                Console.WriteLine("Not divisible");
        }
    }
}

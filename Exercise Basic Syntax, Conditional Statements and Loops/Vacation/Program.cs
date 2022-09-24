using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (group)
            {
                case "Students": 
                    switch (day)
                    {
                        case "Friday": price = 8.45; break;
                        case "Saturday": price = 9.80; break;
                        default: price = 10.46; break;
                    }
                    price = price * count;
                    if (count > 29)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday": price = 10.90; break;
                        case "Saturday": price = 15.60; break;
                        default: price = 16.00; break;
                    }
                    if  (count>=100)
                    {
                        price = price * (count - 10);
                    }
                    else
                    {
                        price = price * count;
                    }
                    break;
                default:
                    switch (day)
                    {
                        case "Friday": price = 15.00; break;
                        case "Saturday": price = 20.00; break;
                        default: price = 22.50; break;
                    }
                    if ((count>=10) && (count<=20))
                    {
                        price = price * count * 0.95;
                    }
                    else
                    {
                        price = price * count;
                    }
                    break;


            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}

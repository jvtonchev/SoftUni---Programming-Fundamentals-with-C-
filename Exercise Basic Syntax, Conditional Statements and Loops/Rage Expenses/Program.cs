using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostG = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine()); 
            double mouse = double.Parse(Console.ReadLine()); 
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());
            double price = 0;
            int lost2 = lostG / 2;
            int lost3 = lostG / 3;
            int lost6 = lostG / 6;
            int lost12 = lostG / 12;
            price = lost2*headset+lost3*mouse+lost6*keyboard+lost12*display;
            Console.WriteLine($"Rage expenses: {price:F2} lv.");
        }
    }
}

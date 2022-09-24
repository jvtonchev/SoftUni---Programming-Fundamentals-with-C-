using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double saber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());
            double price = Math.Ceiling( countOfStudents * 1.1)*saber;
            price += countOfStudents * robe;
            price += (countOfStudents - countOfStudents / 6) * belt;
            if (amountOfMoney >= price)
                Console.WriteLine($"The money is enough - it would cost {price:F2}lv.");
            else Console.WriteLine($"John will need {(price - amountOfMoney):F2}lv more.");
                       
        }
    }
}

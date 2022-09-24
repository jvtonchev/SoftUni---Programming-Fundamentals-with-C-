using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balans = 0;
            while (true)
            {
                string inputS = Console.ReadLine();
                if (inputS == "Start") break;
                else
                {
                    double inputN = double.Parse(inputS);
                    if ((inputN == 0.1) || (inputN == 0.2) || (inputN == 0.5) || (inputN == 1.0) || (inputN == 2.0)) balans += inputN;
                    else Console.WriteLine($"Cannot accept {inputN}");
                }
            }
            while (true)
            {
                string inputS = Console.ReadLine();
                if (inputS =="End")
                {
                    Console.WriteLine($"Change: {balans:F2}"); break;
                }
                else
                    switch (inputS)
                    {
    //"Nuts" with a price of 2.0
	//"Water" with a price of 0.7
	//"Crisps" with a price of 1.5
	//"Soda" with a price of 0.8
	//"Coke" with a price of 1.0

                        case "Nuts":
                            if (balans >= 2)
                            {
                                Console.WriteLine("Purchased nuts");
                                balans -= 2;
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Water":
                            if (balans >= 0.7)
                            {
                                Console.WriteLine("Purchased water");
                                balans -= 0.7;
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Crisps":
                            if (balans >= 1.5)
                            {
                                Console.WriteLine("Purchased crisps");
                                balans -= 1.5;
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Soda":
                            if (balans >= 0.8)
                            {
                                Console.WriteLine("Purchased soda");
                                balans -= 0.8;
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        case "Coke":
                            if (balans >= 1.0)
                            {
                                Console.WriteLine("Purchased coke");
                                balans -= 1.0;
                            }
                            else Console.WriteLine("Sorry, not enough money");
                            break;
                        default:  Console.WriteLine("Invalid product"); break;
                    }
                       
            }
        }
    }
}

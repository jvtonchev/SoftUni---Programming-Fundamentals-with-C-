﻿using System;

namespace Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beg = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for ( int i = beg; i <= end; i++)
            {
                sum = sum + i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}

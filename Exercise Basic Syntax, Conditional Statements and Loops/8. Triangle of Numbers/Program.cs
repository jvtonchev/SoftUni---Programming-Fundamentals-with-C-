﻿using System;

namespace _8._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputN = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputN; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write($"{i} ");
                Console.WriteLine();
            }
        }
    }
}

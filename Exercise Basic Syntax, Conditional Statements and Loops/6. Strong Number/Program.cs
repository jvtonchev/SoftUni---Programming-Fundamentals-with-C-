using System;

namespace _6._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inpNum = int.Parse(Console.ReadLine());
            int workNum = inpNum;
            int sumNum = 0;
            while (workNum > 0)
            {
                int x = workNum % 10; 
                workNum = (workNum / 10);
                int y = 1;
                for (int i = 1; i <= x; i++) y = y * i;
                sumNum += y;
            }
            if (inpNum == sumNum) Console.WriteLine("yes");
            else Console.WriteLine("no");   
        }
    }
}

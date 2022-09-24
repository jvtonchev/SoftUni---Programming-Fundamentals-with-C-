using System;

namespace _01_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int age = int.Parse(Console.ReadLine());
            string Person = "";

            if (age>= 0 && age<=2) 
            {
                Person = "baby";
            }
            else 
                if (age>=3 && age<=13)
                {
                    Person = "child";
                }
                else
                    if (age>=14 && age<=19)
                    {
                        Person = "teenager";
                    }
                else
                if (age>=20 && age<=65)
                {
                Person = "adult";
                }
            else
                if (age>=66)
            {
                Person = "elder";
            }
            Console.WriteLine(Person);
        }
    }
}

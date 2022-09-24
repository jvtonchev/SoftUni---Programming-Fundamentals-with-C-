using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            String userPassword = "";
            for (int i = userName.Length-1; i >= 0; i--) userPassword = userPassword + userName[i];
            int numOfErr = 0;
            while ( true )
            {
                string inputPasswod = Console.ReadLine(); 
                if ( inputPasswod == userPassword )
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    numOfErr++;
                    
                    if ( numOfErr == 4 )
                    {
                        Console.WriteLine($"User {userName} blocked!"); break;
                    }
                    else Console.WriteLine("Incorrect password. Try again.");
                }
            }

        }
    }
}

/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace Factorial
{
    class Program
    {
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n;
		    Console.Write("Enter a number greater than or equal to zero : ");
		    n = Convert.ToInt32(Console.ReadLine());
		
		    Console.WriteLine("Factorial of " + n + " is " + Factorial(n));
        }
    }
}

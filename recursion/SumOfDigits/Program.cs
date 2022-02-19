/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace SumOfDigits
{
    class Program
    {
        public static int SumDigits(int n)
        {
            if (n / 10 == 0)
                return n;
            return SumDigits(n / 10) + n % 10;
        }
        
        static void Main(string[] args)
        {
            int n;
		    Console.Write("Enter a number : ");
		    n = Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine(SumDigits(n));
        }
    }
}

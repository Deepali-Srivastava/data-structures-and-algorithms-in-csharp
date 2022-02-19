/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace Fibonacci
{
    class Program
    {
        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of terms : ");
		    int terms = Convert.ToInt32(Console.ReadLine());
		
		    for( int i = 0; i <= terms; i++ )
                Console.Write(Fib(i)+" ");
        }
    }
}

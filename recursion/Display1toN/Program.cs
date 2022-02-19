/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace Display1toN
{
    class Program
    {
        public static void Print1(int n)
	    {
		    if(n==0)
		       return;
		    Console.Write(n + " ");	
		    Print1(n-1);
	    }

        public static void Print2(int n)
	    {
		    if(n==0)
		       return;
		    Print2(n-1);
		    Console.Write(n + " ");	
	    }
        
        static void Main(string[] args)
        {
            int n;
		    Console.WriteLine("Enter value of n : ");
		    n = Convert.ToInt32(Console.ReadLine());
		
		    Print1(n);	
		    Console.WriteLine();
		
		    Print2(n);	
		    Console.WriteLine();
	    }
    }
}

/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace ShellSort
{
        class Program
        {
            public static void Sort(int[] a, int n)
            {
                int i, j, temp, h;
		    		   
		        Console.Write("Enter maximum increment(odd value) : ");
		        h = Convert.ToInt32( Console.ReadLine() );
		
		        while ( h >= 1 )
		        {
			        for (i = h; i < n; i++)
			        {
				        temp = a[i];
				        for (j = i-h; j>=0 && a[j]>temp; j = j-h)
					        a[j+h] = a[j];
				        a[j+h] = temp;
			        }
			        h = h-2; 
		        }
             }
        
            static void Main(string[] args)
            {
                int i, n;
                int[] a = new int[20];

                Console.Write("Enter the number of elements : ");
                n = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i < n; i++)
                {
                    Console.Write("Enter element " + (i + 1) + " : ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                Sort(a, n);

                Console.WriteLine("Sorted array is : ");
                for (i = 0; i < n; i++)
                    Console.Write(a[i] + " ");
                Console.WriteLine();
            }
      }
}

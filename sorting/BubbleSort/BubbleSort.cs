/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

class BubbleSort
{
    public static void Sort(int[] a, int n)
    {
        int x, j, temp, swaps;

        for (x = n - 2; x >= 0; x--)
        {
            swaps = 0;
            for (j = 0; j <= x; j++)
            {
                if (a[j] > a[j + 1])
                {
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swaps++;
                }
            }
            if (swaps == 0)
                break;
        }
    }
    
    static void Main(string[] args)
    {
        int i,n;
		int[] a = new int[20];
				
		Console.Write("Enter the number of elements : ");
		n = Convert.ToInt32(Console.ReadLine());
				
		for(i=0; i<n; i++)
		{
			Console.Write("Enter element " + (i+1) + " : ");
			a[i] = Convert.ToInt32(Console.ReadLine());
		}
		
		Sort(a,n);
		
		Console.WriteLine("Sorted array is : ");
		for(i=0; i<n; i++)
			Console.Write(a[i] + " ");
		Console.WriteLine();
    }
}

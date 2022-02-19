/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

class SelectionSort
{
    public static void Sort(int[] a, int n)
    {
        int minIndex, temp, i, j;

        for (i = 0; i < n - 1; i++)
        {
            minIndex = i;
            for (j = i + 1; j < n; j++)
            {
                if (a[j] < a[minIndex])
                    minIndex = j;
            }
            if (i != minIndex)
            {
                temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }
        }
    }
    static void Main(string[] args)
    {
        int i,n;
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
		for ( i = 0; i < n; i++)
			Console.Write(a[i] + " ");
		Console.WriteLine();
                
    }
}


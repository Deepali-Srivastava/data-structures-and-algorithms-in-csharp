/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

class Program
{
    public static int Search(int[] a, int n, int searchValue)
    {
        return Search(a, 0, n-1, searchValue);
    }

    public static int Search(int[] a, int first, int last, int searchValue)
    {
        if (first > last)
            return -1;

        int mid = (first + last) / 2;

        if (searchValue > a[mid]) 			/*Search in right half */
            return Search(a, mid+1, last, searchValue);
        else if (searchValue < a[mid])		/*Search in left half */
            return Search(a, first, mid-1, searchValue);
        else
            return mid;
    }

    static void Main(string[] args)
    {
        int i, n, searchValue, index;

        int[] a = new int[100];

        Console.Write("Enter the number of elements : ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements in sorted order  - ");
        for (i = 0; i < n; i++)
            a[i] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the search value : ");
        searchValue = Convert.ToInt32(Console.ReadLine());

        index = Search(a, n, searchValue);

        if (index == -1)
            Console.WriteLine("Value " + searchValue + " not present in the array");
        else
            Console.WriteLine("Value " + searchValue + " present at index " + index);
    }
}


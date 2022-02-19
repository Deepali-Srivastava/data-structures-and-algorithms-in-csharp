/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

class Program
{
        public static int Search(int[] a, int n, int searchValue)
        {
            a[n] = searchValue;

            int i = 0;
            while (searchValue != a[i])
                i++;

            if (i < n)
                return i;
            else
                return -1;

        }

        static void Main(string[] args)
        {
            int i, n, searchValue, index;

            int[] a = new int[100];

            Console.Write("Enter the number of elements : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements - ");
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


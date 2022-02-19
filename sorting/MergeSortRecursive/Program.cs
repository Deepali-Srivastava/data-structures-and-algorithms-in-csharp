/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace MergeSortRecursive
{
    class Program
    {
        public static void Sort(int[] a, int n)
	    {
		    int[] temp = new int[n];
		    Sort ( a, temp, 0, n-1 );
	    }
	
	    private static void Sort(int[] a, int[] temp, int low, int up)
	    {
		    if ( low == up ) /*only one element*/
			    return;

		    int mid = (low + up)/2;
			
		    Sort(a, temp, low, mid);  /* Sort a[low]....a[mid] */
		    Sort(a, temp, mid+1, up);  /* Sort a[mid+1]....a[up] */
			
		    /* Merge a[low]...a[mid] and a[mid+1]....a[up] to temp[low]...temp[up] */
		    Merge(a, temp, low, mid, mid+1, up); 
		
		    /* Copy temp[low]...temp[up] to a[low]...a[up] */ 
		    Copy(a, temp, low, up);	
	    }
	
	    /* a[low1]...a[up1] and a[low2]...a[up2] merged to temp[low1]...temp[up2] */
	    private static void Merge( int[] a, int[] temp, int low1, int up1, int low2, int up2 )
	    {
		    int i = low1;
		    int j = low2;
		    int k = low1;

		    while( (i<=up1) && (j<=up2) )
		    {
			    if( a[i] <= a[j] )
				    temp[k++] = a[i++];
			    else
				    temp[k++] = a[j++];
		    }

		    while( i <= up1 )
			    temp[k++] = a[i++];
		
		    while(j <= up2)
			    temp[k++] = a[j++];
	    }

	    /*copies temp[low]....temp[up] to a[low]...a[up]*/
	    private static void Copy(int[] a, int[] temp, int low, int up)
	    {
		    for(int i = low; i <= up; i++)
			    a[i] = temp[i];
	    }
        
        static void Main(string[] args)
        {
            int i,n;
		    int[] a = new int[20];
		    
		    Console.Write("Enter the number of elements : ");
		    n = Convert.ToInt32(Console.ReadLine());
				
		    for( i = 0; i < n; i++ )
		    {
			    Console.Write("Enter element " + (i+1) + " : ");
			    a[i] = Convert.ToInt32( Console.ReadLine() );
		    }
		
		    Sort(a, n);
		
		    Console.WriteLine("Sorted array is : ");
		    for( i = 0; i < n; i++)
			    Console.Write( a[i] + " " );
		    Console.WriteLine();
        }
    }
}

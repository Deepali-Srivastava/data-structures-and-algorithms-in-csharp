/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace TowerofHanoi
{
    class Program
    {
        public static void Hanoi(int n, char source, char temp, char dest)
	    {
		    if(n==1)
		    {
                Console.WriteLine("Move Disk " + n + " from " + source + "-->" + dest);
			    return;
		    }
		    Hanoi(n-1, source, dest, temp);
		    Console.WriteLine("Move Disk " + n + " from " + source + "-->" + dest);
		    Hanoi(n-1, temp, source, dest);
	    }
        
        static void Main(string[] args)
        {
              int n;
		      Console.Write("Enter the number of disks : ");
		      n = Convert.ToInt32(Console.ReadLine());
		
		      Hanoi(n, 'A', 'B', 'C');
        }
    }
}

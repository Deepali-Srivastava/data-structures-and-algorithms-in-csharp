/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace SingleListMergingProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            SingleLinkedList list1 = new SingleLinkedList();
		    SingleLinkedList list2 = new SingleLinkedList();
				
		    list1.CreateList();
		    list2.CreateList();
		
		    list1.BubbleSortExData();
		    list2.BubbleSortExData();
				
		    Console.WriteLine("First List - ");  list1.DisplayList();
		    Console.WriteLine("Second List - "); list2.DisplayList();
		
		    SingleLinkedList list3;
		
		    list3 = list1.Merge1(list2);
		    Console.WriteLine("Merged List - "); list3.DisplayList();
		
		    Console.WriteLine("First List - ");  list1.DisplayList();
		    Console.WriteLine("Second List - "); list2.DisplayList();
		
		    list3 = list1.Merge2(list2);
		    Console.WriteLine("Merged List - "); list3.DisplayList();
		
		    Console.WriteLine("First List - ");  list1.DisplayList();
		    Console.WriteLine("Second List - "); list2.DisplayList();
        }
    }
}

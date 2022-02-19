/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace SingleListConcatenateProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            SingleLinkedList List1 = new SingleLinkedList();
		    SingleLinkedList List2 = new SingleLinkedList();
		
		    Console.WriteLine("Enter first list :- ");
		    List1.CreateList();
		    Console.WriteLine("Enter second list :- ");
		    List2.CreateList();
	
		    Console.Write("First ");
		    List1.DisplayList();
		    Console.Write("Second ");
		    List2.DisplayList();
		
		    List1.Concatenate(List2);
		    Console.Write("First ");
		    List1.DisplayList();
	    }
    }
}
    
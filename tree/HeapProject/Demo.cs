/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace HeapProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            Heap h = new Heap(20);
				
		    int choice,value;
				
		    while(true)
		    {
			    Console.WriteLine("1.Insert");
			    Console.WriteLine("2.Delete root");
			    Console.WriteLine("3.Display");
			    Console.WriteLine("4.Exit");
			    Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());
			
			    if(choice==4)
				    break;
			
			    switch(choice)
			    {
			        case 1:
				        Console.Write("Enter the value to be inserted : ");
				        value = Convert.ToInt32(Console.ReadLine());
				        h.Insert(value);
				        break;
			        case 2:
				        Console.WriteLine("Maximum value is " + h.DeleteRoot());
				        break;
			        case 3:
				        h.Display();
				        break;
	 		        default:
				        Console.WriteLine("Wrong choice");
                        break;
			    }
		    }
	    }
    }
}


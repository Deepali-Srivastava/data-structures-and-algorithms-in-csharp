/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace HeaderLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, x, k;
		    		
	    	HeaderLinkedList List = new HeaderLinkedList();
		    List.CreateList();
		
		    while(true)
		    {
			    Console.WriteLine("1.Display list");
			    Console.WriteLine("2.Insert a node at the end of the list");
			    Console.WriteLine("3.Insert a new node before a node");
			    Console.WriteLine("4.Insert at a given position");
			    Console.WriteLine("5.Delete a node");
			    Console.WriteLine("6.Reverse the list");
			    Console.WriteLine("7.Quit");
			    Console.Write("Enter your choice : ");
			    choice=Convert.ToInt32(Console.ReadLine());
			
			    if(choice==7)
				    break;

			    switch(choice)
			    {
			     case 1:
				    List.DisplayList();
				    break;
			     case 2:
				    Console.Write("Enter the element to be inserted : ");
				    data = Convert.ToInt32(Console.ReadLine());
				    List.InsertAtEnd(data);
				    break;
			     case 3:
				    Console.Write("Enter the element to be inserted : ");
				    data = Convert.ToInt32(Console.ReadLine());
				    Console.Write("Enter the element before which to insert : ");
				    x = Convert.ToInt32(Console.ReadLine());
				    List.InsertBefore(data,x);
				    break;
			     case 4:
				    Console.Write("Enter the element to be inserted : ");
				    data = Convert.ToInt32(Console.ReadLine());
				    Console.Write("Enter the position at which to insert : ");
				    k = Convert.ToInt32(Console.ReadLine());
				    List.InsertAtPosition(data,k);
				    break;
			     case 5:
				    Console.Write("Enter the element to be deleted : ");
				    data = Convert.ToInt32(Console.ReadLine());
				    List.DeleteNode(data);	
				    break;
			     case 6:
				    List.Reverse();
				    break;
			     default:
				    Console.WriteLine("Wrong choice");
                    break;
			    }
		  }
      }
   }
}

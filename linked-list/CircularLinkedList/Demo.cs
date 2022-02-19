/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace CircularLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice,data,x;
		
		    CircularLinkedList List = new CircularLinkedList();
		
		    List.CreateList();
			
		    while(true)
		    {
			    Console.WriteLine("1.Display List");
			    Console.WriteLine("2.Insert in  empty list");
			    Console.WriteLine("3.Insert in the beginning");
			    Console.WriteLine("4.Insert at the end");
			    Console.WriteLine("5.Insert after a node");
			    Console.WriteLine("6.Delete first node");
			    Console.WriteLine("7.Delete last node");
			    Console.WriteLine("8.Delete any node");
			    Console.WriteLine("9.Quit");
			
			    Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());

			    if(choice==9)
				    break;
			
			    switch(choice)
			    {
			        case 1:
				        List.DisplayList();
				        break;
			        case 2:
				        Console.Write("Enter the element to be inserted : ");
				        data = Convert.ToInt32(Console.ReadLine());
				        List.InsertInEmptyList(data);
				        break;
			        case 3:
				        Console.Write("Enter the element to be inserted : ");
				        data = Convert.ToInt32(Console.ReadLine());
				        List.InsertInBeginning(data);
				        break;
			        case 4:
				        Console.Write("Enter the element to be inserted : ");
				        data = Convert.ToInt32(Console.ReadLine());
				        List.InsertAtEnd(data);
				        break;
			        case 5:
				        Console.Write("Enter the element to be inserted : ");
				        data = Convert.ToInt32(Console.ReadLine());
				        Console.Write("Enter the element after which to insert : ");
				        x = Convert.ToInt32(Console.ReadLine());
				        List.InsertAfter(data,x);
				        break;
			        case 6:
				         List.DeleteFirstNode();
				         break;
			        case 7:
				         List.DeleteLastNode();
				         break;
			        case 8:
				        Console.Write("Enter the element to be deleted : ");
				        data = Convert.ToInt32(Console.ReadLine());
				        List.DeleteNode(data);
				        break;
			        default:
				        Console.WriteLine("Wrong choice");
                        break;
			       }
			        Console.WriteLine();	
		        }
		        Console.WriteLine("Exiting");
        }
    }
}

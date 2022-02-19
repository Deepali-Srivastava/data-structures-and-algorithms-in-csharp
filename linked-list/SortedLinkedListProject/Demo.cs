/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace SortedLinkedListProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice,data;
	
	        SortedLinkedList List = new SortedLinkedList();
  	        List.CreateList();
   
	        while(true)
	        {
		          Console.WriteLine("1.Display List");
		          Console.WriteLine("2.Insert a new node");
		          Console.WriteLine("3.Search");
		          Console.WriteLine("4.Exit");
		          Console.Write("Enter your choice : ");
		          choice = Convert.ToInt32(Console.ReadLine());
		          if(choice==4)
			         break;
		
		          switch(choice)
		          {
		            case 1:
			          List.DisplayList();
			          break;
		            case 2:
			          Console.WriteLine("Enter the element to be inserted : ");
			          data = Convert.ToInt32(Console.ReadLine());
			          List.InsertInOrder(data);
			          break;
		            case 3:
			           Console.WriteLine("Enter the element to be searched : ");
			           data=Convert.ToInt32(Console.ReadLine());
			           List.Search(data);
			           break;
		          default:
			           Console.WriteLine("Wrong choice\n");
                       break;
		        }
	        }/*End of while*/
        }
    }
}

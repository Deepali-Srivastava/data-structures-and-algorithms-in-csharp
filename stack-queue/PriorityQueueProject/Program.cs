/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PriorityQueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, element, elementPriority;
		
		    PriorityQueueL pq = new PriorityQueueL();
		
		    while( true )
		    {
			    Console.WriteLine("1.Insert a new element");
			    Console.WriteLine("2.Delete an element");
			    Console.WriteLine("3.Display the queue");
			    Console.WriteLine("4.Quit");
			    Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());
			    if(choice == 4)
				    break;

			    switch( choice )
			    {
			     case 1:
				    Console.WriteLine("Enter the element to be inserted : ");
				    element = Convert.ToInt32(Console.ReadLine());
				    Console.WriteLine("Enter its priority : ");
				    elementPriority = Convert.ToInt32(Console.ReadLine());
				    pq.Insert(element, elementPriority);
				    break;
			     case 2:
				    Console.WriteLine("Deleted element is " + pq.Delete());			
				    break;
			     case 3:
				    pq.Display();
				    break;
			     default :
				    Console.WriteLine("Wrong choice");
                    break;
			 }
		 }
      }
   }
}

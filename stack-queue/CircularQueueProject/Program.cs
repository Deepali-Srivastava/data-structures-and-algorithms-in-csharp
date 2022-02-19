/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace CircularQueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;

            CircularQueue qu = new CircularQueue(8);

            while (true)
            {
                Console.WriteLine("1.Insert an element in the queue");
                Console.WriteLine("2.Delete an element from the queue");
                Console.WriteLine("3.Display element at the front");
                Console.WriteLine("4.Display all elements of the queue");
                Console.WriteLine("5.Display size of the queue");
                Console.WriteLine("6.Quit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be inserted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.Insert(x);
                        break;
                    case 2:
                        x = qu.Delete();
                        Console.WriteLine("Element deleted is : " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the front is : " + qu.Peek());
                        break;
                    case 4:
                        qu.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of queue is " + qu.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}

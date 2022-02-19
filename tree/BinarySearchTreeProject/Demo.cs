/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BinarySearchTreeProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            BinarySearchTree bt = new BinarySearchTree(); 
    		int choice,x;
		
		    while(true)
		    {
			    Console.WriteLine("1.Display Tree");
			    Console.WriteLine("2.Search");
			    Console.WriteLine("3.Insert a new node");
			    Console.WriteLine("4.Delete a node");
			    Console.WriteLine("5.Preorder Traversal");
			    Console.WriteLine("6.Inorder Traversal");
			    Console.WriteLine("7.Postorder Traversal");
			    Console.WriteLine("8.Height of tree");
			    Console.WriteLine("9.Find Minimum key");
			    Console.WriteLine("10.Find Maximum key");
			    Console.WriteLine("11.Quit");
			    Console.Write("Enter your choice : ");
			    choice = Convert.ToInt32(Console.ReadLine());

			    if(choice == 11)
				    break;

			    switch( choice )
			    {
			    case 1:
				    bt.Display();
				    break;
			    case 2: 
				    Console.Write("Enter the key to be searched : ");
				    x = Convert.ToInt32(Console.ReadLine());
				
				    if ( bt.Search(x) )
					    Console.WriteLine("Key found");
				    else
					    Console.WriteLine("Key not found");
				    break;
			    case 3:
				    Console.Write("Enter the key to be inserted : ");
				    x = Convert.ToInt32(Console.ReadLine());
				    bt.Insert(x);
				    break;
			    case 4:
				    Console.Write("Enter the key to be deleted : ");
				    x = Convert.ToInt32(Console.ReadLine());
				    bt.Delete(x);
				    break;
			     case 5:
				    bt.Preorder();
				    break;
			     case 6:
				    bt.Inorder();
				    break;
			     case 7:
				    bt.Postorder();
				    break;
			     case 8:
				    Console.WriteLine("Height of tree is " + bt.Height());
				    break;
			     case 9:
				    Console.WriteLine("Minimum key is " + bt.Min());
				    break;
			     case 10:
				    Console.WriteLine("Maximum key is " + bt.Max());
				    break;
			    }
		    }
		 }
      }
}


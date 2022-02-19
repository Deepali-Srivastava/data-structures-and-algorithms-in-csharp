/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BinaryTreeProject
{
    class Demo
    {
        static void Main(string[] args)
        {
           	BinaryTree bt = new BinaryTree(); 

		    bt.CreateTree();

		    bt.Display();
		    Console.WriteLine();
		
	        Console.WriteLine("Preorder : ");
		    bt.Preorder(); 
		    Console.WriteLine("");

		    Console.WriteLine("Inorder : ");
		    bt.Inorder();
		    Console.WriteLine();

		    Console.WriteLine("Postorder : ");
		    bt.Postorder();
		    Console.WriteLine();

		    Console.WriteLine("Level order : ");
		    bt.LevelOrder();
		    Console.WriteLine();
		
		    Console.WriteLine("Height of tree is " + bt.Height());
        }
    }
}

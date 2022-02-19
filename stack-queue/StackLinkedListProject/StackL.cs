/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace StackLinkedListProject
{
    class StackL
    {
        private Node top;

        public StackL()
        {
            top = null;
        }

        public int Size()
        {
            int s = 0;
            Node p = top;
            while (p != null)
            {
                p = p.link;
                s++;
            }
            return s;
        }

        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        public int Pop()
        {
       	    int x;
    	    if ( IsEmpty() )
                throw new System.InvalidOperationException("Stack Underflow");
    	    x = top.info;
    	    top = top.link;
    	    return x;
        }

        public int Peek()
        {
    	    if ( IsEmpty() )
                throw new System.InvalidOperationException("Stack Underflow");
    	    return top.info;
        }

        public bool IsEmpty()
        {
            return ( top == null );
        }

        public void Display()
        {       
    	    Node p = top;
    	    if ( IsEmpty() )
    	    {	
    		    Console.WriteLine("Stack is empty");
    		    return;
    	    }
    	
    	    Console.WriteLine("Stack is : ");
    	    while( p != null )
    	    {
    		    Console.WriteLine(p.info + " ");
    		    p=p.link;
    	    }
    	    Console.WriteLine();
        }
    }
}

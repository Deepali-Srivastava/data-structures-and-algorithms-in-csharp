/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PostfixProject
{
    class StackInt
    {
        private int[] stackArray;
        private int top;

        public StackInt()
        {
            stackArray = new int[10];
            top = -1;
        }

        public StackInt(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        public int Size()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return ( top == stackArray.Length - 1 );
        }

        public void Push(int x)
        {
    	    if ( IsFull() )
    	    {
    		    Console.WriteLine("Stack Overflow\n");
    		    return;
    	    }
    	    top = top + 1;
    	    stackArray[top] = x;
        }

        public int Pop()
        {
    	    int x;
    	    if ( IsEmpty() )
    	    {
    		    Console.WriteLine("Stack Underflow\n");
    		    throw new System.InvalidOperationException();
    	    }
    	    x = stackArray[top];
    	    top = top-1;
    	    return x;
        }

        public int Peek()
        {
    	    if ( IsEmpty() )
    	    {
    		    Console.WriteLine("Stack Underflow\n");
    		    throw new System.InvalidOperationException();
    	    }
    	    return stackArray[top];
        }
        
        public void display()
        {
    	    int i;
    	
    	    Console.WriteLine("top= " + top);

    	    if ( IsEmpty() )
    	    {
    		    Console.WriteLine("Stack is empty");
    		    return;
    	    }
            Console.WriteLine("Stack is : ");
    	    for ( i = top; i >= 0; i-- )
    		    Console.WriteLine( stackArray[i] + " " );
    	    Console.WriteLine();
        }
    }
}

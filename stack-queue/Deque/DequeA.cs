/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace Deque
{
    class DequeA
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public DequeA()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }
        public DequeA(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }
        public void InsertFront(int x)
	    {
		    if( IsFull() )
		    {
			    Console.WriteLine("Queue Overflow");
			    return;
		    }
		    if( front == -1 )
		    {	
			    front = 0;
			    rear = 0;
		    }
		    else if( front == 0 )
			    front = queueArray.Length-1;
		    else
			    front = front-1;
		    queueArray[front] = x;
	    }

        public void InsertRear(int x)
	    {
		    if( IsFull() )
		    {
			    Console.WriteLine("Queue Overflow");
			    return;
		    }
		    if ( front == -1 )  
			    front = 0;
		
		    if( rear == queueArray.Length-1 )  
			    rear = 0;
		    else
			    rear = rear+1;
		    queueArray[rear] = x;
	    }

        public int DeleteFront()
	    {
		    int x;
		    if( IsEmpty() )
                throw new System.InvalidOperationException("Queue Underflow");

		    x = queueArray[front];
		
		    if( front == rear ) /*only one element*/
		    {
			    front = -1;
			    rear = -1;
		    }
		    else if( front == queueArray.Length-1 )
			    front = 0;
		    else
			    front=front+1;
		    return x;
	    }

        public int DeleteRear()
	    {
		    int x;
		    
            if( IsEmpty() )
		        throw new System.InvalidOperationException("Queue Underflow");
		    
            x = queueArray[rear];
		
		    if( front == rear ) /*only one element*/
		    {
			    front = -1;
			    rear = -1;
		    }
		    else if( rear == 0 )
			    rear = queueArray.Length-1;
		    else
			    rear = rear-1;
		    return x;
	    }

        public bool IsFull()
        {
            return ((front == 0 && rear == queueArray.Length - 1) || (front == rear + 1));
        }

        public bool IsEmpty()
        {
            return (front == -1);
        }

        public void Display()
	    {
		    int i;
		
		    if( IsEmpty() )
		    {
			    Console.WriteLine("Queue is empty");
			    return;
		    }
		
		    Console.WriteLine("Queue is : ");
		    i = front;
		    if( front <= rear )
		    {
			    while( i <= rear )
				    Console.Write(queueArray[i++] + " ");
		    }
		    else
		    {
			    while( i <= queueArray.Length-1 )
				    Console.Write( queueArray[i++] + " ");
			    i = 0;
			    while(i <= rear)
				    Console.Write( queueArray[i++] + " ");
		    }
		    Console.WriteLine();
    	}
    }
}

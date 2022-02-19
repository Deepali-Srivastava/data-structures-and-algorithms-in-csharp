/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace QueueLinkedListProject
{
    class QueueL
    {
        private Node front;
        private Node rear;

        public QueueL()
        {
            front = null;
            rear = null;
        }
        public int Size()
        {
            int s = 0;
            Node p = front;
            while (p != null )
            {
                s++;
                p = p.link;
            }
            return s;
        }

        public void Insert(int x)
        {
            Node temp;
            temp = new Node(x);

            if (front == null)		 /*If Queue is empty*/
                front = temp;
            else
                rear.link = temp;
            rear = temp;
        }

        public int Delete()
	    {
		    int x;
		    if( IsEmpty() )
                throw new System.InvalidOperationException("Queue Underflow");
		    x = front.info;
		    front = front.link;
		    return x;
	    }

        public int Peek()
	    {
		    if( IsEmpty() )
                throw new System.InvalidOperationException("Queue Underflow");
		    return front.info;
	    }

        public bool IsEmpty()
        {
            return ( front == null );
        }

        public void Display()
	    {
		    Node p = front;
		    if( IsEmpty() )
		    {
			    Console.WriteLine("Queue is empty");
			    return;
		    }

		    Console.WriteLine("Queue is : ");
		    while ( p != null )
		    {
			    Console.Write(p.info + " ");
			    p = p.link;
		    }
		    Console.WriteLine();
	    }
    }
}

/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PriorityQueueProject
{
    class PriorityQueueL
    {
        private Node front;

        public PriorityQueueL()
        {
            front = null;
        }

        public void Insert(int element, int elementPriority)
        {
            Node temp, p;

            temp = new Node(element, elementPriority);

            /*Queue is empty or element to be added has priority more than first element*/
            if (IsEmpty() || elementPriority < front.priority)
            {
                temp.link = front;
                front = temp;
            }
            else
            {
                p = front;
                while (p.link != null && p.link.priority <= elementPriority)
                    p = p.link;
                temp.link = p.link;
                p.link = temp;
            }
        }

        public int Delete()
	    {
		    int element;
		    if( IsEmpty() )
		        throw new System.InvalidOperationException("Queue Underflow");
		    else
		    {
			    element = front.info;
			    front = front.link;
		    }
		    return element;
	    }

        public bool IsEmpty()
        {
            return (front == null);
        }

        public void Display()
	    {
		    Node p = front;
		    if( IsEmpty() )
			    Console.WriteLine("Queue is empty\n");
		    else
		    {	
			    Console.WriteLine("Queue is :");
			    Console.WriteLine("Element  Priority");
			    while( p != null )
			    {
				    Console.WriteLine(p.info + "         " + p.priority );
				    p=p.link;
			    }
		    }
		    Console.WriteLine("");
	    }
    }
}

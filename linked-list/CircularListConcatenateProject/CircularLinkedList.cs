/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace CircularListConcatenateProject
{
    class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
            last = null;
        }
        
        public void DisplayList()
	    {
		    Node p;
		    if(last==null)
		    {
			    Console.WriteLine("List is empty\n");
			    return;
		    }
		
	    	p=last.link;
		    do 
		    {
			    Console.Write(p.info + " ");
			    p=p.link;
		    }while(p!=last.link);
		    Console.WriteLine();
	    }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            last = temp;
            last.link = last;
        }/*End of insertInEmptyList()*/

        public void InsertAtEnd(int data)
        {
            Node temp = new Node(data);
            temp.link = last.link;
            last.link = temp;
            last = temp;
        }/*End of insertAtEnd( )*/

        public void CreateList()
	    {
		    int i,n,data;
		
		    Console.Write("Enter the number of nodes : ");
		    n = Convert.ToInt32(Console.ReadLine());
			
		    if(n==0)
			    return;
		    Console.Write("Enter the element to be inserted : ");
		    data = Convert.ToInt32(Console.ReadLine());
		    InsertInEmptyList(data);
				
		    for(i=2; i<=n; i++)
		    {
			    Console.Write("Enter the element to be inserted : ");
			    data = Convert.ToInt32(Console.ReadLine());
			    InsertAtEnd(data);	
		    }
	    }

        public void InsertAfter(int data, int x)
	    {
		    Node p=last.link;
		    do
		    {
			    if(p.info==x)
				    break;
			    p=p.link;
		    }while(p!=last.link);

		    if(p==last.link && p.info!=x)  
		    	Console.WriteLine(x + " not present in the list");
		    else
		    {
			    Node temp=new Node(data);
			    temp.link=p.link;
			    p.link=temp;
			    if(p==last)
				    last=temp;
		    }
	    }

        public void DeleteFirstNode()
        {
            if (last == null) /*List is empty*/
                return;
            if (last.link == last) /*List has only one node*/
            {
                last = null;
                return;
            }
            last.link = last.link.link;
        }

        public void DeleteLastNode()
        {
            if (last == null) /*List is empty*/
                return;
            if (last.link == last) /*List has only one node*/
            {
                last = null;
                return;
            }
            Node p = last.link;
            while (p.link != last)
                p = p.link;
            p.link = last.link;
            last = p;
        }

        public void DeleteNode(int x)
	    {
		    if(last==null)/*List is empty*/
			    return;
			
		    if(last.link==last && last.info==x)  /*Deletion of only node*/  
		    {
			    last=null;
			    return;
		    }
		
		    if(last.link.info==x)  /*Deletion of first node*/    
		    {
		    	last.link=last.link.link;
			    return;
		    }
		
		    Node p=last.link;
		    while(p.link!=last.link)
		    {
			    if(p.link.info==x)     
				    break;
			    p=p.link;
		    }
		
		    if(p.link==last.link)
			    Console.WriteLine(x + " not found in the list");
		    else 
		    {
			    p.link=p.link.link;
			    if(last.info==x)  
				    last=p;
		    }
	    }/*End of deleteNode()*/

        public void Concatenate(CircularLinkedList list)
        {
            if (last == null)
            {
                last = list.last;
                return;
            }

            if (list.last == null)
                return;

            Node p = last.link;
            last.link = list.last.link;
            list.last.link = p;
            last = list.last;
        }
    }
}

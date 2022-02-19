/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace SingleListMergingProject
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is :   ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + "  ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if (p == null)
            {
                Console.WriteLine(x + " not found in list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " is at position " + position);
                return true;
            }
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
                p = p.link;

            p.link = temp;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            /*If list is empty*/
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            /*x is in first node,new node is to be inserted before first node*/
            if (x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            /*Find reference to predecessor of node containing x*/
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            if (k == 1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i = 1; i < k - 1 && p != null; i++) /*find a reference to k-1 node*/
                p = p.link;

            if (p == null)
                Console.WriteLine("You can insert only upto " + i + "th position");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start == null)
                return;

            if (start.link == null)
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;
        }

        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }
            /*Deletion of first node*/
            if (start.info == x)
            {
                start = start.link;
                return;
            }
            /*Deletion in between or at the end*/
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Element " + x + " not in list");
            else
                p.link = p.link.link;
        }

        
        public void BubbleSortExData()
        {
            Node end, p, q;

            for (end = null; end != start.link; end = p)
            {
                for (p = start; p.link != end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }
        
        public SingleLinkedList Merge1(SingleLinkedList list)
        {
            SingleLinkedList mergeList = new SingleLinkedList();
            mergeList.start = Merge1(start, list.start);
            return mergeList;
        }

        private Node Merge1(Node p1, Node p2)
        {
            Node startM;

            if (p1.info <= p2.info)
            {
                startM = new Node(p1.info);
                p1 = p1.link;
            }
            else
            {
                startM = new Node(p2.info);
                p2 = p2.link;
            }

            Node pM = startM;

            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = new Node(p1.info);
                    p1 = p1.link;
                }
                else
                {
                    pM.link = new Node(p2.info);
                    p2 = p2.link;
                }
                pM = pM.link;
            }

            /*If second list has finished and elements left in first list*/
            while (p1 != null)
            {
                pM.link = new Node(p1.info);
                p1 = p1.link;
                pM = pM.link;
            }

            /*If first list has finished and elements left in second list*/
            while (p2 != null)
            {
                pM.link = new Node(p2.info);
                p2 = p2.link;
                pM = pM.link;
            }
            return startM;
        }

        public SingleLinkedList Merge2(SingleLinkedList list)
        {
            SingleLinkedList mergeList = new SingleLinkedList();
            mergeList.start = Merge2(start, list.start);
            return mergeList;
        }

        private Node Merge2(Node p1, Node p2)
        {
            Node startM;

            if (p1.info <= p2.info)
            {
                startM = p1;
                p1 = p1.link;
            }
            else
            {
                startM = p2;
                p2 = p2.link;
            }

            Node pM = startM;

            while (p1 != null && p2 != null)
            {
                if (p1.info <= p2.info)
                {
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                }
                else
                {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }

            if (p1 == null)
                pM.link = p2;
            else
                pM.link = p1;
            return startM;
        }

        public void MergeSort()
        {
            start = MergeSortRec(start);
        }

        private Node MergeSortRec(Node listStart)
        {
            if (listStart == null || listStart.link == null)/*if list empty or has one element*/
                return listStart;

            /*if more than one element*/
            Node start1 = listStart;
            Node start2 = DivideList(listStart);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);
            return startM;
        }

        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while (q != null && q.link != null)
            {
                p = p.link;
                q = q.link.link;
            }
            Node start2 = p.link;
            p.link = null;
            return start2;
        }
    } 
}

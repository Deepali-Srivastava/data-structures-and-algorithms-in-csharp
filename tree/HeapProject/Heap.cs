/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace HeapProject
{
    class Heap
    {
        private int[] a;
        private int n;

        public Heap()
        {
            a = new int[10];
            n = 0;
            a[0] = 99999;
        }
        
        public Heap(int maxSize)
        {
            a = new int[maxSize];
            n = 0;
            a[0] = 99999;
        }
       
        public void Insert(int value)
        {
            n++;
            a[n] = value;
            RestoreUp(n);
        }

        private void RestoreUp(int i)
        {
            int k = a[i];
            int iparent = i / 2;

            while (a[iparent] < k) /*No sentinel - while(iparent>=1 && a[iparent]<k)*/
            {
                a[i] = a[iparent];
                i = iparent;
                iparent = i/2;
            }
            a[i] = k;
        }

        public int DeleteRoot()
        {
            if (n == 0)
                throw new System.InvalidOperationException("Heap is Empty");

            int maxValue = a[1];
            a[1] = a[n];
            n--;
            RestoreDown(1);
            return maxValue;
        }

        private void RestoreDown(int i)
        {
            int k = a[i];
            int lchild = 2 * i, rchild = lchild + 1;

            while (rchild <= n)
            {
                if (k >= a[lchild] && k >= a[rchild])
                {
                    a[i] = k;
                    return;
                }
                else if (a[lchild] > a[rchild])
                {
                    a[i] = a[lchild];
                    i = lchild;
                }
                else
                {
                    a[i] = a[rchild];
                    i = rchild;
                }
                lchild = 2 * i;
                rchild = lchild + 1;
            }

            /*If number of nodes is even*/
            if (lchild == n && k < a[lchild])
            {
                a[i] = a[lchild];
                i = lchild;
            }
            a[i] = k;
        }

        public void Display()
        {
    	    if (n == 0)
    	    {
    		    Console.WriteLine("Heap is empty");
    		    return;
    	    }
    	    Console.WriteLine("Heap size = " + n);
    	    for (int i = 1; i <= n; i++ )
    		    Console.Write(a[i] + " ");
    	    Console.WriteLine();
        }
    }
}

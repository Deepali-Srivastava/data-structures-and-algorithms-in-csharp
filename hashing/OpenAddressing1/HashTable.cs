/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace OpenAddressing1
{
    public class HashTable
    {
        private studentRecord[] array;
        private int m;  //size of the array
        int n; 			//number of records

        public HashTable() : this(11)
        {
        }

        public HashTable(int tableSize)
        {
            m = tableSize;
            array = new studentRecord[m];
            n = 0;
        }

        public void DisplayTable()
	    {
		    for(int i=0; i<m; i++)
		    {
			    Console.Write( "[" + i + "]  -->  " );
			
			    if(array[i]!=null && array[i].getstudentId()!=-1) 
				    Console.WriteLine( array[i].toString() );
			    else 
				    Console.WriteLine("___");
		    }
	    }

        public studentRecord Search(int key)
        {
            int h = hash(key);
            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].getstudentId() == key)
                    return array[location];
                location = (h + i) % m;
            }
            return null;
        }

        public void Insert1(studentRecord newRecord)
	    {
		    if (n >= m/2) 
		    {
			    rehash( nextPrime(2*m) );
			    Console.WriteLine( "New Table Size is : " + m );
		    }
		    Insert(newRecord);
	    }

        public void Insert(studentRecord newRecord)
        {

            int key = newRecord.getstudentId();
            int h = hash(key);

            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null || array[location].getstudentId() == -1)
                {
                    array[location] = newRecord;
                    n++;
                    return;
                }
                if (array[location].getstudentId() == key)
                    throw new System.InvalidOperationException("Duplicate key");
                location = (h + i) % m;
            }
        }

        public void Delete(int key)
	    {
		    int h = hash(key);				
		    int location=h;
		
		    for(int i=1; i<m ; i++)
		    {
			    if( array[location]==null)
				    return;
			    if(array[location].getstudentId() == key)
			    {
				    array[location].setstudentId(-1);
				    n--;
				    if (n > 0 && n <= m/8) 
				    {
					    rehash(nextPrime(m/2));
					    Console.WriteLine( "New Table Size is : " + m );
				    }
			    }	
			    location = (h+i)%m;
		    }
	    }

        int hash(int key)
        {
            return (key % m);
        }

        private void rehash(int newSize)
        {
            HashTable temp = new HashTable(newSize);

            for (int i = 0; i < m; i++)
                if (array[i] != null && array[i].getstudentId() != -1)
                    temp.Insert(array[i]);

            array = temp.array;
            m = newSize;
        }

        int nextPrime(int x)
        {
            while (!isPrime(x))
                x++;
            return x;
        }
        
        bool isPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

    }
}

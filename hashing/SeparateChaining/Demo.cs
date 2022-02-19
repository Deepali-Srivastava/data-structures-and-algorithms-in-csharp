/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace SeparateChaining
{
    public class Demo
    {
        static void Main(string[] args)
        {
            int id, choice;
            String name;

            Console.Write("Enter initial size of table : ");
            int size = Convert.ToInt32(Console.ReadLine());

            HashTable table = new HashTable(size);

            while (true)
            {
                Console.WriteLine("1.Insert a record");
                Console.WriteLine("2.Search a record");
                Console.WriteLine("3.Delete a record");
                Console.WriteLine("4.Display table");
                Console.WriteLine("5.Exit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student id : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter student name : ");
                        name = Console.ReadLine();

                        studentRecord aRecord = new studentRecord(id, name);

                        table.Insert(aRecord);
                        break;
                    case 2:
                        Console.Write("Enter a key to be searched : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        aRecord = table.Search(id);

                        if (aRecord == null)
                            Console.WriteLine("Key not found");
                        else
                            Console.WriteLine(aRecord.toString());

                        break;
                    case 3:
                        Console.Write("Enter a key to be deleted : ");
                        id = Convert.ToInt32(Console.ReadLine());
                        table.Delete(id);
                        break;
                    case 4:
                        table.DisplayTable();
                        break;
                }
            }
        }
    }
}



     
  


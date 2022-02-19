/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BaseConversion
{
    class Program
    {
        public static void ToBinary(int n)
	    {   
		    if( n == 0 )
			    return;
		    ToBinary( n/2 );
		    Console.Write( n%2 );	
	    }
        
        public static void ConvertBase(int n, int b)
	    {
		    if( n == 0 )
			    return;
		    ConvertBase(n/b, b);
		
		    int remainder = n % b;
		    if( remainder < 10 )
			    Console.Write(remainder);	
		    else
			    Console.Write((char) ( remainder - 10 + 'A' ));
	    }
        
        static void Main(string[] args)
        {
            int n;
		
		    Console.Write("Enter a positive decimal number : ");
		    n = Convert.ToInt32(Console.ReadLine());

		    Console.Write("Binary form : "); ToBinary(n);		
		    Console.WriteLine();
		    Console.Write("Binary form : "); ConvertBase(n, 2);	
		    Console.WriteLine();
		    Console.Write("Octal form : "); ConvertBase(n, 8);	
		    Console.WriteLine();
		    Console.Write("Hexadecimal form : "); ConvertBase(n, 16);	
		    Console.WriteLine();
	     }
    }
}


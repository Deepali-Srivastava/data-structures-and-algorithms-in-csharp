/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace PostfixProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            String infix;
			
		    Console.Write("Enter infix expression : ");
            infix = Console.ReadLine();
		
		    String postfix = infixToPostfix(infix);
		
		    Console.WriteLine("Postfix expression is : " + postfix);
		
		    Console.WriteLine("Value of expression : " + evaluatePostfix(postfix));
		}
        
        public static String infixToPostfix(String infix)
        {
            String postfix = "";

            StackChar st = new StackChar(20);

            char next, symbol;

            for (int i = 0; i < infix.Length; i++)
            {
                symbol = infix[i];

                if (symbol == ' ' || symbol == '\t') /*ignore blanks and tabs*/
                    continue;

                switch (symbol)
                {
                    case '(':
                        st.Push(symbol);
                        break;
                    case ')':
                        while ((next = st.Pop()) != '(')
                            postfix = postfix + next;
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '%':
                    case '^':
                        while (!st.IsEmpty() && Precedence(st.Peek()) >= Precedence(symbol))
                            postfix = postfix + st.Pop();
                        st.Push(symbol);
                        break;
                    default: /*operand*/
                        postfix = postfix + symbol;
                        break;
                }
            }
            while (!st.IsEmpty())
                postfix = postfix + st.Pop();
            return postfix;
        }

        public static int Precedence(char symbol)
        {
            switch (symbol)
            {
                case '(':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }

        public static int evaluatePostfix(String postfix)
        {
            StackInt st = new StackInt(20);

            int x, y;
            for (int i = 0; i < postfix.Length; i++)
            {
                if (Char.IsDigit(postfix[i]))
                    st.Push (Convert.ToInt32(Char.GetNumericValue(postfix[i])));
                else
                {
                    x = st.Pop();
                    y = st.Pop();
                    switch (postfix[i])
                    {
                        case '+':
                            st.Push(y + x); break;
                        case '-':
                            st.Push(y - x); break;
                        case '*':
                            st.Push(y * x); break;
                        case '/':
                            st.Push(y / x); break;
                        case '%':
                            st.Push(y % x); break;
                        case '^':
                            st.Push(power(y, x));
                            break;
                    }
                }
            }
            return st.Pop();
        }

        public static int power(int b, int a)
        {
            int i, x = 1;
            for (i = 1; i <= a; i++)
                x = x * b;
            return x;
        }
    }
}

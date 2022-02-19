/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BinaryTreeProject
{
    class Node
    {
        public Node lchild;
        public char info;
        public Node rchild;

        public Node(char ch)
        {
            info = ch;
            lchild = null;
            rchild = null;
        }
    }
}

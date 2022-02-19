/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace SeparateChaining
{
    public class Node
    {
        public studentRecord info;
        public Node link;

        public Node(studentRecord rec)
        {
            info = rec;
            link = null;
        }
    }
}

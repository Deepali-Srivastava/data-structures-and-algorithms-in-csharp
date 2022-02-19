/*
Copyright (C) Deepali Srivastava - All Rights Reserved
This code is part of DSA course available on CourseGalaxy.com    
*/

using System;

namespace BinaryTreeSort
{
    class BinarySearchTree
    {
        private TreeNode root;
        private static int k;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Inorder(int[] a)
        {
            k = 0;
            Inorder(root, a);
        }

        private void Inorder(TreeNode p, int[] a)
        {
            if (p == null)
                return;
            Inorder(p.lchild, a);
            a[k++] = p.info;
            Inorder(p.rchild, a);
        }

        bool IsEmpty()
        {
            return (root == null);
        }
        
        public void Insert(int x)
        {
            root = Insert(root, x);
        }

        private TreeNode Insert(TreeNode p, int x)
        {
            if (p == null)
                p = new TreeNode(x);
            else if (x < p.info)
                p.lchild = Insert(p.lchild, x);
            else
                p.rchild = Insert(p.rchild, x);
            return p;
        }
    }
}

﻿using System;

namespace DS_BinarySearchTree
{
    class BinarySearchTree
    {
        TreeNode root;
        int treeSize = 0;
        public void Insert(int data)
        {
            if(root == null)
            {
                root = new TreeNode(data);
                treeSize++;
            }
            else
            {
                root.Insert(data);
                treeSize++;
            }
        }
        public void Display()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            else
            {
                root.InOrderTraversal();
            }
        }
    }
}

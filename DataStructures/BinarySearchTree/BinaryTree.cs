using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }
        Node root;

        public BinaryTree()
        {
            root = null;
        }

        public Node Search(int key)
        {
            return null;
        }

        public Node FindSucc(int key)
        {
            return null;
        }
        void Insert(int key)
        {
            root = InsertData(root, key);
        }
        public Node InsertData(Node root,int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }
            if(key<root.key)
            {
                root.left = InsertData(root.left, key);
            }
            else if(key>root.key)
            {
                root.right = InsertData(root.right, key);
            }
            return root;
        }
        public Node Search(Node root, int key)
        {
            if (root == null|| root.key == key)
            {
                return root;
            }
            if (key < root.key)
            {
                return Search(root.left, key);
            }
            else if (key > root.key)
            {
                return Search(root.right, key);
            }
            return root;
        }
        public static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(20);
            binaryTree.Insert(10);
            binaryTree.Insert(25);
            binaryTree.Insert(5);
            binaryTree.Insert(22);
            binaryTree.Insert(7);
            binaryTree.Insert(6);
            binaryTree.Insert(19);
            binaryTree.Insert(26);
            binaryTree.Insert(2);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(16);
            binaryTree.Insert(19);
            binaryTree.Search(6);
        }
    }
}

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

            public Node()
            { }
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
        static Node pre = new Node(), suc = new Node();

        static void FindPredSuccecessor(Node root,int key)
        {
            if (root == null)
                return;
            if(root.key == key)
            {
                if (root.left != null)
                {
                    Node temp = root.left;
                    while(temp.right != null)
                    {
                        temp = temp.right;
                    }
                    pre = temp;
                }
                if(root.right != null)
                {
                    Node temp = root.right;
                    while(temp.left != null)
                    {
                        temp = temp.left;
                    }
                    suc = temp;

                }
                return;
            }
            if(root.key > key)
            {
                suc = root;
                FindPredSuccecessor(root.left, key);
            }
            else
            {
                pre = root;
                FindPredSuccecessor(root.right, key);
            }
        }
        public static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(50);
            binaryTree.Insert(30);
            binaryTree.Insert(20);
            binaryTree.Insert(40);
            binaryTree.Insert(70);
            binaryTree.Insert(60);
            binaryTree.Insert(80);
     
            FindPredSuccecessor(binaryTree.root, 70);
            if (pre != null)
                Console.WriteLine("Predecessor is " + pre.key);
            else
                Console.WriteLine("No Predecessor");

            if (suc != null)
                Console.WriteLine("Successor is " + suc.key);
            else
                Console.WriteLine("No Successor");
        }
    }
}

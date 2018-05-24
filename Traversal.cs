using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    public class Traversal
    {
        private Node root = null;
        private Node nextRoot = null;
      

        public Traversal()
        {

        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            Node element = root;
            if (element == null)
            {
                root = newNode;
                return;
            }
            else
            {
                Add(root, newNode);
            }
        }
        public void Add(Node current ,Node toadd)
        {
            if(current.left == null)
            {
                current.left = toadd;
            }
            else
            {
                Add(current.left, toadd);
            }
        }
        //public void Insert(int data)
        //{
        //    Node newNode = new Node(data);
        //    Node element = root;
        //    if (element == null)
        //    {
        //        root = newNode;
        //        return;
        //    }
        //    else
        //    {
        //        while (element != null)
        //        {
        //            if (element.left == null)
        //            {
        //                element.left = newNode;
        //                // nextRoot = newNode;
        //                return;
        //            }
        //            else if (element.right == null)
        //            {
        //                // element = nextRoot;
        //                element.right = newNode;
        //                // nextRoot = newNode;
        //                return;

        //            }
        //            else if (element.left != null || element.right != null)
        //            {
        //                if (element.left != null)
        //                {
        //                    Node current = element.left;
        //                    if (current.left == null)
        //                    {
        //                        element = current;
        //                    }
        //                    else if (current.right == null)
        //                    {
        //                        element = current;
        //                    }

        //                }
        //                else if (element.right != null)
        //                {
        //                    Node current = element.right;
        //                    if (current.left == null)
        //                    {
        //                        element = current;
        //                    }
        //                    else if (current.right == null)
        //                    {
        //                        element = current;
        //                    }
        //                    else
        //                    {
        //                        element = element.left;
        //                    }
        //                }

        //            }
        //            //else if (element.left != null || element.right != null)
        //            //{
        //            //    if (element.left != null)
        //            //    {
        //            //        Node current = element.left;
        //            //        if (current.left == null)
        //            //        {
        //            //            element = current;
        //            //        }
        //            //        else if (current.right == null)
        //            //        {
        //            //            element = current;
        //            //        }

        //            //    }
        //            //    if (element.right != null)
        //            //    {
        //            //        Node current = element.right;
        //            //        if (current.left == null)
        //            //        {
        //            //            element = current;
        //            //        }
        //            //        else if (current.right == null)
        //            //        {
        //            //            element = current;
        //            //        }
        //            //        else
        //            //        {
        //            //            element = element.left;
        //            //        }
        //            //    }
        //            //}
        //        }
        //    }
        //}
        //public void Preorder(Node root)
        //{
        //    if (root != null)
        //    {
        //        Console.Write(root.item + " ");
        //        Preorder(root.left);
        //        Preorder(root.right);
        //    }
        //}
        //public void Inorder(Node root)
        //{
        //    if (root != null)
        //    {
        //        Inorder(root.left);
        //        Console.Write(root.item + " ");
        //        Inorder(root.right);
        //    }
        //}
        //public void Postorder(Node root)
        //{
        //    if (root != null)
        //    {
        //        Postorder(root.left);
        //        Postorder(root.right);
        //        Console.Write(root.item + " ");
        //    }
        //}
    }
}

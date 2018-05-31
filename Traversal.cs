using System;

namespace TreeTraversal
{
    public class Traversal
    {
        private Node root = null;
        private int count = 0;
        private int heightLimit = 3;
        private int rightTreeLimit = 1;
        private int previouseHeight = 0;

        public Traversal()
        {

        }
        public Node GetRoot
        {
            get
            {
                return root;
            }
        }
      
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            Node element = root;
            if (element == null)
            {
                root = newNode;
                count++;
                return;
            }
            else
            {
                int iteration =  0;
                Add(root, newNode, iteration);
            }
        }
        public void Add(Node current, Node toAdd, int iteration)
        {
            iteration++;
            if (current.left == null)
            {
                current.left = toAdd;
                count++;
            }
            else if (current.right == null)
            {
                current.right = toAdd;
                count++;
                if (count == heightLimit)
                {
                    heightLimit = 2 * count + 1;
                    previouseHeight = rightTreeLimit;
                    rightTreeLimit = rightTreeLimit * 2;
                }
              
            }

            else if (count < (heightLimit - rightTreeLimit))
            {
                if (previouseHeight == 1 || count < (heightLimit - rightTreeLimit - previouseHeight) || iteration < previouseHeight)
                {
                    Add(current.left, toAdd, iteration);
                }
                else
                {
                    Add(current.right, toAdd, iteration);
                }
            }
            else
            {
                if (previouseHeight == 1 || iteration < previouseHeight || count >= heightLimit - previouseHeight)
                {
                    Add(current.right, toAdd, iteration);
                }
                else
                {
                    Add(current.left, toAdd, iteration);
                }
            }
        }

        public void Preorder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.item + " ");
                Preorder(node.left);
                Preorder(node.right);
            }
        }
        public void Inorder(Node node)
        {
            if (node != null)
            {
                Inorder(node.left);
                Console.Write(node.item + " ");
                Inorder(node.right);
            }
        }
        public void Postorder(Node node)
        {
            if (node != null)
            {
                Postorder(node.left);
                Postorder(node.right);
                Console.Write(node.item + " ");
            }
        }
    }
}

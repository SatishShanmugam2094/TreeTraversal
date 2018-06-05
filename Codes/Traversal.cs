using System;

namespace TreeTraversal
{
    public class Traversal
    {
        private Node root = null;
        private int count = 0;
        private int heightLimit = 3;
        private bool isAdded = false;
        private int height = 0;

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
                int heightIteration = -1;
                Add(root, newNode, heightIteration);
                isAdded = false;
            }
        }

        public void Add(Node current, Node toAdd, int iterationOfHeight)
        {
            iterationOfHeight++;

            if (current != null)
            {
                if (current.left == null)
                {
                    current.left = toAdd;
                    count++;
                    isAdded = true;
                    return;
                }
                else if (current.right == null)
                {
                    current.right = toAdd;
                    count++;
                    if (count == heightLimit)
                    {
                        height++;
                        heightLimit = 2 * count + 1;
                    }
                    isAdded = true;
                    return;
                }
                if (!isAdded && iterationOfHeight < height)
                {
                    Add(current.left, toAdd, iterationOfHeight);
                }
                if (!isAdded && iterationOfHeight < height)
                {
                    Add(current.right, toAdd, iterationOfHeight);
                }

            }

        }

        public void LevelOrder(Node node)
        {
            if (node == null)
            {
                Console.WriteLine("The tree is empty");
                return;
            }

            int level = 1;
            while (PrintLevel(node, level))
            {
                level++;
            }

        }

        public bool PrintLevel(Node current, int level)
        {
            if (current == null)
            {
                return false;
            }

            if (level == 1)
            {
                Console.Write(current.item + " ");
                return true;
            }

            bool leftSide = PrintLevel(current.left, level - 1);
            bool rightSide = PrintLevel(current.right, level - 1);
            return true;
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

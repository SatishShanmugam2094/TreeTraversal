using System;

namespace TreeTraversal
{
    public class Traversal
    {
        private Node root = null;
        private Node nodeOfIndex = null;
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
                root.index = count;
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
                    current.left.index = count;
                    count++;
                    isAdded = true;
                    return;
                }
                else if (current.right == null)
                {
                    current.right = toAdd;
                    current.right.index = count;
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
            while (level < heightLimit)
            {
                PrintLevel(node, level);
                level++;
            }

        }

        public void PrintLevel(Node current, int level)
        {
            if (current == null)
            {
                return;
            }

            if (level == 1)
            {
                Console.Write(current.item + " ");
                return;
            }
            PrintLevel(current.left, level - 1);
            PrintLevel(current.right, level - 1);
            return;
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

        public void ConvertingHeap()
        {
            for (int index = (count - 2) / 2; index >= 0; index--)
            {
                MaxHeapify(root, index, count);
            }
        }

        public void MaxHeapify(Node current, int index, int numberOfNodes)
        {
            Node exactNode = IndexOfNode(index);
            nodeOfIndex = null;
            Node leftSide = exactNode.left;
            Node rightSide = exactNode.right;
            Node largest = exactNode;
            if (leftSide != null && leftSide.item > exactNode.item)
            {
                largest = leftSide;
            }
            if (rightSide != null && rightSide.item > largest.item)
            {
                largest = rightSide;
            }
            if (largest != exactNode)
            {
                int temp = exactNode.item;
                exactNode.item = largest.item;
                largest.item = temp;
                MaxHeapify(root, largest.index, numberOfNodes);
            }
        }

        public Node IndexOfNode(int index)
        {
            int treeLevel = 1;
            Node requirednode = new Node();
            while (treeLevel <= index + 1)
            {
                requirednode = LevelNode(root, treeLevel, index);
                if (requirednode != null)
                {
                    break;
                }
                treeLevel++;
            }
            return nodeOfIndex;
        }

        public Node LevelNode(Node current, int level, int indexofNode)
        {
            if (current == null)
            {
                return null;
            }

            if (level == 1)
            {
                if (current.index == indexofNode)
                {
                    nodeOfIndex = current;
                    return nodeOfIndex;
                }
                else
                {
                    return null;
                }

            }
            LevelNode(current.left, level - 1, indexofNode);
            LevelNode(current.right, level - 1, indexofNode);
            return nodeOfIndex;
        }
    }
}

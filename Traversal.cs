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
                int iteration = 0;
                Add(root, newNode, iteration);
            }
        }
        public void Add(Node current, Node toadd, int iteration)
        {
            iteration++;
            if (current.left == null)
            {
                current.left = toadd;
                count++;
            }
            else if (current.right == null)
            {
                current.right = toadd;
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
                    Add(current.left, toadd, iteration);
                }
                else
                {
                    Add(current.right, toadd, iteration);
                }
            }
            else
            {
                if (previouseHeight == 1 || iteration < previouseHeight || count >= heightLimit - previouseHeight)
                {
                    Add(current.right, toadd, iteration);
                }
                else
                {
                    Add(current.left, toadd, iteration);
                }
            }

        }

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

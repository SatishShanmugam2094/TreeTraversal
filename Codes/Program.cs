using System;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {

            Traversal tree = new Traversal();
            for (int i = 1; i <= 7; i++)
            {
                tree.Insert(i);
            }

            Console.WriteLine("Pre-Order elements");
            tree.Preorder(tree.GetRoot);
            Console.WriteLine(" \nInorder elements");
            tree.Inorder(tree.GetRoot);
            Console.WriteLine(" \nPost-order elements");
            tree.Postorder(tree.GetRoot);
            Console.WriteLine(" \nLevel-order elements");
            tree.LevelOrder(tree.GetRoot);
            tree.ConvertingHeap();
            Console.WriteLine(" \nMax heap Tree");
            tree.LevelOrder(tree.GetRoot);
            tree.Deletion();
            Console.WriteLine(" \nAfter Deletion the max heap tree");
            tree.LevelOrder(tree.GetRoot);
            Console.Read();
        }
    }
}

using System;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TREE STRUCTURE");
            Console.WriteLine("Enter integer elements you want to form a tree with including  a space between each element in a single line ");
            string[] elements = Console.ReadLine().Split(' ');
            Traversal tree = new Traversal();
            for (int i = 0; i < elements.Length; i++)
            {
                tree.Insert(Convert.ToInt32(elements[i]));
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
            Console.WriteLine(" \nDeletion");
            Console.WriteLine(" The deleted root is {0}", tree.Deletion());
            Console.WriteLine(" \nAfter Deletion the max heap tree");
            tree.LevelOrder(tree.GetRoot);
            Console.Read();
        }
       
    }
}

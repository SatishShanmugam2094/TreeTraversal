using System;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Traversal tree = new Traversal();
            for(int i = 1;i<=15;i++)
            {
                tree.Insert(i);
            }
            
            Console.WriteLine("Pre-Order elements");
            tree.Preorder(tree.GetRoot);
            Console.WriteLine(" \nInorder elements");
            tree.Inorder(tree.GetRoot);
            Console.WriteLine(" \nPost-order elements");
            tree.Postorder(tree.GetRoot);
            Console.Read();
        }
    }
}

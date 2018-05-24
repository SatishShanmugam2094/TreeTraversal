using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Traversal tree = new Traversal();
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            tree.Insert(11);
            Console.WriteLine("Inorder Traversal : ");
            // BST.Inorder();
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
   public class Node
    {
        public Node left;
        public Node right;
        public int item;

        public Node(int _value)
        {
            item = _value;
        }
    }
}

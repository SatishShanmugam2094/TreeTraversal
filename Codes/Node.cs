﻿namespace TreeTraversal
{
    public class Node
    {
        public Node left = null;
        public Node right = null;
        public int item;
        public int index;

        public Node ()
        {

        }
        public Node(int _value)
        {
            item = _value;
        }
    }
}

﻿namespace Stack
{
    class Node
    {
        public int data { get; set; }

        public Node next { get; set; }

        public Node(int data)
        {
           this.data = data;
            next = null;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class Node
    {
        public Node(int value) 
        {
            Value = value;
        
        }
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node Previous { get; set; }
        public override string ToString()
        {
            return $"{Previous?.Value}<-{Value}->{Next?.Value}";
        }
    }
}

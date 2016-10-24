using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class Node
    {
        public string Data { get; set; }

        public Node Next { get; set; }

        public Node()
        {
            Data = null;
            Next = null;
        }

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
}

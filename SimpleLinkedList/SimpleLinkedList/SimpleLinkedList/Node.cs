using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class Node
    {
        // attributes
        private string data; // data to store
        private Node next; // connection to the next node

        // constructor
        public Node(string str)
        {
            data = str;
            next = null;
        }

        // properties
        public string Data
        {
            get { return data; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        //ToString
        public override string ToString()
        {
            string str = "";

            //Create the string to return based on next value
            if (next != null)
            {
                str = Data;
            }
            else
            {
                str = Data + " (Last Node)";
            }

            return str;
        }
    }
}

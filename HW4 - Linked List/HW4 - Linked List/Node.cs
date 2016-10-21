using System;
//JaJuan Webster
//HW-4: Linked List
//Professor Steve Maier

namespace HW4_Linked_List
{
    class Node
    {
        //Attributes
        private String data;    // The data in this node
        private Node next;	// The next node in the list
        private Node previous;	// The previous node in the list

        /// <summary>
        /// Gets and sets the data of this node
        /// </summary>
        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        /// <summary>
        /// Gets and sets the next node
        /// </summary>
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        /// <summary>
        /// Gets and sets the previous node
        /// </summary>
        public Node Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        /// <summary>
        /// Creates a new Node with data
        /// </summary>
        /// <param name="data">The data to hold in this node</param>
        public Node(String data)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }
    }
}

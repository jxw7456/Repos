using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//JaJuan Webster
//HW-4: Linked List
//Professor Steve Maier

namespace HW4_Linked_List
{
    class LinkedList : IList
    {
        //Attributes
        private Node head = null;
        private Node tail = null;
        private int count = 0;

        //Add a new Node object to the end of the list.
        public void Add(String data)
        {
            //Create new node
            Node newNode = new Node(data);

            //If nothing is in the list
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                count++;
                return;
            }

            //If we get here there's something in the list
            Node current = head;

            while (current.Next != null)
            {
                //Move to next node in the list
                current = current.Next;
            }

            //End of the list
            current.Next = newNode;
            tail = newNode;
            count++;
        }

        //Inserts a Node object at a specified location in the list.
        public void Insert(String data, int index)
        {
            //If the index is <= 0, insert the data in the beginning
            if (index <= 0)
            {
                Node newNode = new Node(data);
                Add(newNode.Data);
            }

            //If the head is != null, loop until the index and insert the data
            if (head != null)
            {
                Node newNode = new Node(data);

                Node current = head;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Previous.Next = newNode;
                newNode.Previous = current.Previous;
                newNode.Next = current;
                current.Previous = newNode;

                count++;
            }

            //If the index is >= count, insert the data at the end
            if (index >= count)
            {
                Node newNode = new Node(data);
                Add(newNode.Data);
            }
        }

        //Remove a Node from the list and return the data
        public String Remove(int index)
        {
            Node current = head;
            string data = "";

            //If index is invalid, you cannot remove anything
            if (index < 0 || index > count)
            {
                data = null;
            }

            //If index == 0, remove the current head and store the next node as the head
            if (index == 0)
            {
                data = head.Data;
                head = current.Next;

                current.Previous = null;
                count--;
            }

            //If the index is at the end, remove the current tail and set the preceding node to the tail
            if (index == count - 1)
            {
                data = tail.Data;
                tail = null;
                tail = tail.Previous;

                count--;
            }

            //If the index is between the middle and the end, loop to the index and remove the node and then connect the two around it
            if (index > 0 && index < count)
            {
                for (int i = 0; i < index + 1; i++)
                {
                    current = current.Next;
                }

                data = current.Data;

                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;

                count--;
            }

            return data;
        }

        //Return the element at this index in the list.
        public String GetElement(int index)
        {
            //Check if index is less than zero or greater than count
            if (index < 0 || index >= count)
            {
                return null; // returns null if so
            }

            //Loops a set number of times and returns the data

            Node current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        //Clears the list
        public void Clear()
        {
            Node current = head;

            //Loops through and sets each node to null
            for (int i = 0; i < count - 1; i++)
            {
                current = current.Next;
                current.Previous = null;
            }

            count = 0;
            head = null;
            tail = null;
        }

        //Returns a count of the number of nodes in the linked list
        public int Count { get { return count; } }
    }
}

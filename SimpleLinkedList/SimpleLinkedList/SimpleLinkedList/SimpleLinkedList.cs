using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class SimpleLinkedList
    {
        Node head = null;
        private int count = 0;

        public SimpleLinkedList()
        {

        }

        public void Add(string data)
        {
            if (data == null)
                throw new ArgumentNullException("data", "You can't add a null object you idiot from MIT...");

            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node currentNode = head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
        }

        public void Traverse()
        {
            if (head == null)
            {
                Console.WriteLine("Why are you empty??");
            }
            else
            {
                Node currentNode = head;
                do
                {
                    Console.WriteLine(currentNode.Data);
                    currentNode = currentNode.Next;
                } while (currentNode != null);
            }
        }

        //Return the element at this index in the list.
        public String GetData(int index)
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
            }

            count = 0;
            head = null;
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

            //If the index is >= count, insert the data at the end
            if (index >= count)
            {
                Node newNode = new Node(data);
                Add(newNode.Data);
            }
        }

        public int Count { get { return count; } }
    }
}

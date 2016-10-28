using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class SimpleLinkedList
    {
        //Attributes
        private Node head = null;
        private int count = 0;

        //Adds item to the list
        public void Add(string str)
        {
            //Create new node
            Node newNode = new Node(str);

            if (head == null)
            {
                head = newNode;
                count++;
                return;
            }

            //If there's something in the list
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            //End of the list
            current.Next = newNode;
            count++;
        }

        //Insert string into the list
        public void Insert(string str, int position)
        {
            if (head == null)
            {
                Add(str);
                return;
            }

            if (position < 0)
            {
                Console.WriteLine("Minimum allowed position value is zero");
                return;
            }

            //Replaces the head
            if (position == 0)
            {
                Node newNode = new Node(str);
                newNode.Next = head;
                head = newNode;
                count++;
                return;
            }

            //If position >= to count, add it to the end of the list
            if (position >= count)
            {
                Add(str);
                return;
            }

            Node previous = head;
            Node current = head;
            int location = 0;
            while (location < count)
            {
                if (location == position)
                {
                    Node newNode = new Node(str);

                    newNode.Next = current;
                    previous.Next = newNode;
                    count++;
                    return;
                }
                location++; //Next node
                previous = current;
                current = current.Next;
            }
        }
        
        //Print all data
        public void Traverse()
        {
            if (head == null)
            {
                Console.WriteLine("Why is your list empty?");
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                Console.WriteLine(current);

                //Next node
                current = current.Next;
            }
            Console.WriteLine(current);
        }

        //Put list in alphabetical order
        public void InsertSorted(string str)
        {
            //If nothing is in the list
            if (count == 0)
            {
                Add(str);
                count = 1;
                return;
            }

            //If list is filled
            if (count != 0)
            {
                //If string precedes the head
                if (String.Compare(str, head.Data) < 0)
                {
                    Insert(str, 0);
                    return;
                }

                //If string is greater than the end
                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                if (String.Compare(str, current.Data) > 0)
                {
                    Insert(str, count + 1);
                    return;
                }

                Node current2 = head;

                while (current2.Next != null)
                {
                    int i = 0;

                    //If it precedes the current node
                    if (String.Compare(str, current2.Data) < 0)
                    {
                        Insert(str, i);
                        return;
                    }

                    //If it comes after the current node
                    if (String.Compare(str, current2.Data) > 0)
                    {
                        Insert(str, i + 1);
                        return;
                    }

                    //If they are equal
                    if (String.Compare(str, current2.Data) == 0)
                    {
                        Insert(str, i + 1);
                        return;
                    }
                    i++;
                    current2 = current2.Next;
                }
            }
        }
    }
}

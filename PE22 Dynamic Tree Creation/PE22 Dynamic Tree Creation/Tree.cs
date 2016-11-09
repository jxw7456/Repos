using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//JaJuan Webster
//PE22 Dynamic Tree Creation
//Professor Maier

namespace PE22_Dynamic_Tree_Creation
{
    class Tree
    {
        //Attributes
        private Node root = null;

        //Takes the data to insert, as well as the node to insert into
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }

            else
            {
                Insert(data, root);
            }
        }

        //Loops and print out the data from each node
        public void Print()
        {
            Print(root, 0);
        }

        //Private insert
        private void Insert(int data, Node node)
        {
            if (data < node.Data)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(data);
                }

                else
                {
                    Insert(data, node.Left);
                }
            }

            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(data);
                }

                else
                {
                    Insert(data, node.Right);
                }
            }
        }

        //Private print
        private void Print(Node node, int level)
        {
            if (node != null)
            {
                //Print pipe characters
                for (int i = 0; i < level; i++)
                {
                    Console.Write("|");
                }

                Console.WriteLine(node.Data);

                //Increment
                level++;

                //Recursion
                Print(node.Left, level);

                Print(node.Right, level);
            }
        }
    }
}

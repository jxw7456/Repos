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
    class Node
    {
        //Attributes 
        private int data;
        private Node left;
        private Node right;

        //Constructor
        public Node(int d)
        {
            data = d;
            left = null;
            right = null;
        }

        //Properties
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        //Left Node
        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        //Right Node
        public Node Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}

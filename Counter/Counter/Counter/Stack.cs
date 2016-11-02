using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: JaJuan Webster
//Instructor: Professor Maier
//Exam 2

namespace Counter
{
    //implement the IStack interface
    class Stack : IStack
    {
        List<string> words = new List<string>();

        // pushes a new string onto the stack
        public void Push(string str)
        {
            words.Insert(0, str);
        }

        // pops the top item off a stack. returns a null if there is no data
        public string Pop()
        {
            if (words.Count == 0)
            {
                return null;
            }

            string top = words[0];

            if (words[0] != null)
            {
                words.RemoveAt(0);
            }

            return top;
        }

        // tells if the stack is empty. return true if empty, otherwise returns false
        public bool IsEmpty()
        {
            if (words.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}

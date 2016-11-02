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
    //implement the IQueue interface
    class Queue : IQueue
    {
        List<string> words = new List<string>();

        // puts a new string onto the end of the queue
        public void Enqueue(string str)
        {
            words.Add(str);
        }

        // returns the top item off a queue. returns a null if there is no data
        public string Dequeue()
        {
            if (words.Count == 0)
            {
                return null;
            }

            words.RemoveAt(words.Count);
            return words[words.Count];
        }

        // tells if the queue is empty. return true if empty, otherwise returns false
        public Boolean IsEmpty()
        {
            if (words.Count == 0)
            {
                return true;
            }

            return false;
        }
    }
}

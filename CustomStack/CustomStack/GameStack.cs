using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    class GameStack : IStack
    {
        private string[] data = new string[12];

        //Attributes
        int popValue = 10;
        int pushValue = 0;
        int popMax = 11;

        //Number of items in the stack
        public int Count
        {
            get { return data.Length; }
        }

        //Determine if stack is empty
        public bool IsEmpty
        {
            get
            {
                if (Count == 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        //Return top value, but don't remove it from the stack
        public string Peek()
        {
            return data[data.Length - 1];
        }

        //Return top value, and remove it from the stack
        public string Pop()
        {
            //Get top value
            string topValue = data[popMax];

            //Sets top value to new preceding value
            data[popMax] = data[popValue];

            if (popValue > 0)
            {
                popValue--;
            }

            return topValue;
        }

        //Add new entry to end of the list
        public void Push(string str)
        {
            //Once an index is filled with a value move to the next available index.
            data[pushValue] = str;

            if (pushValue < 12)
            {
                pushValue++;
            }
        }
    }
}

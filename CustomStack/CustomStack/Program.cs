using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Stack
            GameStack gameStack = new GameStack();

            //Push values
            gameStack.Push("Picking up an item.");
            gameStack.Push("Shooting weapon");
            gameStack.Push("Dropping an item");
            gameStack.Push("Healing self");
            gameStack.Push("Move back");
            gameStack.Push("Move forward");
            gameStack.Push("Move forward");
            gameStack.Push("Move forward");
            gameStack.Push("Move left");
            gameStack.Push("Move left");
            gameStack.Push("Die");

            //Get the top value
            for (int i = 0; i < gameStack.Count; i++)
            {
                Console.WriteLine(gameStack.Pop());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

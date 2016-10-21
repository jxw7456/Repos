using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//JaJuan Webster
//HW-4: Linked List
//Professor Steve Maier

namespace HW4_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList Object
            LinkedList linkedList = new LinkedList();
            
            //Loop control variable
            bool valid = true;

            Console.WriteLine("Welcome to JaJuan's Linked List");          
            

            while (valid)
            {
                // Prompts user
                Console.WriteLine();
                Console.Write("Type something: ");

                string str = Console.ReadLine();

                //Quit
                if (str == "q" || str == "quit")
                {
                    valid = false;
                    Console.WriteLine("Thanks for typing!");
                    Console.ReadLine();
                }

                //Print
                else if (str == "print")
                {
                    Console.WriteLine("The following items are in the list: ");
                    for (int i = 0; i < linkedList.Count; i++)
                    {
                        Console.WriteLine(linkedList.GetElement(i));
                    }
                }

                //Count
                else if (str == "count")
                {
                    Console.WriteLine("There are currently " + linkedList.Count + " items in the list");
                }

                //Clear
                else if (str == "clear")
                {
                    linkedList.Clear();
                    Console.WriteLine("The list has been cleared");
                }

                //Remove
                else if (str == "remove")
                {
                    Random rng = new Random();
                    int num = rng.Next(linkedList.Count);
                    linkedList.Remove(num);
                }

                //Scramble
                else if (str == "scramble")
                {
                    Random rng = new Random();
                    int num = rng.Next(linkedList.Count);
                    string data = linkedList.Remove(num);
                    int rngNum = rng.Next(linkedList.Count);
                    linkedList.Insert(data, rngNum);
                    Console.WriteLine("A random element has been moved to a new position");
                }

                //Adds user typed words to the list
                else
                {
                    linkedList.Add(str);
                    Console.WriteLine("'" + str + "' has been added to the list.");
                }
            }
        }
    }
}

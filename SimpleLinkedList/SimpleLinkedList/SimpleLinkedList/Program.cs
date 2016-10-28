using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleLinkedList myList = new SimpleLinkedList();

            myList.InsertSorted("Webster");
            myList.InsertSorted("Mia");
            myList.InsertSorted("JaJuan");
            myList.InsertSorted("Bobby");
            myList.InsertSorted("Tommy");
            myList.InsertSorted("Louis");
            myList.InsertSorted("Malcolm");
            myList.InsertSorted("Zeus");
            myList.InsertSorted("Karen");
            myList.InsertSorted("Maier");

            myList.Traverse();

            /*
            for (int i = 0; i < myList.Count; i++)
            {                
                Console.WriteLine(myList.GetData(i));
            }

            myList.Insert("Pops", 0);
            Console.WriteLine(myList.GetData(0));
            myList.Traverse();

            
            //INDENT
            Console.WriteLine();

            myList.Clear();
            */

            Console.ReadLine();
        }
    }
}

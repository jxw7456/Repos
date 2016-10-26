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
            try
            {
                /*
                myList.Add("Imani");
                myList.Add("JaJuan");
                myList.Add("Jon");
                myList.Add("Jordan");
                myList.Add("Kat");                
                myList.Add("Malcolm");
                */               
            }
            catch(Exception ex)
            {
                Console.WriteLine("You had an exception...");
                Console.WriteLine(ex);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            myList.Traverse();

            //INDENT
            Console.WriteLine();

            for (int i = 0; i < myList.Count; i++)
            {                
                Console.WriteLine(myList.GetData(i));
            }

            /*
            myList.Insert("Pops", 0);
            Console.WriteLine(myList.GetData(0));
            myList.Traverse();*/

            //INDENT
            Console.WriteLine();

            myList.InsertSorted("");
            myList.Traverse();

            //INDENT
            Console.WriteLine();

            myList.Clear();
            myList.Traverse();

            Console.ReadLine();
        }
    }
}

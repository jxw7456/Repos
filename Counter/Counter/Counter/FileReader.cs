using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: JaJuan Webster
//Instructor: Professor Maier
//Exam 2

namespace Counter
{
    //Read File book.txt
    class FileReader
    {
        Stack s = new Stack();

        public Stack S
        {
            get { return s; }
        }

        public void ReadData()
        {
            try
            {
                //Reads in each line of the file and stores each word in the stack
                StreamReader sr = new StreamReader(@"..\..\..\Book.txt");

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split();

                    for (int i = 0; i < words.Length; i++)
                    {                        
                        s.Push(words[i]);
                    }
                }
                sr.Close();
            }

            //catches and reads exception
            catch (Exception e)
            {
                Console.WriteLine("Exception in ReadData: " + e.Message);

                //Output
                Console.WriteLine("There are " + 0 + " vowels");
                Console.WriteLine("and " + 0 + " consonants");
                Console.WriteLine("in a Tale of Two Cities");

                return;
            }
        }
    }
}

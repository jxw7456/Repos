using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Name: JaJuan Webster
//Instructor: Professor Maier
//Exam 2

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Your test code goes here - see requirements for Program.cs
            FileReader fr = new FileReader();

            Thread t = new Thread(fr.ReadData);

            //Starts the thread 
            t.Start();

            //Make Thread Wait
            t.Join();

            //vowels and consonants
            int vowels = 0;
            int consonants = 0;
            string pop = "";

            //While the stack is full, pop and increment the variables
            while (pop != null)
            {
                pop = fr.S.Pop();

                if (pop != null)
                {
                    char[] letters = pop.ToCharArray();

                    //have 2 EXTRA Consonants
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (letters[i] == 'A' || letters[i] == 'E' || letters[i] == 'I' || letters[i] == 'O' || letters[i] == 'U')
                        {
                            vowels++;
                        }

                        else if (letters[i] == '.' || letters[i] == '!' || letters[i] == '-' || letters[i] == ',' || letters[i] == '"' || letters[i] == '_' || letters[i] == ';' || letters[i] == '?' || letters[i] == '*' || letters[i] == ':' || letters[i] == '\'' || letters[i] == ')' || letters[i] == '(' || letters[i] == '1' || letters[i] == '7' || letters[i] == '6' || letters[i] == '5' || letters[i] == '2' || letters[i] == '9')
                        {
                            //extra consonants
                        }

                        else
                        {
                            consonants++;
                        }
                    }
                }                
            }

            //Output
            Console.WriteLine("There are " + vowels + " vowels");
            Console.WriteLine("and " + consonants + " consonants");
            Console.WriteLine("in a Tale of Two Cities");
            Console.ReadLine();
        }
    }
}

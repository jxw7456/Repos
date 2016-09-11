using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Name: JaJuan Webster
//Code: HW1 The Typing of the Dead
//Professor Maier

namespace HW1_The_Typing_of_the_Dead
{
    class ZombieData
    {
        private List<string> zombies;
        private List<string> phrases;

        //initalizes the two private classes
        public ZombieData()
        {
            zombies = new List<string>();
            phrases = new List<string>();
        }

        //opens the file with this filename (as text), and reads all phrases, storing them in the phrases attritbute
        public void LoadPhrases(string filename)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader srPhrases = new StreamReader("phrases.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    string lineP;
                    while ((lineP = srPhrases.ReadLine()) != null)
                    {
                        phrases.Add(lineP);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You are all out of phrases!");
                Console.WriteLine(e.Message);
            }
        }

        //read zombies in files zombie1.txt, etc for an arbitrary number of zombies
        public void LoadZombies()
        {
            try
            {
                string[] zombFiles = Directory.GetFiles("./");

                foreach (var file in zombFiles)
                {
                    if (file.Contains("zombie"))
                    {
                        // Open the text file using a stream reader.
                        using (StreamReader srZombie = new StreamReader(file))
                        {
                            // Read the stream to a string, and write the string to the console.
                            string lineZ = srZombie.ReadToEnd();
                            zombies.Add(lineZ);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The are no more zombies left!");
                Console.WriteLine(e.Message);
            }
        }

        //returns a random phrase from the phrase list
        public string RandomPhrase()
        {
            Random rng = new Random();
            int rn = rng.Next(phrases.Count);
            return phrases[rn];
        }

        //returns a random zombie from the zombie list
        public string RandomZombie()
        {
            Random rng2 = new Random();
            int rn2 = rng2.Next(zombies.Count);
            return zombies[rn2];
        }
    }
}

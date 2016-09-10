using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//JaJuan Webster
//Homework 1: The Typing of the Dead
//Professor Maier

namespace HW1_The_Typing_of_the_Dead
{
    class ZombieData
    {
        private List<string> zombies;
        private List<string> phrases;

        //initializes these two empty lists
        public ZombieData()
        {
            zombies = new List<string>();
            phrases = new List<string>();
        }

        //opens the file with this filename (as text), and reads all the phrases, storing them in the phrases attribute.
        public void LoadPhrases(string filename)
        {

        }

        //read zombies in files zombie1.txt, zombie2.txt, etc. for an arbitrary number of zombies.
        public void LoadZombies()
        {
            try
            {
                using (StreamReader sr = new StreamReader("zombie1.txt"))
                {
                    // Read the stream to a string
                    String read = sr.ReadToEnd();
                    Console.WriteLine(read);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        //returns a random phrase from the phrase list.
        public string RandomPhrase()
        {
            Random rng = new Random();
            int r = rng.Next(phrases.Count);
            string randPhrase = r.ToString();
            return randPhrase;
        }

        //returns a random zombie from the zombie list.
        public string RandomZombie()
        {
            Random rng2 = new Random();
            int r2 = rng2.Next(zombies.Count);
            string randZombie = r2.ToString();
            return randZombie;
        }
    }
}

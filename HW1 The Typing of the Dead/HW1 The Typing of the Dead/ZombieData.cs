using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        //read zombies in files zombie1.txt, etc for an arbitrary number of zombies
        public void LoadZombies()
        {

        }

        //returns a random phrase from the phrase list
        public string RandomPhrase()
        {
            Random rng = new Random();
            int rn = rng.Next(phrases.Count);
            string randPhrase = rn.ToString();
            return randPhrase;
        }

        //returns a random zombie from the zombie list
        public string RandomZombie()
        {
            Random rng2 = new Random();
            int rn2 = rng2.Next(zombies.Count);
            string randZombie = rn2.ToString();
            return randZombie;
        }
    }
}

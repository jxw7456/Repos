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
    class Program
    {
        static void Main(string[] args)
        {
            /*TEST CODE
             
            ZombieData test = new ZombieData();
            test.LoadPhrases("phrases.txt");
            test.LoadZombies();

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(test.RandomPhrase());
                Console.WriteLine(test.RandomZombie());
            }
            */

            //Game Object
            Game play = new Game();
            play.PlayGame();

            //DEBUG
            Console.ReadLine();
        }
    }
}

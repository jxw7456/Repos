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
            //Game Object
            //Instructions: If you mess up the phrase, you have to start all over.
            Game play = new Game();
            play.PlayGame();

            //Game Closes when any key is pressed
            Console.ReadKey();
        }
    }
}

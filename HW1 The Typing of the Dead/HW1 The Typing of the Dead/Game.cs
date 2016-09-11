using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HW1_The_Typing_of_the_Dead
{
    class Game
    {
        //Attributes
        public ZombieData theDead;
        public int playerLife;
        public int score;

        public int zombieTimer { get; set; }

        public int letterIndex { get; set; }

        const int SCORE_CHANGE = 100;

        //Constructor
        public Game()
        {
            playerLife = 10;
            score = 0;

            theDead = new ZombieData();
            theDead.LoadPhrases("phrases.txt");
            theDead.LoadZombies();
        }

        public void PlayGame()
        {
            string numZombies = "";
            string numPhrases = "";

            while (playerLife > 0)
            {
                if (string.IsNullOrEmpty(numZombies))
                {
                    numZombies = theDead.RandomZombie();
                    numPhrases = theDead.RandomPhrase();
                    zombieTimer = 0;
                    letterIndex = 0;

                    Console.WriteLine("Player's Score: " + score);
                    Console.WriteLine("Zombie: " + numZombies);
                    Console.WriteLine("Phrase: " + numPhrases);
                    Console.WriteLine();
                }

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    string letter = key.KeyChar.ToString().ToUpper();
                    string currentLetter = numPhrases[letterIndex].ToString().ToUpper();
                    if (letter.Equals(currentLetter))
                    {
                        letterIndex++;
                        Console.Write("! ");
                        Console.WriteLine();    //INDENT
                    }
                    else
                    {
                        letterIndex = 0;
                        Console.Write(":( ");
                        Console.WriteLine();    //INDENT
                    }

                    if (letterIndex == numPhrases.Length)
                    {
                        numZombies = null;
                        score += SCORE_CHANGE;
                        zombieTimer = 0;
                        letterIndex = 0;
                        Console.WriteLine("Zombie is dead! You are the winner!");
                    }
                }

                Thread.Sleep(50);
                zombieTimer += 50;

                //Makes game harder
                if (zombieTimer >= 4000 - score)
                {                    
                    playerLife--;                    
                    Console.WriteLine("!ZOMBIE BITE!");
                    Console.WriteLine("Player Life: " + playerLife);
                    Console.WriteLine();    //INDENT
                    zombieTimer = 0;
                    Console.WriteLine("The game is getting harder, pick up your speed!");
                    Console.WriteLine();    //INDENT

                    if (playerLife == 0)
                    {
                    Console.WriteLine("You are Dead!");
                    Console.WriteLine("Final Score: " + score);
                    }
                }

                
            }
        }
    }
}

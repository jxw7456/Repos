using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW1_The_Typing_of_the_Dead
{
    class HighScore
    {
        const string SAVE_HS = "hiscore.dat";

        //Prints out the highscore
        public static void ReadScore()
        {
            int hs;

            if (File.Exists(SAVE_HS))
            {
                using (BinaryReader br = new BinaryReader(File.Open(SAVE_HS, FileMode.Open)))
                {
                    hs = br.ReadInt32();
                }

                Console.WriteLine("Highscore: " + hs);
            }
        }

        //Saves in the highscore
        public static void WriteScore(int gameScore)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(SAVE_HS, FileMode.Create)))
            {
                bw.Write(gameScore);
            }
        }
    }
}

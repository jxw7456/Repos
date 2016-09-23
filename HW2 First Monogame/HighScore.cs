using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
//Name: JaJuan Webster
//HW2 First Monogame
//Professor Maier

namespace HW2_First_Mono
{
    public class HighScore
    {
        const string SAVE_HS = "hiscore.dat";
        public int score { get; set; }

        //Prints out the highscore
        public void ReadScore()
        {
            if (File.Exists(SAVE_HS))
            {
                using (BinaryReader br = new BinaryReader(File.Open(SAVE_HS, FileMode.Open)))
                {
                    score = br.ReadInt32();
                }                               
            }
        }

        //Saves in the highscore
        public void WriteScore(int gameScore)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(SAVE_HS, FileMode.Create)))
            {
                bw.Write(gameScore);
            }
        }
    }
}

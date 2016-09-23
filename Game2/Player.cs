using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
//Name: JaJuan Webster
//HW2 First Monogame
//Professor Maier

namespace Game2
{
    public class Player:GameObject
    {
        private int levelScore; //score of current level

        public int LevelScore
        {
            get { return levelScore; }
            set { levelScore = value; }
        }

        private int totalScore; //player's total score since starting the game

        public int TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        //Constructor
        public Player(int levelScore, int totalScore, int X, int Y, int Width, int Height) : base(X, Y, Width, Height)
        {
            levelScore = 0;
            totalScore = 0;
        }
    }
}

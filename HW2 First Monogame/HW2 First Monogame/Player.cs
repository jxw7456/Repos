using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//Name: JaJuan Webster
//HW2 First Monogame
//Professor Maier


namespace HW2_First_Monogame
{
    class Player:GameObject
    {
        Game1 game1 = new Game1();
        int levelScore; //score of current level
        int totalScore; //player's total score since starting the game
        Rectangle rectanglePlayer { get; set; }

        public Player(int levelScore, int totalScore, int X, int Y, int Width, int Height) : base(X, Y, Width, Height)
        {
            levelScore = 1000;
            totalScore = 5000;
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(game1.player, new Rectangle(rectanglePlayer.X, rectanglePlayer.Y, rectanglePlayer.Width, rectanglePlayer.Height), Color.White);
        }
    }
}

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

namespace HW2_First_Monogame
{
    abstract class GameObject
    {
        Game1 game1 = new Game1();

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle rectangle { get; set; }
        
        //Constructor  
        public GameObject(int X, int Y, int Width, int Height)
        {
            X = rectangle.X;
            Y = rectangle.Y;
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        //use Spritebatch object to draw itself
        abstract public void Draw(SpriteBatch spritebatch);
    }
}

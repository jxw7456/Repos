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
    class GameObject
    {
        Game1 game1 = new Game1();

        int X { get; set; }
        int Y { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        Rectangle rectangle { get; set; }
        
        //Constructor  
        public GameObject(int X, int Y, int Width, int Height)
        {
            X = rectangle.X;
            Y = rectangle.Y;
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        //use Spritebatch object to draw itself
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(game1.background, new Rectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height), Color.White);
        }
    }
}

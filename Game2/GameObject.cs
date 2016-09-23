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
    public class GameObject
    {
        //Player Position
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        private int width { get; set; }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height { get; set; }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private Rectangle position { get; set; }

        public Rectangle Position
        {
            get { return position; }
            set { position = value; }
        }

        private Texture2D texture { get; set; }

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        //Constructor  
        public GameObject(int X, int Y, int Width, int Height)
        {
            position = new Rectangle(X, Y, Width, Height);
        }

        //use Spritebatch object to draw itself
        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position, Color.White);
        }
    }
}

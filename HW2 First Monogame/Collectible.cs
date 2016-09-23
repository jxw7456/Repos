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

namespace HW2_First_Mono
{
    public class Collectible:GameObject
    {
        //Properties
        private bool active;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        //Constructor
        public Collectible(int X, int Y, int Width, int Height) : base(X, Y, Width, Height)
        {
            active = true;
        }

        //Checks if game object intersects with the collectible
        public bool CheckCollision(GameObject gameObject)
        {
            if (active == true)
            {
                if (gameObject.Position.Intersects(this.Position) == true)
                {
                    return true;
                }
            }
            return false;
        }

        //Override Draw Method
        public override void Draw(SpriteBatch spritebatch)
        {
            if (active == true)
            {
                spritebatch.Draw(Texture, Position, Color.White);
            }
        }
    }
}

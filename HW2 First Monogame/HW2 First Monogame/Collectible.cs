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
    class Collectible: GameObject
    {
        Game1 game1 = new Game1();
        GameObject gameObject;
        public bool active;
        public Rectangle rectangleCollect { get; set; }
        
        public Collectible(bool active, int X, int Y, int Width, int Height) : base(X, Y, Width, Height)
        {
            active = true;
        }
            
        //Checks if game object intersects with the collectible
        public bool CheckCollision(GameObject gameObject)
        {
            if (active == true)
            {
                if (gameObject.rectangle.Intersects(rectangleCollect) == true)
                {
                    active = false;
                    return true;
                }
            }
            return false;
        }

        //Draws Collectible
        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(game1.item, new Rectangle(rectangleCollect.X, rectangleCollect.Y, rectangleCollect.Width, rectangleCollect.Height), Color.White);
            if (active == true)
            {
                gameObject.Draw(spritebatch);
            }
        }
    }
}

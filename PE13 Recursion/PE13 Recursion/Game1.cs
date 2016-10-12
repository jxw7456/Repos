using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PE13_Recursion
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;
        Texture2D image;

        int imageCount;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteFont = Content.Load<SpriteFont>(@"quick");
            image = Content.Load<Texture2D>(@"village");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            int imageCount = DrawNeatRecursiveThing(475, 0, 325, 200, Color.White);
            spriteBatch.DrawString(spriteFont, "Image Count: " + imageCount, new Vector2(315, 230),Color.Black);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public int DrawNeatRecursiveThing(int x, int y, int width, int height, Color color)
        {
            int numImages = 1;

            Rectangle destinationRec = new Rectangle(x, y, width, height);

            spriteBatch.Draw(image, destinationRec, color);

            if(width > 25 && height > 25)
            {
                spriteBatch.Draw(image, new Rectangle(0, 0, width, height), Color.LightGoldenrodYellow);
                spriteBatch.Draw(image, new Rectangle(475, 285, width, height), Color.IndianRed);
                spriteBatch.Draw(image, new Rectangle(0, 285, 325, 200), Color.LightBlue);
                numImages += DrawNeatRecursiveThing(x, y, width / 2, height / 2, color);
                numImages += 3;
            }
            return numImages;
        }
    }
}

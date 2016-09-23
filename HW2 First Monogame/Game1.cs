using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
//Name: JaJuan Webster
//HW2 First Monogame
//Professor Maier

namespace HW2_First_Mono
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        //Game State enum
        enum GameState { Menu, Game, GameOver };

        //Attributes
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;

        KeyboardState kbState;
        KeyboardState previousKbState;

        public Texture2D background;
        public Texture2D player;
        public Texture2D item;

        Random rng;
        public List<Collectible> collectibles;
        public int level;
        public int gameScore;

        public double timer;
        public string timerStr;
        
        public int screenWidth;
        public int screenHeight;

        //objects
        GameState gameState;
        Player playerObject;
        HighScore highScore;

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
            collectibles = new List<Collectible>();
            screenWidth = GraphicsDevice.Viewport.Width;
            screenHeight = GraphicsDevice.Viewport.Height;
            playerObject = new Player(0, 0, 0, 0, 100, 100);
            highScore = new HighScore();
            rng = new Random();

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
            background = Content.Load<Texture2D>("backgroundimage");
            player = Content.Load<Texture2D>("player");
            item = Content.Load<Texture2D>("item");
            spriteFont = Content.Load<SpriteFont>("SpriteFont1");
            gameScore = 0;

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
            string strState = "";
            previousKbState = kbState;
            kbState = Keyboard.GetState();

            if(gameState == GameState.Menu)
            {
                strState = "Menu";
            }

            if (gameState == GameState.Game)
            {
                strState = "Game";
            }

            if (gameState == GameState.GameOver)
            {
                strState = "GameOver";
            }

            switch (strState)
            {                
                case "Menu":
                    if (SingleKeyPress(Keys.Enter) == true)
                    {
                        gameState = GameState.Game;
                        ResetGame();                       
                    }
                    break;

                case "Game":
                    //Timer
                    timer -= gameTime.ElapsedGameTime.TotalSeconds;
                    timerStr = string.Format("{0:0.00}", timer);

                    //Up
                    if (kbState.IsKeyDown(Keys.W))
                    {
                        playerObject.Position = new Rectangle(playerObject.Position.X, playerObject.Position.Y - 5, playerObject.Position.Width, playerObject.Position.Height);
                        ScreenWrap(playerObject);
                    }

                    //Left
                    if (kbState.IsKeyDown(Keys.A))
                    {
                        playerObject.Position = new Rectangle(playerObject.Position.X - 5, playerObject.Position.Y, playerObject.Position.Width, playerObject.Position.Height);
                        ScreenWrap(playerObject);
                    }

                    //Down
                    if (kbState.IsKeyDown(Keys.S))
                    {
                        playerObject.Position = new Rectangle(playerObject.Position.X, playerObject.Position.Y + 5, playerObject.Position.Width, playerObject.Position.Height);
                        ScreenWrap(playerObject);
                    }

                    //Right
                    if (kbState.IsKeyDown(Keys.D))
                    {
                        playerObject.Position = new Rectangle(playerObject.Position.X + 5, playerObject.Position.Y, playerObject.Position.Width, playerObject.Position.Height);
                        ScreenWrap(playerObject);
                    }
                    
                    //Collision check
                    for (int i = 0; i < collectibles.Count; i++)
                    {
                        if (collectibles[i].CheckCollision(playerObject))
                        {
                            collectibles[i].Active = false;
                            playerObject.LevelScore += 1;
                            playerObject.TotalScore += 1;                            
                        }
                    }

                    //state changes due to timer
                    if (timer < 0)
                    {
                        //BONUS: HIGH SCORE SYSTEM ADDED
                        //saves highscore, if beaten
                        if (playerObject.TotalScore > gameScore)
                        {
                            gameScore = playerObject.TotalScore;
                            highScore.WriteScore(gameScore);
                        }
                        highScore.ReadScore();
                        gameState = GameState.GameOver;                        
                    }

                    //next level when player collects all items
                    if (playerObject.LevelScore == collectibles.Count)
                    {
                        NextLevel();
                    }
                                        
                    break;

                case "GameOver":
                    if (SingleKeyPress(Keys.Enter))
                    {
                        gameState = GameState.Menu;
                        
                    }
                    break;
            }

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

            spriteBatch.Draw(background, new Rectangle(0, 0, screenWidth, screenHeight), Color.White);

            //Draw Menu
            if (gameState == GameState.Menu)
            {
                spriteBatch.DrawString(spriteFont, "Donnie Boy", new Vector2(screenWidth / 2, screenHeight / 2), Color.DarkRed);
                spriteBatch.DrawString(spriteFont, "Press Enter to Start", new Vector2(screenWidth / 2, (screenHeight / 2) + 20), Color.Red);
            }

            //Draw Game
            if (gameState == GameState.Game)
            {
                playerObject.Texture = player;
                playerObject.Draw(spriteBatch);

                for (int i = 0; i < collectibles.Count; i++)
                {
                    collectibles[i].Texture = item;
                    collectibles[i].Draw(spriteBatch);
                }

                spriteBatch.DrawString(spriteFont, "Level " + level, new Vector2(0, 0), Color.Blue);
                spriteBatch.DrawString(spriteFont, "Score: " + playerObject.LevelScore, new Vector2(0, 20), Color.Blue);
                spriteBatch.DrawString(spriteFont, "Timer: " + timerStr, new Vector2(0, 40), Color.Blue);
            }

            //Draw Game Over
            if (gameState == GameState.GameOver)
            {
                spriteBatch.Draw(background, new Rectangle(0, 0, screenWidth, screenHeight), Color.Gray);
                spriteBatch.DrawString(spriteFont, "Game Over", new Vector2(screenWidth / 2, screenHeight / 2), Color.Blue);
                spriteBatch.DrawString(spriteFont, "Level " + level, new Vector2(screenWidth / 2, (screenHeight / 2) + 20), Color.Blue);
                spriteBatch.DrawString(spriteFont, "Total Score: " + playerObject.TotalScore, new Vector2(screenWidth / 2, (screenHeight / 2) + 40), Color.Blue);
                spriteBatch.DrawString(spriteFont, "High Score: " + highScore.score, new Vector2(screenWidth / 2, (screenHeight / 2) + 60), Color.Blue);
                spriteBatch.DrawString(spriteFont, "Press Enter to Return to the Main Menu", new Vector2(screenWidth / 2, screenHeight - 20), Color.Blue);                
            }

            //End the sprite batch
            spriteBatch.End();

            base.Draw(gameTime);
        }

        //Sets up next level for player
        public void NextLevel()
        {
            //increment the level
            level += 1;

            //set the timer
            timer = 5;

            //reset player's level score
            playerObject.LevelScore = 0;

            //center player on the screen
            playerObject.X = screenWidth / 2;   //480
            playerObject.Y = screenHeight / 2;  //240
            playerObject.Position = new Rectangle(playerObject.X, playerObject.Y, playerObject.Position.Width, playerObject.Position.Height);

            //clear the list of collectibles
            collectibles.Clear();

            //calculate how many collectibles to create for each level
            int min = 6;
            int add = 1 * level;
            int formula = min + add;

            //loop and create collectibles            
            for (int i = 0; i < formula; i++)
            {
                Collectible collectItems = new Collectible(rng.Next(screenWidth - 25), rng.Next(screenHeight - 25), 50, 50);
                collectItems.Texture = item;
                collectibles.Add(collectItems);
            }
        }

        //Resets the game and calls the Next Level
        public void ResetGame()
        {
            level = 0;
            playerObject.TotalScore = 0;
            NextLevel();
        }

        //Keeps the player in the game screen
        public void ScreenWrap(GameObject gameObject)
        {
            if (playerObject.Position.X > screenWidth)
            {
                playerObject.Position = new Rectangle(-1, playerObject.Position.Y, playerObject.Position.Width, playerObject.Position.Height);
            }

            if (playerObject.Position.Y > screenHeight)
            {
                playerObject.Position = new Rectangle(playerObject.Position.X, -1, playerObject.Position.Width, playerObject.Position.Height);
            }

            if (playerObject.Position.X < -2)
            {
                playerObject.Position = new Rectangle(screenWidth, playerObject.Position.Y, playerObject.Position.Width, playerObject.Position.Height);
            }

            if (playerObject.Position.Y < -2)
            {
                playerObject.Position = new Rectangle(playerObject.Position.X, screenHeight, playerObject.Position.Width, playerObject.Position.Height);
            }
        }

        //Returns a bool for a key press
        public bool SingleKeyPress(Keys keys)
        {
            bool valid = false;

            if (kbState.IsKeyDown(keys) == true)
            {
                if (previousKbState.IsKeyUp(keys) == true)
                {
                    valid = true;
                }
            }
            return valid;
        }
    }
}

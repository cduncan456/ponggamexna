using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using SaudPongXNA.ui;

namespace SaudPongXNA
{
    /// <summary>
    /// Pong Game XNA
    /// 
    /// Author: Saud Malik 
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {

        #region Fields
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Sprite paddle1, paddle2, pongball;
        #endregion


        #region Construction
        /// <summary>
        /// Constructs a game instance and initializes the graphics device 
        /// manager and content pipeline.
        /// </summary>
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        #endregion


        #region XNA overrides
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Create a new SpriteBatch, which can be used to draw textures.  Since 
            // our components need a reference to this SpriteBatch, create it here 
            // instead of in LoadContent.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: Add your initialization logic here
            pongball = new Sprite(this, "ball", spriteBatch, new Vector2(140,0) ,new Vector2(150f, 150f));
            Components.Add(pongball);
            paddle1 = new Sprite(this, "stick1", spriteBatch, new Vector2(10,0));
            Components.Add(paddle1);
            paddle2 = new Sprite(this, "stick1", spriteBatch, new Vector2(graphics.GraphicsDevice.Viewport.Width - 22, 150));
            Components.Add(paddle2);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // TODO: use this.Content to load your game content here
            // method left for context
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            // method left for context
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            KeyboardState currentKey = Keyboard.GetState();
            if (currentKey.IsKeyDown(Keys.W))
            {
                paddle1.setPositionY(paddle1.getPositionY() - 5);
            }
            else if (currentKey.IsKeyDown(Keys.S))
            {
                paddle1.setPositionY(paddle1.getPositionY() + 5);
            }

            if (currentKey.IsKeyDown(Keys.Up))
            {
                paddle2.setPositionY(paddle2.getPositionY() - 5);
            }
            else if (currentKey.IsKeyDown(Keys.Down))
            {
                paddle2.setPositionY(paddle2.getPositionY() + 5);
            }

            int maximumX = graphics.GraphicsDevice.Viewport.Width - 22;

            if (pongball.getPositionX() > maximumX)
            {
                pongball.setPositionY(0);
            }

            if (pongball.getPositionX() < 10)
            {
                pongball.setPositionY(0);
            }

            Rectangle pongRect = new Rectangle((int)pongball.getPositionX(), (int) pongball.getPositionY(),13,13);
            Rectangle pad1Rect = new Rectangle((int)paddle1.getPositionX(), (int)paddle1.getPositionY(), 12, 65);
            Rectangle pad2Rect = new Rectangle((int)paddle2.getPositionX(), (int)paddle2.getPositionY(), 12, 65);


            if (pongRect.Intersects(pad1Rect))
            {
                pongball.setVelocityX(pongball.getVelocityX() * -1);
            }

            if (pongRect.Intersects(pad2Rect))
            {
                pongball.setVelocityX(pongball.getVelocityX() * -1);
            }

            // TODO: Add your update logic here (comment left for context)

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.WhiteSmoke);

            // TODO: Add your drawing code here (comment left for context)

            // Draw the sprites.
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            // ensure game components' Draw methods get called between the SpriteBatch
            // Begin and End
            base.Draw(gameTime);

            spriteBatch.End();
        }
        #endregion
    }
}

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
            Components.Add(new Sprite(this, "circle", spriteBatch, Vector2.Zero,
                new Vector2(200f, 65f)));
            Components.Add(new Sprite(this, "star", spriteBatch, new Vector2(100, 100),
                new Vector2(-50f, 165f)));
            Components.Add(new Sprite(this, "mario", spriteBatch, new Vector2(400f, 300f),
                new Vector2(-100f, 0f)));

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

            // TODO: Add your update logic here (comment left for context)

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaudPongXNA.ui
{
    class Sprite : DrawableGameComponent
    {
        #region Fields
        private string textureName;
        private SpriteBatch spriteBatch;
        private Vector2 position;
        private Vector2 velocity;
        private Texture2D texture;
        #endregion

        #region Construction
        /// <summary>
        /// Construct a new sprite with the given texture and position. The sprite's initial
        /// position and velocity will be zero. The sprite will be drawn using the supplied 
        /// SpriteBatch; this class assumes that batch.Begin(...) and batch.End() are called 
        /// elsewhere.
        /// </summary>
        /// <param name="game">the game context for this sprite</param>
        /// <param name="textureName">this sprite's texture</param>
        /// <param name="batch">the SpriteBatch used to draw this sprite</param>
        public Sprite(Game game, String textureName, SpriteBatch batch)
            : this(game, textureName, batch, Vector2.Zero, Vector2.Zero) { }

        /// <summary>
        /// Construct a new sprite with the given texture and position. The sprite's initial
        /// velocity will be zero. The sprite will be drawn using the supplied SpriteBatch; 
        /// this class assumes that batch.Begin(...) and batch.End() are called elsewhere.
        /// </summary>
        /// <param name="game">the game context for this sprite</param>
        /// <param name="textureName">this sprite's texture</param>
        /// <param name="batch">the SpriteBatch used to draw this sprite</param>
        /// <param name="initialPosition">the sprite's initial position</param>
        public Sprite(Game game, String textureName, SpriteBatch batch, Vector2 initialPosition)
            : this(game, textureName, batch, initialPosition, Vector2.Zero) { }

        /// <summary>
        /// Construct a new sprite with the given texture, position, and velocity.
        /// The sprite will be drawn using the supplied SpriteBatch; this class assumes that
        /// batch.Begin(...) and batch.End() are called elsewhere.
        /// </summary>
        /// <param name="game">the game context for this sprite</param>
        /// <param name="textureName">this sprite's texture</param>
        /// <param name="batch">the SpriteBatch used to draw this sprite</param>
        /// <param name="initialPosition">the sprite's initial position</param>
        /// <param name="initialVelocity">the sprite'S initial velocity</param>
        public Sprite(Game game, String textureName, SpriteBatch batch, Vector2 initialPosition, Vector2 initialVelocity)
            : base(game)
        {
            this.textureName = textureName;
            this.spriteBatch = batch;
            this.position = initialPosition;
            this.velocity = initialVelocity;
        }
        #endregion

        #region XNA overrides
        /// <summary>
        /// Load the sprite's texture using Game's content pipeline reference.
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();

            this.texture = Game.Content.Load<Texture2D>(this.textureName);
        }

        /// <summary>
        /// Update the sprite's position based on its velocity.
        /// </summary>
        /// <param name="gameTime">Game timing snapshot</param>
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Move the sprite by speed, scaled by elapsed time.
            position +=
                velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

            int MaxX =
                Game.GraphicsDevice.Viewport.Width - texture.Width;
            int MinX = 0;
            int MaxY =
                Game.GraphicsDevice.Viewport.Height - texture.Height;
            int MinY = 0;

            // Check for bounce.
            if (position.X > MaxX || position.X < MinX)
            {
                velocity.X *= -1;
            }

            position.X = MathHelper.Clamp(position.X, MinX, MaxX);

            if (position.Y > MaxY || position.Y < MinY)
            {
                velocity.Y *= -1;
            }

            position.Y = MathHelper.Clamp(position.Y, MinY, MaxY);
        }

        /// <summary>
        /// Draw the sprite.
        /// </summary>
        /// <param name="gameTime">Game timing snapshot.</param>
        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            spriteBatch.Draw(texture, position, Color.White);
        }
        #endregion

        public float getPosition()
        {
            return position.Y;
        }

        public void setPosition(float x)
        {
            position.Y = x;
        }
    }
}

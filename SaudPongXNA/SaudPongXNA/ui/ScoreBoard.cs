using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace SaudPongXNA
{
    public static class ScoreBoard
    {
        #region Fields
        private static SpriteFont font1;
        private static Vector2 fontPosition1;
        private static Vector2 fontPosition2;
        private static Vector2 fontOrigin; 
        private static int score1;
        private static int score2;
        #endregion
        #region Construction
        /// <summary>
        /// Uses the ContentManager to add the Draw the Scoreboard for the game
        /// </summary>
        /// <param name="game">the game context for the sprite to draw the board</param>
        /// <param name="spriteBatch">the SpriteBatch used to draw this sprite</param>
        /// <param name="content">the content pipeline to use for the scoreboard</param>
        public static void Initialize(Game game, SpriteBatch spriteBatch, ContentManager content)
        {
            font1 = content.Load<SpriteFont>("Fonts/SpriteFont1");
            fontPosition1 = new Vector2((game.GraphicsDevice.Viewport.Width / 2) - 20f, 25);
            fontPosition2 = new Vector2((game.GraphicsDevice.Viewport.Width / 2) + 20f, 25);
            fontOrigin = font1.MeasureString(score1.ToString()) / 2;
        }
        #endregion
        /// <summary>
        /// Draws the scoreboard on the screen using the given spritebatch when the games Update() is called 
        /// </summary>
        /// <param name="batch">the sprite used to draw the board</param>
        public static void DrawScoreBoard(SpriteBatch batch)
        {
            batch.DrawString(font1, GetScore1(), fontPosition1, Color.Gray, 0, fontOrigin, 1.0f, SpriteEffects.None, 0.5f);
            batch.DrawString(font1, GetScore2(), fontPosition2, Color.Gray, 0, fontOrigin, 1.0f, SpriteEffects.None, 0.5f);
        }
        /// <summary>
        /// Adds to score1
        /// </summary>
        public static void AddToScore1()
        {
            score1++;
        }
        /// <summary>
        /// adds to score2
        /// </summary>
        public static void AddToScore2()
        {
            score2++;
        }
        /// <summary>
        /// returns a string representation of the score1
        /// </summary>
        /// <returns></returns>
        public static string GetScore1()
        {
            return score1.ToString();
        }
        /// <summary>
        /// returns a string representation of the score2
        /// </summary>
        /// <returns></returns>
         public static string GetScore2()
        {
            return score2.ToString();
        }
        
        
    }
}

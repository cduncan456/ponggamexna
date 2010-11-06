using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaudPongXNA.ui
{
    class Ball
    {
        private Sprite ball;
        public Ball(Game game, SpriteBatch spriteBatch)
        {
            ball = new Sprite(game, "ball", spriteBatch, new Vector2(140, 0), new Vector2(150f, 150f));
        }

        public Sprite GetBall()
        {
            return this.ball;
        }
    }
}

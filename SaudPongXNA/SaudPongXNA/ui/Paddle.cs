using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaudPongXNA.ui
{
    class Paddle
    {
        public static Sprite createPaddle(Game game, SpriteBatch batch, Vector2 initialPosition)
        {
            Sprite sprite = new Sprite(game, "Images/stick1", batch, initialPosition);
            return sprite;
        }
    }
}

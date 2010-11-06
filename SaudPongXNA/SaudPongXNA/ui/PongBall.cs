using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaudPongXNA.ui
{
    class PongBall
    {
        public static Sprite createPongBall(Game game, SpriteBatch batch, Vector2 initialPosition, Vector2 initialVelocity)
        {
            Sprite sprite = new Sprite(game, "Images/ball", batch, initialPosition, initialVelocity);
            return sprite;
        }
    }
}

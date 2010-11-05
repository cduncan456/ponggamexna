﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SaudPongXNA.ui
{
    class Paddle
    {
        private Sprite paddle;
        private Vector2 position;

        public Paddle(Game game, SpriteBatch spriteBatch, string paddleName, float xPosition, float yPosition)
        {
            position.X = xPosition;
            position.Y = yPosition;
            paddle = new Sprite(game, paddleName, spriteBatch, new Vector2(xPosition, yPosition));
        }

        public Sprite GetPaddle()
        {
            return this.paddle;
        }

        public void setPositionY(float value)
        {
            position.Y = value;
        }

        public float getPositionY()
        {
            return position.Y;
        }
        
    }
}

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
        public Paddle(Game game, SpriteBatch spriteBatch, string paddleName)
        {
            paddle = new Sprite(game, paddleName, spriteBatch, new Vector2(10, 0));
        }

        public Sprite GetPaddle()
        {
            return this.paddle;
        }


        
    }
}

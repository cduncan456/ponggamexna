using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SaudPongXNA.ui;
using Microsoft.Xna.Framework.Input;

namespace SaudPongXNA
{
    
    class Player
    {
        public KeyboardState playerInput;
        private Paddle paddle;
        private Keys upKey;
        private Keys downKey;
        
        

        public Player(Paddle playerPaddle, Keys upKey, Keys downKey)
        {
            this.upKey = upKey;
            this.downKey = downKey;
            this.paddle = playerPaddle;
            SetKeyboardState();
            
            
        }

        public void SetKeyboardState()
        {
            playerInput = Keyboard.GetState();
            
            if (this.playerInput.IsKeyDown(upKey))
            {
                this.paddle.GetPaddle().setPositionY(paddle.GetPaddle().getPositionY() - 5);
            }
            else if (this.playerInput.IsKeyDown(downKey))
            {
                this.paddle.GetPaddle().setPositionY(paddle.GetPaddle().getPositionY() + 5);
            }  
        }

        public KeyboardState GetKeyBoardState()
        {
            return this.playerInput;
        }

        
    }
}

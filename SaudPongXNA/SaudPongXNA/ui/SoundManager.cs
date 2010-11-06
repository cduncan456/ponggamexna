using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace SaudPongXNA
{
    /// <summary>
    /// The SoundManager class handles all the sound effects in the game.
    /// </summary>
    public static class SoundManager
    {
        #region Fields
        private static SoundEffect groundBounce;
        private static SoundEffect paddleBounce;
        private static SoundEffect applause;
        #endregion
        #region Construction
        /// <summary>
        /// Used the ContentManager to load SoundEffect Objects
        /// </summary>
        /// <param name="content">The content pipeline to use for the SoundManager</param>
        public static void Initialize(ContentManager content)
        {
            try
            {
                groundBounce = content.Load<SoundEffect>(@"Sounds\groundBounce");
                paddleBounce = content.Load<SoundEffect>(@"Sounds\paddleBounce");
                applause = content.Load<SoundEffect>(@"Sounds\applause");
            }
            catch
            {
                Debug.Write("SoundManager Initialization Failed");
            }
        }
        
        /// <summary>
        /// Plays the sound of a ball bouncing on the ground.
        /// </summary>
        public static void PlayGroundBounce()
        {
            try
            {
                groundBounce.Play();
            }
            catch
            {
                Debug.Write("PlayGroundBounce() Failed");
            }
        }
        #endregion
        #region Methods
        /// <summary>
        /// Plays the sound of a crowd applause
        /// </summary>
        public static void PlayApplause()
        {
            
                applause.Play();
           
        }
        /// <summary>
        /// Plays the sound of a ball bouncing off the paddle
        /// </summary>
        public static void PlayPaddleBounce()
        {
            try
            {
                paddleBounce.Play();
            }
            catch
            {
                Debug.Write("PlayPaddleBounce() Failed");
            }
        }


        #endregion
    }
}

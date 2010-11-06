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
    
    public static class SoundManager
    {
        private static List<SoundEffect> matchSounds = new List<SoundEffect>();
        private static SoundEffect groundBounce;
        private static SoundEffect paddleBounce;
        private static SoundEffect applause;
       

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

        public static void PlayApplause()
        {

            try
            {
                applause.Play();
            }
            catch
            {
                Debug.Write("PlayApplause() Failed");
            }
            
           
        }

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




    }
}

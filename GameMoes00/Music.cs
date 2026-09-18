using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GameMoes_00
{
    class Music()
    {
        private SoundPlayer MainMenuPlayer;
        public void Init(string MainMenuPlayerURL) 
        {
            MainMenuPlayer = new SoundPlayer();
            MainMenuPlayer.SoundLocation = MainMenuPlayerURL;
            MainMenuPlayer.LoadAsync();
        }
        public bool IsMusicLoaded(SoundPlayer sound) 
        {
            return sound.IsLoadCompleted;
        }
        public void PlayMusic(SoundPlayer sound) 
        {
            sound.Play();
        }
        public void PlayMusicLooped(SoundPlayer sound) 
        {
            sound.PlayLooping();
        }
        public SoundPlayer GetMainMenuPlayer() 
        {
            return MainMenuPlayer;
        }
    }
}

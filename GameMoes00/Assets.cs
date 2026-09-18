using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GameMoes_00
{
    class Assets()
    {
        // links
        private static string Mainurl = "https://neocircuit-studios.com/stream/pub/gamemoes_00/";
        private string LogoLink = Mainurl + "Logo.png";
        private string LoadingMusicLink = Mainurl + "LoadingMusic.wav";

        bool b_LogoLoaded = false;
        private void LoadingLogoLoaded(object sender, System.ComponentModel.AsyncCompletedEventArgs e) 
        {
            b_LogoLoaded = true;
        }
        public bool IsLoadingLogoLoaded()
        {
            return this.b_LogoLoaded;
        }

        public void Init(Music music, PictureBox Loadinglogobox) 
        {
            Loadinglogobox.LoadCompleted += LoadingLogoLoaded;
            Loadinglogobox.LoadAsync(LogoLink);
            music.Init(LoadingMusicLink);
        }

        public bool IsVerythingLoaded() 
        {
            if (this.b_LogoLoaded /* && this. */)
                return true;
            else return false;
        }

    }
}

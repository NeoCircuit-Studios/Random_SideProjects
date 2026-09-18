using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMoes_00
{
    static class Bread
    {
        static public Assets assets = null;
        static public uLog log = null;
        static public LoadingScreen loadingScreen = null;
        static public Music music = null;

        static public Assets GetAssets() 
        {
            if (null == assets)
            {
                assets = new Assets();
                return assets;
            }
            else
                return assets;
        }
        static public uLog GetLog() 
        {
            if (null == log)
            {
                log = new uLog();
                return log;
            }
            else
                return log;
        }
        static public LoadingScreen GetLoadingScreen() 
        {
            if (null == loadingScreen)
            {
                loadingScreen = new LoadingScreen();
                return loadingScreen;
            }
            else
                return loadingScreen;
        }
        static public Music GetMusic() 
        {
            if (null == music)
            {
                music = new Music();
                return music;
            }
            else
                return music;
        }
    }
}

using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Media;

namespace GameMoes_00
{
    // ---------------------------------------------------------------------
    // 18/09/2026 - Last Modified
    // Made by Alexander. Owner of NeoCircuit-Studios.
    // This is free and open source with MIT License
    // This can be used for anything.
    // Assets are from there respected owners
    // My domains cant be used.
    // THIS PROJECT DOES NOT USE ANY LLMs (AI) GENERATED CODE OR CONTENT
    // THIS IS A PROTOTYPE, NOT 100% WORKING PROGRAM, EXPECT BUGS ETC.
    // ---------------------------------------------------------------------

    // License:

    //MIT License

    //Copyright(c) 2026 NeoCircuit-Studios

    //Permission is hereby granted, free of charge, to any person obtaining a copy
    //of this software and associated documentation files (the "Software"), to deal
    //in the Software without restriction, including without limitation the rights
    //to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    //copies of the Software, and to permit persons to whom the Software is
    //furnished to do so, subject to the following conditions:

    //The above copyright notice and this permission notice shall be included in all
    //copies or substantial portions of the Software.

    //THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    //IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    //FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    //AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    //LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    //OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    //SOFTWARE.


    public partial class Game : Form
    {
        enum GameState 
        {
            Null,
            Booting
        }
        GameState gameState = GameState.Null;

        public Game()
        {
            InitializeComponent();

            // hide everything.

            // loading screen
            LoadingText.Hide();
            LoadingProgressBar.Hide();
            BlackPanel.Hide();
            LoadingStatusText.Hide();

        }

        // this runs when the window is loaded
        private void ULoaded(object sender, EventArgs e)
        {
            Boot();
        }

        private void Update()
        {
            //while (b_Running)
            //{
            switch (gameState)
            {
                case GameState.Null:
                    // notthing
                    break;
                case GameState.Booting:
                    // redraw screen
                    GameLogoBox.Invalidate();
                    break;
            }
            //}
        }

        private void Boot() 
        {

            Bread.GetLog().Info("Booting Game..");
            gameState = GameState.Booting;
            Bread.GetLoadingScreen().Show(LoadingProgressBar, LoadingText, BlackPanel, GameLogoBox, LoadingStatusText);
            Bread.GetAssets().Init(Bread.GetMusic(), GameLogoBox);
            System.Windows.Forms.Timer timer0 = new System.Windows.Forms.Timer();
            timer0.Interval = 300;
            LoadingStatusText.Text = "Getting Logo..";
            Bread.GetLog().Info("Loading Logo Image (loading Logo)");
            timer0.Start();
            timer0.Tick += (sender, e) =>
            {
                if (Bread.GetAssets().IsLoadingLogoLoaded())
                {
                    Update();
                    Bread.GetLoadingScreen().UpdateProgressBar(30, LoadingProgressBar);
                    timer0.Stop();
                }
            };
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 300;
            LoadingStatusText.Text = "Getting Music..";
            Bread.GetLog().Info("Loading Music (downloading) (music mainmenu music)");
            timer1.Start();
            timer1.Tick += (sender, e) =>
            {
                if (Bread.GetAssets().IsLoadingLogoLoaded()) 
                {
                    Bread.GetMusic().PlayMusicLooped(Bread.GetMusic().GetMainMenuPlayer());
                    Bread.GetLoadingScreen().UpdateProgressBar(35, LoadingProgressBar);
                    timer1.Stop();
                }
            };
            LoadingStatusText.Text = "Booting..";
        }
        private void MainMenu() 
        {
        }
        public void Shutdown()
        {

        }

    }
}

using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.Media;

namespace GameMoes_00
{
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

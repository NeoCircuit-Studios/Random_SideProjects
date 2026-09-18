using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMoes_00
{
    class LoadingScreen()
    {
        public void Show(ProgressBar progressbar, Label lable, Panel blackpanel, PictureBox logo, Label LoadingStatusText) 
        {
            // make sure that the panel is first show then the other stuff.
            blackpanel.BringToFront();
            blackpanel.BringToFront();
            blackpanel.Show();

            progressbar.Value = 10;
            progressbar.Maximum = 100;
            progressbar.Minimum = 0;
            progressbar.BringToFront();
            progressbar.BringToFront();
            progressbar.Show();

            lable.Text = "Loading...";
            lable.BringToFront();
            lable.BringToFront();
            lable.Show();

            logo.BringToFront();
            logo.BringToFront();
            logo.Show();

            LoadingStatusText.Text = "Init..";
            LoadingStatusText.BringToFront();
            LoadingStatusText.BringToFront();
            LoadingStatusText.Show();
        }

        public void UpdateProgressBar(int value, ProgressBar progressbar) 
        {
            progressbar.Value = value;
        }
        public void Hide(ProgressBar progressbar, Label lable, Panel blackpanel, PictureBox logo, Label LoadingStatusText) 
        {
            progressbar.Hide();
            progressbar.SendToBack();
            progressbar.SendToBack();
            lable.Hide();
            lable.SendToBack();
            lable.SendToBack();
            logo.Hide();
            logo.SendToBack();  
            logo.SendToBack();
            blackpanel.Hide();
            blackpanel.SendToBack();
            blackpanel.SendToBack();
            LoadingStatusText.Hide();
            LoadingStatusText.SendToBack(); 
            LoadingStatusText.SendToBack();
        }
    }
}

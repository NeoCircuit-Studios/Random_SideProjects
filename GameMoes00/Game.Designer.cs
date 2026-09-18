

namespace GameMoes_00
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoadingText = new Label();
            BlackPanel = new Panel();
            GameLogoBox = new PictureBox();
            LoadingProgressBar = new ProgressBar();
            LoadingStatusText = new Label();
            BlackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameLogoBox).BeginInit();
            SuspendLayout();
            // 
            // LoadingText
            // 
            LoadingText.AutoSize = true;
            LoadingText.Font = new Font("Segoe UI", 15F);
            LoadingText.ForeColor = SystemColors.ControlLightLight;
            LoadingText.Location = new Point(351, 209);
            LoadingText.Name = "LoadingText";
            LoadingText.Size = new Size(95, 28);
            LoadingText.TabIndex = 0;
            LoadingText.Text = "Loading...";
            LoadingText.TextAlign = ContentAlignment.MiddleCenter;
            LoadingText.Visible = false;
            // 
            // BlackPanel
            // 
            BlackPanel.Controls.Add(GameLogoBox);
            BlackPanel.Controls.Add(LoadingProgressBar);
            BlackPanel.Controls.Add(LoadingStatusText);
            BlackPanel.Location = new Point(0, 0);
            BlackPanel.Name = "BlackPanel";
            BlackPanel.Size = new Size(802, 454);
            BlackPanel.TabIndex = 0;
            BlackPanel.Visible = false;
            // 
            // GameLogoBox
            // 
            GameLogoBox.Location = new Point(234, 50);
            GameLogoBox.Name = "GameLogoBox";
            GameLogoBox.Size = new Size(325, 150);
            GameLogoBox.TabIndex = 1;
            GameLogoBox.TabStop = false;
            GameLogoBox.Visible = false;
            // 
            // LoadingProgressBar
            // 
            LoadingProgressBar.Location = new Point(234, 308);
            LoadingProgressBar.Name = "LoadingProgressBar";
            LoadingProgressBar.Size = new Size(325, 23);
            LoadingProgressBar.TabIndex = 0;
            LoadingProgressBar.Value = 10;
            LoadingProgressBar.Visible = false;
            // 
            // LoadingStatusText
            // 
            LoadingStatusText.AutoSize = true;
            LoadingStatusText.BackColor = SystemColors.ActiveCaptionText;
            LoadingStatusText.Font = new Font("Segoe UI", 12F);
            LoadingStatusText.ForeColor = SystemColors.ControlLightLight;
            LoadingStatusText.Location = new Point(351, 409);
            LoadingStatusText.Name = "LoadingStatusText";
            LoadingStatusText.Size = new Size(52, 21);
            LoadingStatusText.TabIndex = 2;
            LoadingStatusText.Text = "Status";
            LoadingStatusText.Visible = false;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(BlackPanel);
            Controls.Add(LoadingText);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Game";
            Text = "Game";
            Load += ULoaded;
            BlackPanel.ResumeLayout(false);
            BlackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GameLogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label LoadingText;
        private Panel BlackPanel;
        private ProgressBar LoadingProgressBar;
        private PictureBox GameLogoBox;
        private Label LoadingStatusText;
    }
}

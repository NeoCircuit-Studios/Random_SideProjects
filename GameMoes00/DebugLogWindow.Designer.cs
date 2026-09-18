namespace GameMoes_00
{
    partial class DebugLogWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogTextBox = new TextBox();
            KillGameButton = new Button();
            SuspendLayout();
            // 
            // LogTextBox
            // 
            LogTextBox.Location = new Point(12, 290);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.ScrollBars = ScrollBars.Vertical;
            LogTextBox.Size = new Size(776, 148);
            LogTextBox.TabIndex = 2;
            // 
            // KillGameButton
            // 
            KillGameButton.Font = new Font("Segoe UI", 15F);
            KillGameButton.Location = new Point(12, 12);
            KillGameButton.Name = "KillGameButton";
            KillGameButton.Size = new Size(119, 42);
            KillGameButton.TabIndex = 3;
            KillGameButton.Text = "Kill Game";
            KillGameButton.UseVisualStyleBackColor = true;
            KillGameButton.Click += KillGameClick;
            // 
            // DebugLogWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KillGameButton);
            Controls.Add(LogTextBox);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "DebugLogWindow";
            Text = "DebugLogWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox LogTextBox;
        private Button KillGameButton;
    }
}
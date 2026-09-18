namespace Bread_Calculator
{
    partial class Calu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calu));
            _Screen = new TextBox();
            _AC = new Button();
            _Save = new Button();
            _Procent = new Button();
            _Devide = new Button();
            _Multy = new Button();
            _K9 = new Button();
            _K8 = new Button();
            _K7 = new Button();
            _Min = new Button();
            _K6 = new Button();
            _K5 = new Button();
            _K4 = new Button();
            _Plus = new Button();
            _K3 = new Button();
            _K2 = new Button();
            _K1 = new Button();
            _Is = new Button();
            _Back = new Button();
            _Point = new Button();
            _K0 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // _Screen
            // 
            _Screen.BackColor = SystemColors.ScrollBar;
            _Screen.Enabled = false;
            _Screen.Font = new Font("Segoe UI", 60F);
            _Screen.Location = new Point(41, 12);
            _Screen.Name = "_Screen";
            _Screen.Size = new Size(552, 114);
            _Screen.TabIndex = 0;
            // 
            // _AC
            // 
            _AC.Font = new Font("Segoe UI", 25F);
            _AC.Location = new Point(22, 142);
            _AC.Name = "_AC";
            _AC.Size = new Size(141, 52);
            _AC.TabIndex = 1;
            _AC.Text = "AC";
            _AC.UseVisualStyleBackColor = true;
            _AC.Click += AC;
            _AC.MouseLeave += GlobalLeave;
            _AC.MouseHover += GlobalHover;
            // 
            // _Save
            // 
            _Save.Font = new Font("Segoe UI", 25F);
            _Save.Location = new Point(169, 142);
            _Save.Name = "_Save";
            _Save.Size = new Size(141, 52);
            _Save.TabIndex = 2;
            _Save.Text = "Save";
            _Save.UseVisualStyleBackColor = true;
            _Save.Click += Save;
            _Save.MouseLeave += GlobalLeave;
            _Save.MouseHover += GlobalHover;
            // 
            // _Procent
            // 
            _Procent.Font = new Font("Segoe UI", 25F);
            _Procent.Location = new Point(316, 142);
            _Procent.Name = "_Procent";
            _Procent.Size = new Size(141, 52);
            _Procent.TabIndex = 3;
            _Procent.Text = "%";
            _Procent.UseVisualStyleBackColor = true;
            _Procent.Click += Procent;
            _Procent.MouseLeave += GlobalLeave;
            _Procent.MouseHover += GlobalHover;
            // 
            // _Devide
            // 
            _Devide.Font = new Font("Segoe UI", 25F);
            _Devide.Location = new Point(463, 142);
            _Devide.Name = "_Devide";
            _Devide.Size = new Size(141, 52);
            _Devide.TabIndex = 4;
            _Devide.Text = "/";
            _Devide.UseVisualStyleBackColor = true;
            _Devide.Click += Devide;
            _Devide.MouseLeave += GlobalLeave;
            _Devide.MouseHover += GlobalHover;
            // 
            // _Multy
            // 
            _Multy.Font = new Font("Segoe UI", 25F);
            _Multy.Location = new Point(463, 200);
            _Multy.Name = "_Multy";
            _Multy.Size = new Size(141, 52);
            _Multy.TabIndex = 8;
            _Multy.Text = "X";
            _Multy.UseVisualStyleBackColor = true;
            _Multy.Click += Multy;
            _Multy.MouseLeave += GlobalLeave;
            _Multy.MouseHover += GlobalHover;
            // 
            // _K9
            // 
            _K9.Font = new Font("Segoe UI", 25F);
            _K9.Location = new Point(316, 200);
            _K9.Name = "_K9";
            _K9.Size = new Size(141, 52);
            _K9.TabIndex = 7;
            _K9.Text = "9";
            _K9.UseVisualStyleBackColor = true;
            _K9.Click += K9;
            _K9.MouseLeave += GlobalLeave;
            _K9.MouseHover += GlobalHover;
            // 
            // _K8
            // 
            _K8.Font = new Font("Segoe UI", 25F);
            _K8.Location = new Point(169, 200);
            _K8.Name = "_K8";
            _K8.Size = new Size(141, 52);
            _K8.TabIndex = 6;
            _K8.Text = "8";
            _K8.UseVisualStyleBackColor = true;
            _K8.Click += K8;
            _K8.MouseLeave += GlobalLeave;
            _K8.MouseHover += GlobalHover;
            // 
            // _K7
            // 
            _K7.Font = new Font("Segoe UI", 25F);
            _K7.Location = new Point(22, 200);
            _K7.Name = "_K7";
            _K7.Size = new Size(141, 52);
            _K7.TabIndex = 5;
            _K7.Text = "7";
            _K7.UseVisualStyleBackColor = true;
            _K7.Click += K7;
            _K7.MouseLeave += GlobalLeave;
            _K7.MouseHover += GlobalHover;
            // 
            // _Min
            // 
            _Min.Font = new Font("Segoe UI", 25F);
            _Min.Location = new Point(463, 258);
            _Min.Name = "_Min";
            _Min.Size = new Size(141, 52);
            _Min.TabIndex = 12;
            _Min.Text = "-";
            _Min.UseVisualStyleBackColor = true;
            _Min.Click += Min;
            _Min.MouseLeave += GlobalLeave;
            _Min.MouseHover += GlobalHover;
            // 
            // _K6
            // 
            _K6.Font = new Font("Segoe UI", 25F);
            _K6.Location = new Point(316, 258);
            _K6.Name = "_K6";
            _K6.Size = new Size(141, 52);
            _K6.TabIndex = 11;
            _K6.Text = "6";
            _K6.UseVisualStyleBackColor = true;
            _K6.Click += K6;
            _K6.MouseLeave += GlobalLeave;
            _K6.MouseHover += GlobalHover;
            // 
            // _K5
            // 
            _K5.Font = new Font("Segoe UI", 25F);
            _K5.Location = new Point(169, 258);
            _K5.Name = "_K5";
            _K5.Size = new Size(141, 52);
            _K5.TabIndex = 10;
            _K5.Text = "5";
            _K5.UseVisualStyleBackColor = true;
            _K5.Click += K5;
            _K5.MouseLeave += GlobalLeave;
            _K5.MouseHover += GlobalHover;
            // 
            // _K4
            // 
            _K4.Font = new Font("Segoe UI", 25F);
            _K4.Location = new Point(22, 258);
            _K4.Name = "_K4";
            _K4.Size = new Size(141, 52);
            _K4.TabIndex = 9;
            _K4.Text = "4";
            _K4.UseVisualStyleBackColor = true;
            _K4.Click += K4;
            _K4.MouseLeave += GlobalLeave;
            _K4.MouseHover += GlobalHover;
            // 
            // _Plus
            // 
            _Plus.Font = new Font("Segoe UI", 25F);
            _Plus.Location = new Point(463, 316);
            _Plus.Name = "_Plus";
            _Plus.Size = new Size(141, 52);
            _Plus.TabIndex = 16;
            _Plus.Text = "+";
            _Plus.UseVisualStyleBackColor = true;
            _Plus.Click += Plus;
            _Plus.MouseEnter += GlobalHover;
            _Plus.MouseHover += GlobalLeave;
            // 
            // _K3
            // 
            _K3.Font = new Font("Segoe UI", 25F);
            _K3.Location = new Point(316, 316);
            _K3.Name = "_K3";
            _K3.Size = new Size(141, 52);
            _K3.TabIndex = 15;
            _K3.Text = "3";
            _K3.UseVisualStyleBackColor = true;
            _K3.Click += K3;
            _K3.MouseEnter += GlobalHover;
            _K3.MouseHover += GlobalLeave;
            // 
            // _K2
            // 
            _K2.Font = new Font("Segoe UI", 25F);
            _K2.Location = new Point(169, 316);
            _K2.Name = "_K2";
            _K2.Size = new Size(141, 52);
            _K2.TabIndex = 14;
            _K2.Text = "2";
            _K2.UseVisualStyleBackColor = true;
            _K2.Click += K2;
            _K2.MouseEnter += GlobalHover;
            _K2.MouseHover += GlobalLeave;
            // 
            // _K1
            // 
            _K1.Font = new Font("Segoe UI", 25F);
            _K1.Location = new Point(22, 316);
            _K1.Name = "_K1";
            _K1.Size = new Size(141, 52);
            _K1.TabIndex = 13;
            _K1.Text = "1";
            _K1.UseVisualStyleBackColor = true;
            _K1.Click += K1;
            _K1.MouseEnter += GlobalHover;
            _K1.MouseHover += GlobalLeave;
            // 
            // _Is
            // 
            _Is.Font = new Font("Segoe UI", 25F);
            _Is.Location = new Point(463, 374);
            _Is.Name = "_Is";
            _Is.Size = new Size(141, 52);
            _Is.TabIndex = 20;
            _Is.Text = "=";
            _Is.UseVisualStyleBackColor = true;
            _Is.Click += Is;
            _Is.MouseEnter += GlobalHover;
            _Is.MouseHover += GlobalLeave;
            // 
            // _Back
            // 
            _Back.Font = new Font("Segoe UI", 25F);
            _Back.Location = new Point(316, 374);
            _Back.Name = "_Back";
            _Back.Size = new Size(141, 52);
            _Back.TabIndex = 19;
            _Back.Text = "Bread";
            _Back.UseVisualStyleBackColor = true;
            _Back.Click += Bread;
            _Back.MouseEnter += GlobalHover;
            _Back.MouseHover += GlobalLeave;
            // 
            // _Point
            // 
            _Point.Font = new Font("Segoe UI", 25F);
            _Point.Location = new Point(169, 374);
            _Point.Name = "_Point";
            _Point.Size = new Size(141, 52);
            _Point.TabIndex = 18;
            _Point.Text = ".";
            _Point.UseVisualStyleBackColor = true;
            _Point.Click += Point;
            _Point.MouseEnter += GlobalHover;
            _Point.MouseHover += GlobalLeave;
            // 
            // _K0
            // 
            _K0.Font = new Font("Segoe UI", 25F);
            _K0.Location = new Point(22, 374);
            _K0.Name = "_K0";
            _K0.Size = new Size(141, 52);
            _K0.TabIndex = 17;
            _K0.Text = "0";
            _K0.UseVisualStyleBackColor = true;
            _K0.Click += K0;
            _K0.MouseEnter += GlobalHover;
            _K0.MouseHover += GlobalLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(72, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(493, 447);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.LoadCompleted += PICLOADED_BREAD;
            pictureBox1.Paint += PAINT;
            // 
            // panel1
            // 
            panel1.Controls.Add(axWindowsMediaPlayer1);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 457);
            panel1.TabIndex = 22;
            panel1.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(-57, -95);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(790, 623);
            axWindowsMediaPlayer1.TabIndex = 20;
            // 
            // Calu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(620, 437);
            Controls.Add(_Is);
            Controls.Add(_Back);
            Controls.Add(_Point);
            Controls.Add(_K0);
            Controls.Add(_Plus);
            Controls.Add(_K3);
            Controls.Add(_K2);
            Controls.Add(_K1);
            Controls.Add(_Min);
            Controls.Add(_K6);
            Controls.Add(_K5);
            Controls.Add(_K4);
            Controls.Add(_Multy);
            Controls.Add(_K9);
            Controls.Add(_K8);
            Controls.Add(_K7);
            Controls.Add(_Devide);
            Controls.Add(_Procent);
            Controls.Add(_Save);
            Controls.Add(_AC);
            Controls.Add(_Screen);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(640, 480);
            MinimumSize = new Size(640, 480);
            Name = "Calu";
            Opacity = 0.9D;
            Text = "Bread_Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _Screen;
        private Button _AC;
        private Button _Save;
        private Button _Procent;
        private Button _Devide;
        private Button _Multy;
        private Button _K9;
        private Button _K8;
        private Button _K7;
        private Button _Min;
        private Button _K6;
        private Button _K5;
        private Button _K4;
        private Button _Plus;
        private Button _K3;
        private Button _K2;
        private Button _K1;
        private Button _Is;
        private Button _Back;
        private Button _Point;
        private Button _K0;
        private PictureBox pictureBox1;
        private Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

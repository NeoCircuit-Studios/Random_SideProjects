namespace ZesHoekLatenDraaien
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label1 = new Label();
            textBoxoffsetX = new TextBox();
            textBoxoffsetY = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            DrawTimeLabel = new Label();
            TickTime = new Label();
            ForLoopTime = new Label();
            fpslabel = new Label();
            drawcallslabel = new Label();
            textBox_HoekenStepps = new TextBox();
            label4 = new Label();
            textBoxFixedHoeken = new TextBox();
            label5 = new Label();
            textBoxSpinSpeed = new TextBox();
            label6 = new Label();
            labelspinspeed = new Label();
            label7 = new Label();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            label8 = new Label();
            textBoxScaleX = new TextBox();
            textBoxScaleY = new TextBox();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 429);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += UPaint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(612, 383);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Rest";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ResetB;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(612, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Hoeken:";
            // 
            // textBoxoffsetX
            // 
            textBoxoffsetX.Location = new Point(612, 245);
            textBoxoffsetX.Name = "textBoxoffsetX";
            textBoxoffsetX.Size = new Size(100, 23);
            textBoxoffsetX.TabIndex = 3;
            // 
            // textBoxoffsetY
            // 
            textBoxoffsetY.Location = new Point(612, 301);
            textBoxoffsetY.Name = "textBoxoffsetY";
            textBoxoffsetY.Size = new Size(100, 23);
            textBoxoffsetY.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 283);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "OffsetY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(612, 227);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 6;
            label3.Text = "OffsetX";
            // 
            // button2
            // 
            button2.Location = new Point(612, 343);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Set";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SET;
            // 
            // DrawTimeLabel
            // 
            DrawTimeLabel.AutoSize = true;
            DrawTimeLabel.Location = new Point(612, 12);
            DrawTimeLabel.Name = "DrawTimeLabel";
            DrawTimeLabel.Size = new Size(91, 15);
            DrawTimeLabel.TabIndex = 8;
            DrawTimeLabel.Text = "DrawTime (MS):";
            // 
            // TickTime
            // 
            TickTime.AutoSize = true;
            TickTime.Location = new Point(612, 62);
            TickTime.Name = "TickTime";
            TickTime.Size = new Size(57, 15);
            TickTime.TabIndex = 9;
            TickTime.Text = "TickTime:";
            // 
            // ForLoopTime
            // 
            ForLoopTime.AutoSize = true;
            ForLoopTime.Location = new Point(612, 37);
            ForLoopTime.Name = "ForLoopTime";
            ForLoopTime.Size = new Size(80, 15);
            ForLoopTime.TabIndex = 10;
            ForLoopTime.Text = "ForLoopTime:";
            // 
            // fpslabel
            // 
            fpslabel.AutoSize = true;
            fpslabel.Location = new Point(612, 426);
            fpslabel.Name = "fpslabel";
            fpslabel.Size = new Size(29, 15);
            fpslabel.TabIndex = 11;
            fpslabel.Text = "FPS:";
            // 
            // drawcallslabel
            // 
            drawcallslabel.AutoSize = true;
            drawcallslabel.Location = new Point(612, 115);
            drawcallslabel.Name = "drawcallslabel";
            drawcallslabel.Size = new Size(65, 15);
            drawcallslabel.TabIndex = 12;
            drawcallslabel.Text = "DrawCalls: ";
            // 
            // textBox_HoekenStepps
            // 
            textBox_HoekenStepps.Location = new Point(612, 189);
            textBox_HoekenStepps.Name = "textBox_HoekenStepps";
            textBox_HoekenStepps.Size = new Size(100, 23);
            textBox_HoekenStepps.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(613, 165);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 14;
            label4.Text = "Hoeken++";
            // 
            // textBoxFixedHoeken
            // 
            textBoxFixedHoeken.Location = new Point(718, 189);
            textBoxFixedHoeken.Name = "textBoxFixedHoeken";
            textBoxFixedHoeken.Size = new Size(70, 23);
            textBoxFixedHoeken.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(712, 165);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 16;
            label5.Text = "FixedHoeken";
            // 
            // textBoxSpinSpeed
            // 
            textBoxSpinSpeed.Location = new Point(802, 189);
            textBoxSpinSpeed.Name = "textBoxSpinSpeed";
            textBoxSpinSpeed.Size = new Size(78, 23);
            textBoxSpinSpeed.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(802, 171);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 18;
            label6.Text = "SpinSpeed";
            // 
            // labelspinspeed
            // 
            labelspinspeed.AutoSize = true;
            labelspinspeed.Location = new Point(612, 139);
            labelspinspeed.Name = "labelspinspeed";
            labelspinspeed.Size = new Size(68, 15);
            labelspinspeed.TabIndex = 19;
            labelspinspeed.Text = "SpinSpeed: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(718, 227);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 20;
            label7.Text = "X";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(718, 245);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(70, 23);
            textBoxX.TabIndex = 21;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(718, 301);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(70, 23);
            textBoxY.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(718, 283);
            label8.Name = "label8";
            label8.Size = new Size(14, 15);
            label8.TabIndex = 23;
            label8.Text = "Y";
            // 
            // textBoxScaleX
            // 
            textBoxScaleX.Location = new Point(802, 245);
            textBoxScaleX.Name = "textBoxScaleX";
            textBoxScaleX.Size = new Size(78, 23);
            textBoxScaleX.TabIndex = 24;
            // 
            // textBoxScaleY
            // 
            textBoxScaleY.Location = new Point(802, 301);
            textBoxScaleY.Name = "textBoxScaleY";
            textBoxScaleY.Size = new Size(78, 23);
            textBoxScaleY.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(802, 227);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 26;
            label9.Text = "Scale X";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(801, 281);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 27;
            label10.Text = "Scale Y";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBoxScaleY);
            Controls.Add(textBoxScaleX);
            Controls.Add(label8);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(label7);
            Controls.Add(labelspinspeed);
            Controls.Add(label6);
            Controls.Add(textBoxSpinSpeed);
            Controls.Add(label5);
            Controls.Add(textBoxFixedHoeken);
            Controls.Add(label4);
            Controls.Add(textBox_HoekenStepps);
            Controls.Add(drawcallslabel);
            Controls.Add(fpslabel);
            Controls.Add(ForLoopTime);
            Controls.Add(TickTime);
            Controls.Add(DrawTimeLabel);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxoffsetY);
            Controls.Add(textBoxoffsetX);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "ZesHoek";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Label label1;
        private TextBox textBoxoffsetX;
        private TextBox textBoxoffsetY;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label DrawTimeLabel;
        private Label TickTime;
        private Label ForLoopTime;
        private Label fpslabel;
        private Label drawcallslabel;
        private TextBox textBox_HoekenStepps;
        private Label label4;
        private TextBox textBoxFixedHoeken;
        private Label label5;
        private TextBox textBoxSpinSpeed;
        private Label label6;
        private Label labelspinspeed;
        private Label label7;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Label label8;
        private TextBox textBoxScaleX;
        private TextBox textBoxScaleY;
        private Label label9;
        private Label label10;
    }
}

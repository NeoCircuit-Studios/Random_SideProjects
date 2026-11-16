using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinglePong
{
    public partial class Form1 : Form
    {
        int fx = 0;
        int fy = 0;

        bool IsGoingDown = true;
        bool IsGoingRight = true;
        int ballstraal = 10;
        int ballposX = 10;
        int ballposY = 10;
        int ballspeed = 5;
        Pen ball_pen = new Pen(Color.Blue, 5);
        Brush ball_brush = new SolidBrush(Color.LightBlue);


        Point player0_Pos0 = new /*def*/Point(100, 100);
        Point player0_Pos1 = new /*def*/Point(200, 100);
        int player0_lenght = 150;
        Pen player0_pen = new Pen(Color.Blue, 20);

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(600, 600);
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.Location = new Point(10, 10);

            fx = this.Width;
            fy = this.Height;

            player0_Pos0.Y = fy - 150;
            player0_Pos1.Y = fy - 150;

            ballposX += ballstraal;
            ballposY += ballstraal;
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawEllipse(ball_pen, ballposX, ballposY, ballstraal * 2, ballstraal * 2);
            g.FillEllipse(ball_brush, ballposX, ballposY, ballstraal * 2, ballstraal * 2);
            g.DrawLine(player0_pen, player0_Pos0, player0_Pos1);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            player0_Pos0.X = e.X - player0_lenght/2/*get middle*/;
            player0_Pos1.X = (player0_lenght /2)/*set lenght*/ + e.X;
        }

        private void timer0_Tick(object sender, EventArgs e)
        {
            if (IsGoingDown)
            {
                ballposX += ballspeed;
            }
            else
            {
                ballposX -= ballspeed;
            }
            if (IsGoingRight)
            {
                ballposY += ballspeed;
            }
            else
            {
                ballposY -= ballspeed;
            }

            /*check player0*/
            if (ballposX >= (player0_Pos0.X) &&
                ballposX <= (player0_Pos1.X) &&
                ballposX >= (player0_Pos0.Y))
            {
                IsGoingDown = !IsGoingDown;
                IsGoingRight = !IsGoingRight;
            }

            /*check walls*/
            if (ballposX >= fx || ballposX <= 0)
            {
                IsGoingRight = !IsGoingRight;
            }
            if (ballposY >= fy || ballposY <= 0) 
            {
                IsGoingDown = !IsGoingDown;
            }

            pictureBox1.Invalidate();
        }
    }
}

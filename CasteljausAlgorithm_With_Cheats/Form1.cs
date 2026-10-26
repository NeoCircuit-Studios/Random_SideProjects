using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasteljausAlgorithm // Bezier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Size = new Size(300,300);
            pictureBox1.Location = new Point(10, 10);

            button1.Text = "P1";
            button1.Location = new Point(320, 10);
            button1.Size = new Size(50, 30);

            button2.Text = "P2";
            button2.Location = new Point(320, 40);
            button2.Size = new Size(50, 30);

            button3.Text = "P3";
            button3.Location = new Point(320, 40+30);
            button3.Size = new Size(50, 30);

            button4.Text = "P4";
            button4.Location = new Point(320, 40+30+30);
            button4.Size = new Size(50, 30);
        }

        Point p1 = new Point(50, 250);
        Point p2 = new Point(50, 50);
        Point p3 = new Point(250, 50);
        Point p4 = new Point(250, 250);

        bool p1Moving = true;
        bool p2Moving = false;
        bool p3Moving = false;
        bool p4Moving = false;

        bool FollowMouse = false;

        void ResetMoving()
        {
            p1Moving = false; 
            p2Moving = false; 
            p3Moving = false; 
            p4Moving = false; 
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Blue);
            Brush brush = new SolidBrush(Color.Red);

            g.FillEllipse(brush, p1.X -2, p1.Y -2, 4,4);
            g.FillEllipse(brush, p2.X -2, p2.Y -2, 4,4);
            g.FillEllipse(brush, p3.X -2, p3.Y -2, 4,4);
            g.FillEllipse(brush, p4.X -2, p4.Y -2, 4,4);

            g.DrawBezier(pen, p1, p2,p3,p4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            ResetMoving();

            if (button1.Tag == button.Tag)
            {
                p1Moving = true;
            }
            if (button2.Tag == button.Tag)
            {
                p2Moving = true;
            }
            if (button3.Tag == button.Tag)
            {
                p3Moving = true;
            }
            if (button4.Tag == button.Tag)
            {
                p4Moving = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FollowMouse = !FollowMouse;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (FollowMouse)
            {
                if (p1Moving)
                {
                    p1 = new Point(e.X, e.Y);
                }
                if (p2Moving)
                {
                    p2 = new Point(e.X, e.Y);
                }
                if (p3Moving)
                {
                    p3 = new Point(e.X, e.Y);
                }
                if (p4Moving)
                {
                    p4 = new Point(e.X, e.Y);
                }
                pictureBox1.Invalidate();
            }
        }
    }
}

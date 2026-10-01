using System.Diagnostics;

namespace ZesHoekLatenDraaien
{
    public partial class Form1 : Form
    {
        Stopwatch wh = new Stopwatch();
        Stopwatch wt = new Stopwatch();
        Stopwatch fort = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
            //pictureBox1.Size = new Size(420, 420);
            pictureBox1.Size = new Size(583, 429);
            wh.Start();
            wt.Start();
            fort.Start();
        }

        float rh = 0;
        float aantalhoeken = 6;

        float hoekstappen = 0;

        int drawcalls = 0;

        float draaisnelheid = 1;

        float offsetx = 0;
        float offsety = 0;

        float xx = 0;
        float yy = 0;

        float scaleX = 1;
        float scaleY = 1;

        Pen pen = new Pen(Color.Blue, 2);

        private void UPaint(object sender, PaintEventArgs e)
        {
            wh.Reset();
            wh.Start();
            drawcalls++;

            Graphics g = e.Graphics;

            float mpX = 291.5f; // was 210
            float mpY = 214.5f; // was 210

            float vorigeX = 0;
            float vorigeY = 0;
            for (int i = 0; i < aantalhoeken + 1; i++)
            {
                fort.Reset();
                fort.Start();
                float hoek = 360 * i / aantalhoeken + rh;
                double HoekinRadelen = Math.PI * hoek / 180;
                float x = 200 * (float)Math.Cos(HoekinRadelen);
                float y = 200 * (float)Math.Sin(HoekinRadelen);

                if (i != 0)
                {
                    try // if scale is invalid (for some reason)
                    {
                        g.DrawLine(pen, mpX + (vorigeX + xx) / scaleX, mpY + (vorigeY + yy) / scaleY, mpX + (x + xx) / scaleX, mpY + (y + yy) / scaleY);
                    }
                    catch(Exception eee)
                    {
                        // dont care
                    }
                }
                vorigeX = x + offsetx/* - rot*/;
                vorigeY = y + offsety/* - roty*/;
                ForLoopTime.Text = "ForLoopTime: " + fort.ToString();
            }

            DrawTimeLabel.Text = "DrawTime: " + wh.ToString();
            drawcallslabel.Text = "Drawcalls: " + drawcalls.ToString();
            labelspinspeed.Text = "SpinSpeed: " + draaisnelheid.ToString();
            double ms = (double)wh.Elapsed.TotalMilliseconds / 100;
            double fps = 1 / ms;
            fpslabel.Text = "FPS: " + fps.ToString();
            Debug.WriteLine(ms);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            wt.Reset();
            wt.Start();
            rh = rh + draaisnelheid;
            aantalhoeken = aantalhoeken + hoekstappen;
            label1.Text = "Hoeken: " + aantalhoeken.ToString();
            pictureBox1.Invalidate();
            TickTime.Text = "TickTime: " + wt.ToString();
        }

        private void ResetB(object sender, EventArgs e)
        {
            wt.Reset();
            wh.Reset();
            aantalhoeken = 6;
            hoekstappen = 0;
            offsetx = 0;
            offsety = 0;
            rh = 0;
            drawcalls = 0;
            draaisnelheid = 1;
            scaleX = 1;
            scaleY = 1;
            xx = 0;
            yy = 0;
        }

        private void SET(object sender, EventArgs e)
        {
            try
            {
                if (textBoxoffsetX.Text != "") offsetx = int.Parse(textBoxoffsetX.Text);
                if (textBoxoffsetY.Text != "") offsety = int.Parse(textBoxoffsetY.Text);
                if (textBox_HoekenStepps.Text != "") hoekstappen = int.Parse(textBox_HoekenStepps.Text);
                if (textBoxFixedHoeken.Text != "") aantalhoeken = int.Parse(textBoxFixedHoeken.Text);
                if (textBoxSpinSpeed.Text != "") draaisnelheid = int.Parse(textBoxSpinSpeed.Text);
                if (textBoxX.Text != "") xx = int.Parse(textBoxX.Text);
                if (textBoxY.Text != "") yy = int.Parse(textBoxY.Text);
                if (textBoxScaleX.Text != "") scaleX = int.Parse(textBoxScaleX.Text);
                if (textBoxScaleY.Text != "") scaleY = int.Parse(textBoxScaleY.Text);
            }
            catch (Exception ex)
            {
                // skip
                return;
            }
        }
    }
}

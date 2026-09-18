namespace rublixcobe
{
    public partial class Form1 : Form
    {
        bool bread_green = false;
        bool bread_blua = false;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide(); // groen
            pictureBox2.Hide(); // blue
            bread_green = false;
            bread_blua = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void right(object sender, EventArgs e)
        {
            // blue
            if (bread_green) 
            {
                pictureBox1.Hide();
                bread_green = false;
            }
            bread_blua = true;
            pictureBox2.Show(); // blue

        }

        private void left(object sender, EventArgs e)
        {
            if (bread_blua) 
            {
                pictureBox2.Hide(); // blue
                bread_blua = false;
            }
            bread_green = true;
            pictureBox1.Show();
        }
    }
}

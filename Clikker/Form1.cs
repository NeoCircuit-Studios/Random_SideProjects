namespace klikker
{
    public partial class Form1 : Form
    {
        string savefile = "BREAD.TXT";
        public Form1()
        {
            InitializeComponent();
            label1.Enabled = true;
            label1.ForeColor = Color.Green;
            // if not exist
            if (!File.Exists(savefile)) File.WriteAllText(savefile, "0");
            label2.Text = "SCORE:";
        }

        Random rand = new Random();
        int youusuckatthisgamesore = 0;
        private void clickme(object sender, EventArgs e)
        {
            youusuckatthisgamesore++;
            File.WriteAllText(savefile, youusuckatthisgamesore.ToString());
            label1.Text = youusuckatthisgamesore.ToString();
            int x = rand.Next(0, 450); 
            int y = rand.Next(0, 250);
            button1.Location = new Point(x,y);
        }
    }
}

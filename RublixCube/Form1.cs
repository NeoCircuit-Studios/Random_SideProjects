namespace rublixcobe
{
    // ---------------------------------------------------------------------
    // 18/09/2026 - Last Modified
    // Made by Alexander. Owner of NeoCircuit-Studios.
    // This is free and open source with MIT License
    // This can be used for anything.
    // Assets are from there respected owners
    // My domains cant be used.
    // THIS PROJECT DOES NOT USE ANY LLMs (AI) GENERATED CODE OR CONTENT
    // THIS IS A PROTOTYPE, NOT 100% WORKING PROGRAM, EXPECT BUGS ETC.
    // ---------------------------------------------------------------------

    // License:

    //MIT License

    //Copyright(c) 2026 NeoCircuit-Studios

    //Permission is hereby granted, free of charge, to any person obtaining a copy
    //of this software and associated documentation files (the "Software"), to deal
    //in the Software without restriction, including without limitation the rights
    //to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    //copies of the Software, and to permit persons to whom the Software is
    //furnished to do so, subject to the following conditions:

    //The above copyright notice and this permission notice shall be included in all
    //copies or substantial portions of the Software.

    //THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    //IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    //FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    //AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    //LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    //OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    //SOFTWARE.

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

using AxWMPLib;
using System.Drawing.Design;
using System.Media;
using System.Windows.Forms;

namespace Bread_Calculator
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



    // NOTE: All assets are Streamed (from HTTPS). But the sources are included in this project.
    public partial class Calu : Form
    {
        Image image = null;
        bool breadimageloaded = false;
        SoundPlayer sound = new SoundPlayer();
        bool breadsoundloaded = false;
        public Calu()
        {
            InitializeComponent();

            // 18/09/26: added live backgroud.
            // as i didint know that before.
            // 

            // well for some reason it needs a visable panel to play
            // the video???
            panel1.Show(); 

            // no UI crap
            axWindowsMediaPlayer1.enableContextMenu = false;

            axWindowsMediaPlayer1.settings.setMode("loop", true);
            // no UI crap
            axWindowsMediaPlayer1.uiMode = "none";

            // mute i dont want any sound
            axWindowsMediaPlayer1.settings.volume = 0;

            //                            Please use your own assets...
            axWindowsMediaPlayer1.URL = "https://neocircuit-studios.com/stream/pub/base/bread.mp4";

            // preload on a other thread the image because its big and we dont 
            // want to wait for it while the program starts...
            sound.LoadCompleted += SOUNDLOADED_BREAD;
            //                      Please use your own assets...
            pictureBox1.LoadAsync("https://neocircuit-studios.com/stream/pub/bread_calculator/breadgifsheet.png");
            //                      Please use your own assets...
            sound.SoundLocation = "https://neocircuit-studios.com/stream/pub/bread_calculator/breadsong.wav";
            sound.LoadAsync();

            // preload the image bc its big and we dont 
            // want to wait for it..
            sound.LoadCompleted += SOUNDLOADED_BREAD;
            pictureBox1.LoadAsync("https://neocircuit-studios.com/stream/pub/bread_calculator/breadgifsheet.png");
            sound.SoundLocation = "https://neocircuit-studios.com/stream/pub/bread_calculator/breadsong.wav";
            sound.LoadAsync();
        }

        int screencount = 0;

        // 32bit because it will not cross that anyway..
        Int32 slot0 = 0;
        Int32 slot1 = 0;

        bool slot0used = false;
        bool slot1used = false;
        bool isresoled = false;
        string KeyAlreadyPressed = "null"; // used for e.g 33+33 = 66 

        // type of calculation..
        enum calutype
        {
            Null,
            Plus,
            Min,
            Defide,
            Multypl,
            Procent
        }
        calutype ecalutype;

        private void UpdateScreen(string id, bool reset = false)
        {
            if (reset)
                Reset();

            _Screen.Text += id;

            if (5 == screencount)
            {
                Reset();
                MessageBox.Show("RAM IS FULL LOL", "ERROR");
            }
            else screencount++;
        }

        private void Reset()
        {
            // reset all slots
            slot0 = 0;
            slot1 = 0;
            slot0used = false;
            slot1used = false;
            // and screen
            ResetScreenOnly();
            // and other shit
            ecalutype = calutype.Null;
            KeyAlreadyPressed = "null";
        }
        private void ResetScreenOnly()
        {
            screencount = 0;
            _Screen.Text = "";
        }

        // helper for adding numm
        private void Do(int nummer, int upnummer = 1)
        {
            // to do e.g 3*11 to get 33
            // WHICH DOES NOT WORK

            //// get the upper nummer
            //// e.g from 3 to get 33 do 33 / 3 = 11 so do
            //// 3 * 11 = 33 and add that instead
            //// also can be 3 * 111 to 333
            //int calulcate = nummer * upnummer;
            //// still show the normal nummer to not get e.g 333 from upper
            //UpdateScreen(nummer.ToString()); 
            //if (!slot0used)
            //    slot0 += calulcate;
            //else if (!slot1used && slot0used)
            //    slot1 += calulcate;

            UpdateScreen(nummer.ToString());
            if (!slot0used)
                slot0 += nummer;
            else if (!slot1used && slot0used)
                slot1 += nummer;
        }

        // reset the crap
        private void AC(object sender, EventArgs e)
        {
            Reset();
        }

        private void Save(object sender, EventArgs e)
        {
            // TODO: save to file
            // or something idk
            MessageBox.Show("this does not work :)", "TODO");
        }

        // solve the shit
        private void Is(object sender, EventArgs e)
        {
            isresoled = true; // set this FIRST to then reset the screen.

            if (slot0 == 0)
                MessageBox.Show("SLOT0 is null", "ERROR");
            if (slot1 == 0 && ecalutype != calutype.Procent) // if Procent then SLOT1 can be null
                MessageBox.Show("SLOT1 is null", "ERROR");

            // there can be only ONE state at the time so no else if
            if (ecalutype == calutype.Null)
            {
                MessageBox.Show("No Operator is used!", "Error");
                return; // STOP
            }
            if (ecalutype == calutype.Plus)
            {
                int IS = slot0 + slot1;

                UpdateScreen(IS.ToString(), true);
            }
            if (ecalutype == calutype.Min)
            {
                int IS = slot0 - slot1;

                UpdateScreen(IS.ToString(), true);
            }
            if (ecalutype == calutype.Multypl)
            {
                int IS = slot0 * slot1;

                UpdateScreen(IS.ToString(), true);
            }
            if (ecalutype == calutype.Defide)
            {
                int IS = slot0 / slot1;

                UpdateScreen(IS.ToString(), true);
            }
            if (ecalutype == calutype.Procent)
            {
                // this will not do anything because the nummers are 
                // too low.. haha

                int IS = slot0 / 100;

                UpdateScreen(IS.ToString(), true);
            }
        }

        private void Point(object sender, EventArgs e)
        {
            MessageBox.Show("this does also not work :)))", "LOL");
        }

        private void K0(object sender, EventArgs e)
        {
            // LOL you cant even use 0 lol

            // isresoled is used to know
            // if it was calu something before
            // so no +4 etc..
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(0);
        }

        private void Plus(object sender, EventArgs e)
        {
            // skip me
            //string tmpstring = _Screen.Text;
            //uint tmpcalu = uint.Parse(tmpstring);
            //slot0 = tmpcalu;

            // set the status to plus

            ecalutype = calutype.Plus;
            // switch the slots
            // so int one is full now full the other one.
            if (!slot0used) slot0used = true;
            else if (slot0used && !slot1used)
                slot1used = true;

            UpdateScreen("+");
        }

        private void K3(object sender, EventArgs e)
        {
            // this is for if you want to do 
            // e.g 33 + 33 = 66 
            // WHICH DOES NOT WORK

            //string u = "K3";
            //string uu = "K33";
            //string uuu = "K333";

            //if (isresoled) 
            //{
            //    ResetScreenOnly();
            //    isresoled = false;
            //}

            //if (KeyAlreadyPressed != u) 
            //{
            //    Do(3);
            //}
            //else if (KeyAlreadyPressed == u)
            //{
            //    Do(3,11);
            //}
            //else if (KeyAlreadyPressed == uu)
            //{
            //    Do(3,111);
            //}
            //else if (KeyAlreadyPressed == uuu)
            //{
            //    Do(3,1111);
            //}
            //else { /*nothing*/ }


            //// remember that already pressed
            //if (KeyAlreadyPressed != u) KeyAlreadyPressed = u; 
            //else if (KeyAlreadyPressed == u) KeyAlreadyPressed = uu;
            //else if (KeyAlreadyPressed == uu) KeyAlreadyPressed = uuu;
            //else if (KeyAlreadyPressed == uuu) KeyAlreadyPressed = uuu;


            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }
            Do(3);
        }

        private void K1(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(1);
        }

        private void K2(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(2);
        }

        private void Min(object sender, EventArgs e)
        {
            ecalutype = calutype.Min;
            if (!slot0used) slot0used = true;
            else if (slot0used && !slot1used)
                slot1used = true;

            UpdateScreen("-");
        }

        private void K6(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(6);
        }

        private void K5(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(5);
        }

        private void K4(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(4);
        }

        private void Multy(object sender, EventArgs e)
        {
            ecalutype = calutype.Multypl;
            if (!slot0used) slot0used = true;
            else if (slot0used && !slot1used)
                slot1used = true;

            UpdateScreen("x");
        }

        private void K9(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(9);
        }

        private void K8(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(8);
        }

        private void K7(object sender, EventArgs e)
        {
            if (isresoled)
            {
                ResetScreenOnly();
                isresoled = false;
            }

            Do(7);
        }

        private void Devide(object sender, EventArgs e)
        {
            ecalutype = calutype.Defide;
            if (!slot0used) slot0used = true;
            else if (slot0used && !slot1used)
                slot1used = true;

            UpdateScreen("/");
        }

        private void Procent(object sender, EventArgs e)
        {
            ecalutype = calutype.Procent;
            if (!slot0used) slot0used = true;
            else if (slot0used && !slot1used)
                slot1used = true;

            UpdateScreen("%");
        }

        private void GlobalHover(object sender, EventArgs e)
        {
            // do not use
        }

        private void GlobalLeave(object sender, EventArgs e)
        {
            // do not use
        }

        // show bread image and hide butt and screen
        int x = 0;
        int y = 50;
        int numimages = 124;
        int imagex = 480; // DO NOT TOUCH THIS
        int startx = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int i = 0;
        bool doones = false;
        private void Bread(object sender, EventArgs e)
        {
            // check if downloaded..
            if (!breadimageloaded)
            {
                MessageBox.Show("Wait Image is still downloading..", "WAIT");
                return;
            }
            if (!breadsoundloaded)
            {
                MessageBox.Show("Wait Sound is still downloading..", "WAIT");
                return;

            }

            // there is a bug that the bread image loads/draws 2 times after sometime.. 
            // I think it is because of the live background image... (axWindowsMediaPlayer1)
            if (!doones) 
            {
                doones = true;
                // NOTE: if this is pressed then you cant leave this..
                // youll need to quit and restart..
                // TODO: make it so you can go back to the calucator.



                // stop the live backgroud video
                axWindowsMediaPlayer1.close();
                axWindowsMediaPlayer1.Hide();
                // YES hide it 
                panel1.Hide();

                // hide calu with panel
                // move above calu:
                //panel1.Location = new Point(-5, -3);
                panel1.BringToFront();
                panel1.Show();

                // is already loaded (i think)
                image = pictureBox1.Image;
                // stop it from auto drawing
                pictureBox1.Image = null;
                pictureBox1.BringToFront();
                pictureBox1.Visible = true;
                pictureBox1.Enabled = true;
                pictureBox1.Invalidate();

                // reset
                i = 0;

                // speed of the image sheet
                timer.Interval = 1; // lower then 50 does nothing, we are CPU bound here so lol
                timer.Start();
                timer.Tick += tick;
                sound.PlayLooping();
            }
        }

        private void tick(object senter, EventArgs e)
        {
            // very ms we move the sprite to the right
            if (i < numimages)
            {
                //            MINUS HERE.
                int tmpx = startx - (i * imagex);
                x = tmpx;
                pictureBox1.Invalidate(); // draw
                i++;
            }
            else
            {
                i = 0;
                //timer.Stop();
            }
        }

        private void PAINT(object sender, PaintEventArgs e)
        {
            if (image != null)
            {
                // the +7 is to hide the other bread with moving every frame +7
                e.Graphics.DrawImage(image, x + 7, y);
            }
        }

        // helper fucn for loading on other thread

        private void SOUNDLOADED_BREAD(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            breadsoundloaded = true;
        }

        private void PICLOADED_BREAD(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            breadimageloaded = true;
        }
    }
}

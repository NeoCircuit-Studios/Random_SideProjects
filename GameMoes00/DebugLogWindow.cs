using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMoes_00
{
    public partial class DebugLogWindow : Form
    {
        Game game = null;
        public DebugLogWindow()
        {
            InitializeComponent();
            uLog.Init(LogTextBox);

            game = new Game();
            game.Show();
        }

        private void KillGameClick(object sender, EventArgs e)
        {
            Bread.GetLog().Info("KillGameClick() pressed");
            game.Shutdown();
            game.Close();
        }
    }
}

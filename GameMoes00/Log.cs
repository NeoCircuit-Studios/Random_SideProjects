using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMoes_00
{
    class uLog()
    {
        static TextBox Logtexter;
        // do not log if not debug (will save fps and cpu)
        static bool Logenabled = false;
        static public void Init(TextBox text) 
        {
            Logtexter = text;
            Logenabled = true;
        }
        public void Info(string message) 
        {
            if (Logenabled) Logtexter.AppendText("INFO: " + message + Environment.NewLine);
        }
        public void Error(string message)
        {
            if (Logenabled) Logtexter.AppendText("ERROR: " + message + Environment.NewLine);
        }
        public void Warning(string message)
        {
            if (Logenabled) Logtexter.AppendText("WARNING: " + message + Environment.NewLine);
        }
    }
}

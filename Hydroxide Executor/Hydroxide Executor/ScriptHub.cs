using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;
using Oxygen;

namespace Hydroxide_Executor
{
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

        private void ScriptHub_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                WebClient wb = new WebClient();
                string Script = wb.DownloadString("https://pastebin.com/raw/xAkSZmEp");
                Execution.Execute(Script);
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    WebClient wb = new WebClient();
                    string Script = wb.DownloadString("https://pastebin.com/raw/xAkSZmEp");
                    MainAPI.Execute(Script);
                }
            }
        }
    }
}

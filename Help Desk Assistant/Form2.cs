using GetIPandName;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Assist_Info
{
    public partial class Main2 : Form
    {
        string keyMP = @"Client\Internet Facing";
        string scReg = @"SOFTWARE\Microsoft\SMS\";
        string scVersion = @"Mobile Client";
        public Main2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;          

        }

        private void Main2_Load(object sender, EventArgs e)
        {
            RegistryKey mp = Registry.LocalMachine.OpenSubKey(scReg + keyMP);
            RegistryKey scversion = Registry.LocalMachine.OpenSubKey(scReg + scVersion);
            string mps = mp.GetValue("Internet MP Hostname").ToString();
            string scv = scversion.GetValue("ProductVersion").ToString();
            txtSCDP.Text = mps;
           txtscversion.Text= scv;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //control smscfgrc
            System.Diagnostics.Process cmd = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo cmdinfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Minimized,
                FileName = "powershell.exe",
                Arguments = @"& 'C:\Program Files\Helpdesk Assistant\scripts\SCcontrol.cmd'"
            };

            cmdinfo.LoadUserProfile = true;
            cmdinfo.UseShellExecute = true;
            Process.Start(cmdinfo);
            Process.GetCurrentProcess().Kill(); 
            //cmd.StartInfo = cmdinfo;
            //cmd.Start();
        }

        private void Main2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

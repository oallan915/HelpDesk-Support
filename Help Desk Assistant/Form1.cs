using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GetIPandName
{
    public partial class main : Form
    {

        string build;

        string mWifi;
        string mEth;
        string vpn;
        System.Windows.Forms.Timer SCRefreshtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer WUPRefreshtimer = new System.Windows.Forms.Timer();

        System.Windows.Forms.Timer CPRefreshtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer ftimer = new System.Windows.Forms.Timer();
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.Process WUPprocess = new System.Diagnostics.Process();
        System.Diagnostics.Process CPprocess = new System.Diagnostics.Process();

        System.Diagnostics.Process sn = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo sninfo = new System.Diagnostics.ProcessStartInfo
        {
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
            FileName = "powershell.exe",
            Arguments = @"& 'C:\Program Files\Helpdesk Assistant\scripts\sn.ps1'"
        };
        System.Diagnostics.Process bu = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo buinfo = new System.Diagnostics.ProcessStartInfo
        {
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
            FileName = "powershell.exe",
            Arguments = @"& 'C:\Program Files\Helpdesk Assistant\scripts\refresh.ps1'"
        };
        System.Diagnostics.Process SCprocess = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo SCstartInfo = new System.Diagnostics.ProcessStartInfo
        {
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
            FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Microsoft Endpoint Manager\\Configuration Manager\\Software Center.lnk",
            //Arguments = @"& 'C:\Program Files\Helpdesk Assistant\scripts\SCRefresh.ps1'"
        };

        public main()
        {
            InitializeComponent();
            //this.Activated += Form1_Activated;
            //Associate the event-handling method with 
            //the NotifyIcon object's click event.
            NComputerInfo.Click += new System.EventHandler(NotifyIcon1_Click);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;


            NComputerInfo.Visible = false;
            sn.StartInfo = sninfo;
            sn.Start();
            ftimer.Interval = 20000; // here time in milliseconds
            ftimer.Tick += process_Form_timer_Tick;
            ftimer.Start();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();

        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            Hide();
            bu.StartInfo = buinfo;
            bu.Start();
            NComputerInfo.Click += new System.EventHandler(NotifyIcon1_Click);
            timer.Interval = 20000; // here time in milliseconds
            timer.Tick += process_timer_Tick;
            timer.Start();
            NComputerInfo.Visible = false;
            ftimer.Interval = 20000; // here time in milliseconds
            ftimer.Tick += process_Form_timer_Tick;
            ftimer.Start();

        }
        // When user clicks the left mouse button display the shortcut menu.  
        // Use the SystemInformation.PrimaryMonitorMaximizedWindowSize property
        // to place the menu at the lower corner of the screen.
        public void NotifyIcon1_Click(object sender, System.EventArgs e)
        {
            string azjoined;
            string domainJoined;
            string osversion = @"software\microsoft\windows nt\currentversion";
            string device = @"Hardware\Description\System\BIOS";
            string sKey = @"System\CurrentControlSet\Control\Windows";
            RegistryKey OS = Registry.LocalMachine.OpenSubKey(osversion);
            RegistryKey dev = Registry.LocalMachine.OpenSubKey(device);
            RegistryKey key = Registry.LocalMachine.OpenSubKey(sKey);
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST           
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString(); // Get the IP 
            string domain = System.Environment.UserDomainName;
            string osv = OS.GetValue("DisplayVersion").ToString();
            string pn = OS.GetValue("ProductName").ToString();
            string serialnumber;
            string drivehealth;
            string Freespace;
            string lastboottime;
            string AZstatus;
            string edition;
            string OSDate;
            string filePath = @"C:\Program Files\Helpdesk Assistant\scripts\files\";

            string[] ip = { "" };
            try
            {
                serialnumber = System.IO.File.ReadAllText(Path.Combine(filePath, "sn.txt"));
            }
            catch
            {
                serialnumber = "null";
            }
            try
            {
                drivehealth = System.IO.File.ReadAllText(Path.Combine(filePath, "driveHealth.txt"));
            }
            catch
            {
                drivehealth = "null";
            }
            try
            {
                Freespace = System.IO.File.ReadAllText(Path.Combine(filePath, "driveFS.txt"));
            }
            catch
            {
                Freespace = "null";
            }
            try
            {
                lastboottime = System.IO.File.ReadAllText(Path.Combine(filePath, "LastbootTime.txt"));
            }
            catch
            {
                lastboottime = "null";
            }
            try
            {
                OSDate = System.IO.File.ReadAllText(Path.Combine(filePath, "OsInstallDate.txt"));
            }
            catch
            {
                OSDate = "null";
            }
            try
            {
                AZstatus = System.IO.File.ReadAllText(Path.Combine(filePath, "Azstatus.txt"));
            }
            catch
            {
                AZstatus = "Not Avaliable";
            }
            try
            {
                edition = System.IO.File.ReadAllText(Path.Combine(filePath, "edition.txt"));
            }
            catch
            {
                edition = "null";
            }
            try
            {
                build = System.IO.File.ReadAllText(Path.Combine(filePath, "build.txt"));
            }
            catch
            {
                build = "null";
            }
            try
            {
                ip = System.IO.File.ReadAllLines(Path.Combine(filePath, "ip.txt"));
            }
            catch
            {
                ip[0] = "null";
            }
            try
            {
                mEth = System.IO.File.ReadAllText(Path.Combine(filePath, "ethernet.txt"));
            }
            catch
            {
                mEth = "null";
            }
            try
            {
                mWifi = System.IO.File.ReadAllText(Path.Combine(filePath, "wifi.txt"));
            }
            catch
            {
                mWifi = "null";
            }
            try
            {
                vpn = System.IO.File.ReadAllText(Path.Combine(filePath, "vpn.txt"));
            }
            catch
            {
                vpn = "null";
            }


            if (AZstatus.Contains("DomainJoined"))
            {
                //domainJoined = l.Split(':')[1];   
                azjoined = " YES";
                domainJoined = " YES";

            }
            else if (AZstatus.Contains("1"))
            {
                azjoined = " YES";
                domainJoined = " NO";

            }
            else
            {
                azjoined = " NO";
                domainJoined = " NO";

            }

            if ((azjoined.Equals(" YES")) && (domainJoined.Equals(" NO")))
            {
                txtDomain.Text = "Azure Only Joined";
            }
            else if (azjoined.Equals(" YES") && (domainJoined.Equals(" YES")))
            {
                txtDomain.Text = "Hybrid Joined";
            }
            else
            {

                txtDomain.Text = "null";
            }
            txtOSDate.Text = OSDate;
            txtFS.Text = Freespace;
            txtDriveH.Text = drivehealth;
            txtComputerName.Text = hostName;
            txtOSEdition.Text = edition;
            txtOSVersion.Text = osv.ToString();
            txtDevice.Text = dev.GetValue("SystemManufacturer").ToString() + "  " + dev.GetValue("SystemFamily").ToString();
            txtUserName.Text = Environment.UserName;
            txtLastTO.Text = lastboottime;
            NComputerInfo.Text = hostName;
            txtOSBuild.Text = build;
            NComputerInfo.Click += new System.EventHandler(NotifyIcon1_Click);
            txtSN.Text = serialnumber;
            lsbEthernet.Items.Clear();
            try
            {
                foreach (string n in ip)
                {
                    lsbEthernet.Items.Add(n);
                }
            }
            catch
            {
                lsbEthernet.Items.Add("null");
            }
            txtMethernet.Text = mEth;
            txtMWiFi.Text = mWifi;
            txtVPN.Text = vpn;
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reload = "Reloading";
            System.Diagnostics.Process bu = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo buinfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "powershell.exe",
                Arguments = @"& 'C:\Program Files\Helpdesk Assistant\scripts\refresh.ps1'"
            };
            bu.StartInfo = buinfo;
            bu.Start();
            txtMethernet.Clear();
            txtMWiFi.Clear();
            txtVPN.Clear();
            lsbEthernet.Items.Clear();
            lsbEthernet.Items.Add(reload);
            txtMethernet.Text = reload;
            txtMWiFi.Text = reload;
            txtVPN.Text = reload;
            timer.Interval = 15000; // here time in milliseconds
            timer.Tick += timer_Tick;
            timer.Start();
            btnReloadNet.Enabled = false;

        }
        void timer_Tick(object sender, System.EventArgs e)
        {
            string filePath = @"C:\Program Files\Helpdesk Assistant\scripts\files\";
            txtMethernet.Refresh();
            txtMWiFi.Refresh();
            txtVPN.Refresh();
            txtMethernet.Clear();
            txtMWiFi.Clear();
            txtVPN.Clear();
            lsbEthernet.Items.Clear();
            string[] ip = { "" };
            try
            {
                ip = System.IO.File.ReadAllLines(Path.Combine(filePath, "ip.txt"));
            }
            catch
            {
                ip[0] = "null";
            }
            try
            {
                mEth = System.IO.File.ReadAllText(Path.Combine(filePath, "ethernet.txt"));
            }
            catch
            {
                mEth = "null";
            }
            try
            {
                mWifi = System.IO.File.ReadAllText(Path.Combine(filePath, "wifi.txt"));
            }
            catch
            {
                mWifi = "null";
            }
            try
            {
                vpn = System.IO.File.ReadAllText(Path.Combine(filePath, "vpn.txt"));
            }
            catch
            {
                vpn = "null";
            }
            foreach (string n in ip)
            {
                lsbEthernet.Items.Add(n);
            }
            txtMethernet.Text = mEth;
            txtMWiFi.Text = mWifi;
            txtVPN.Text = vpn;
            btnReloadNet.Enabled = true;
            timer.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // this.Visible = false;
            // Create a new instance of the Form2 class


            // Show the settings form

        }

        void process_timer_Tick(object sender, System.EventArgs e)
        {
            timer.Stop();
            sn.Close();
            process.Close();
            bu.Close();
        }
        void process_Form_timer_Tick(object sender, System.EventArgs e)
        {
            ftimer.Stop();
            sn.Close();
            process.Close();
            bu.Close();
            NComputerInfo.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            SCprocess.StartInfo = SCstartInfo;
            SCprocess.Start();

            SCRefreshtimer.Interval = 5000; // here time in milliseconds
            SCRefreshtimer.Tick += process_SCRefresh_timer_Tick;
            SCRefreshtimer.Start();
            btnSCrefresh.Enabled = false;
        }
        void process_SCRefresh_timer_Tick(object sender, System.EventArgs e)
        {
            ftimer.Stop();
            SCprocess.Close();
            process.Close();
            bu.Close();
            btnSCrefresh.Enabled = true;
        }

        private void txtCP_Click(object sender, EventArgs e)
        {

            System.Diagnostics.ProcessStartInfo CPstartInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "Powershell.exe",
                Arguments = @"& 'C:\Program Files\Helpdesk Assistant\scripts\OpenCP.ps1'"
            };
            CPprocess.StartInfo = CPstartInfo;
            CPprocess.Start();

            CPRefreshtimer.Interval = 5000; // here time in milliseconds
            CPRefreshtimer.Tick += process_CPRefresh_timer_Tick;
            CPRefreshtimer.Start();
            btnCP.Enabled = false;
        }

        private void txtWUP_Click(object sender, EventArgs e)
        {


            System.Diagnostics.ProcessStartInfo WUPstartInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "powershell.exe",
                Arguments = @"& 'C:\Program Files\Helpdesk Assistant\scripts\WP.ps1'"
            };
            WUPprocess.StartInfo = WUPstartInfo;
            WUPprocess.Start();
            WUPRefreshtimer.Interval = 5000; // here time in milliseconds
            WUPRefreshtimer.Tick += process_WUPRefresh_timer_Tick;
            WUPRefreshtimer.Start();
            btnWUP.Enabled = false;
        }
        void process_CPRefresh_timer_Tick(object sender, System.EventArgs e)
        {

            CPprocess.Close();

            btnCP.Enabled = true;
        }
        void process_WUPRefresh_timer_Tick(object sender, System.EventArgs e)
        {

            WUPprocess.Close();

            btnWUP.Enabled = true;
        }

        private void NComputerInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }


}
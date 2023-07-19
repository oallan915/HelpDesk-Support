using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Windows.Forms;
namespace GetIPandName
{
    public partial class main : Form
    {
        string mWifi;
        string mEth;
        string vpn;
        System.Windows.Forms.Timer SCRefreshtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer WUPRefreshtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer CPRefreshtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer syncTimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.Process WUPprocess = new System.Diagnostics.Process();
        System.Diagnostics.Process CPprocess = new System.Diagnostics.Process();
        System.Diagnostics.Process bu = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo buinfo = new System.Diagnostics.ProcessStartInfo
        {
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
            FileName = "powershell.exe",
            Arguments = @"& 'C:\Helpdesk Assistant\scripts\refresh.ps1'"
        };
        System.Diagnostics.Process SCprocess = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo SCstartInfo = new System.Diagnostics.ProcessStartInfo
        {
            WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
            FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Microsoft Endpoint Manager\\Configuration Manager\\Software Center.lnk",
        };

        public main()
        {
            InitializeComponent();
            NComputerInfo.Click += new System.EventHandler(NotifyIcon1_Click);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            NComputerInfo.Visible = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();

        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            Hide();
          
            NComputerInfo.Click += new System.EventHandler(NotifyIcon1_Click);
            NComputerInfo.Visible = true;
          
        }
        // When user clicks the left mouse button display the shortcut menu.  
        // Use the SystemInformation.PrimaryMonitorMaximizedWindowSize property
        // to place the menu at the lower corner of the screen.
        public void NotifyIcon1_Click(object sender, System.EventArgs e)
        {

                NComputerInfo.Visible = false;
                string osversion = @"software\microsoft\windows nt\currentversion";
                string device = @"Hardware\Description\System\BIOS";
                string sKey = @"System\CurrentControlSet\Control\Windows";
                RegistryKey OS = Registry.LocalMachine.OpenSubKey(osversion);
                RegistryKey dev = Registry.LocalMachine.OpenSubKey(device);
                RegistryKey key = Registry.LocalMachine.OpenSubKey(sKey);
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST           
                string domain = System.Environment.UserDomainName;
                string osv = OS.GetValue("DisplayVersion").ToString();
                string bld = OS.GetValue("CurrentBuild").ToString();
                string sub = OS.GetValue("UBR").ToString();
                string installDate = OS.GetValue("InstallDate").ToString();
                string fullblg = bld + "." + sub;
                string pn = OS.GetValue("ProductName").ToString();
                string osedition = "";
                string snq = "SELECT * FROM Win32_Bios";
                string serial = "";
                ManagementClass mc = new ManagementClass("Win32_OperatingSystem");
                ManagementObjectSearcher moSearch = new ManagementObjectSearcher(snq);
                ManagementObjectCollection moCollection = moSearch.Get();
                ManagementObjectSearcher inst = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectCollection instd = inst.Get();
                ManagementObjectSearcher hdd = new ManagementObjectSearcher("SELECT * FROM win32_logicaldisk");
                ManagementObjectCollection ssd = hdd.Get();
                string NamespacePath = "\\\\.\\ROOT\\cimv2";
                string ClassName = "Win32_DiskDrive";
                ManagementClass oClass = new ManagementClass(NamespacePath + ":" + ClassName);
                string freespaces = "";
                string install = "";
                string date = "";
                string year = "";
                string month = "";
                string day = "";
                string bdate = "";
                string byear = "";
                string bmonth = "";
                string bday = "";
                string bootime = "";
                string calculation;
                string sign = "";
                string model = "";
                string status = "";
                foreach (ManagementObject oObject in oClass.GetInstances())
                {
                    sign = Convert.ToString(oObject["Signature"]);
                    model = Convert.ToString(oObject["Model"]);
                    status = Convert.ToString(oObject["Status"]);
                break;
                }
                Console.WriteLine(sign, model, status);
                foreach (ManagementObject mo in ssd)
                {
                    freespaces = mo["freespace"].ToString();
                break;
                }
                calculation = ((System.Convert.ToDouble(freespaces) / 1073741824)).ToString().Substring(0, 6);
                foreach (ManagementObject mo in instd)
                {

                    install = mo["InstallDate"].ToString();
                }
                year = install.Substring(0, 4);
                month = install.Substring(4, 2);
                day = install.Substring(6, 2);
                date = month + "/" + day + "/" + year;
                foreach (ManagementObject mo in moCollection)
                {
                    serial = mo["SerialNumber"].ToString();
                }
                foreach (ManagementObject mo in instd)
                {
                    osedition = mo["Caption"].ToString();
                }
                foreach (ManagementObject mo in instd)
                {
                    bootime = mo["LastBootupTime"].ToString();
                }
                byear = bootime.Substring(0, 4);
                bmonth = bootime.Substring(4, 2);
                bday = bootime.Substring(6, 2);
                bdate = bmonth + "/" + bday + "/" + byear;
                string[] ip = { "" };
                string AzureCheck = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
                Console.Write(AzureCheck);
                if (AzureCheck.Equals("waketech.edu"))
                {
                    txtDomain.Text = "Hybrid Joined";
                }
                else
                {
                    txtDomain.Text = "Azure Only Joined";
                }

                txtOSDate.Text = date;
                txtFS.Text = calculation.ToString() + " GB";
                txtDriveH.Text = status;
                txtComputerName.Text = hostName;
                txtOSEdition.Text = osedition;
                txtOSVersion.Text = osv.ToString();
                txtDevice.Text = dev.GetValue("SystemManufacturer").ToString() + "  " + dev.GetValue("SystemFamily").ToString();
                txtUserName.Text = Environment.UserName;
                txtLastTO.Text = bdate;
                NComputerInfo.Text = hostName;
                txtOSBuild.Text = fullblg;
                NComputerInfo.Click += new System.EventHandler(NotifyIcon1_Click);
                txtSN.Text = serial.ToString();
                txtDriveModel.Text = model;
                lsbEthernet.Items.Clear();
                txtMethernet.Text = "";
                txtMWiFi.Text = "";
                txtVPN.Text = "";
                WindowState = FormWindowState.Normal;
                Show();
                OS.Dispose();
                dev.Dispose();
                key.Dispose();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reload = "Loading Network Information";
            System.Diagnostics.Process bu = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo buinfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "powershell.exe",
                Arguments = @"& 'C:\Helpdesk Assistant\scripts\refresh.ps1'"
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
            bu.Dispose();          
        }
        void timer_Tick(object sender, System.EventArgs e)
        {
            string filePath = @"C:\Helpdesk Assistant\scripts\files\";
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
            process.Close();
            bu.Close();
            timer.Dispose();
            process.Dispose();
            bu.Dispose();
        }
        void process_Form_timer_Tick(object sender, System.EventArgs e)
        {
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
                Arguments = @"& 'C:\Helpdesk Assistant\scripts\OpenCP.ps1'"
            };
            CPprocess.StartInfo = CPstartInfo;
            CPprocess.Start();

            CPRefreshtimer.Interval = 5000; // here time in milliseconds
            CPRefreshtimer.Tick += process_CPRefresh_timer_Tick;
            CPRefreshtimer.Start();
            btnCP.Enabled = false;
            CPprocess.Dispose();
            
        }

        private void txtWUP_Click(object sender, EventArgs e)
        {
           System.Diagnostics.ProcessStartInfo WUPstartInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "powershell.exe",
                Arguments = @"& 'C:\Helpdesk Assistant\scripts\WP.ps1'"
            };
            WUPprocess.StartInfo = WUPstartInfo;
            WUPprocess.Start();
            WUPRefreshtimer.Interval = 5000; // here time in milliseconds
            WUPRefreshtimer.Tick += process_WUPRefresh_timer_Tick;
            WUPRefreshtimer.Start();
            btnWUP.Enabled = false;
            WUPprocess.Dispose();
        }
        private void btnSync_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process syncSC = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo sync = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "Powershell.exe",
                Arguments = @"& 'C:\Helpdesk Assistant\scripts\SCRefresh.ps1'"
            };
            syncSC.StartInfo = sync;
            syncSC.Start();
            syncTimer.Interval = 10000; // here time in milliseconds
            syncTimer.Tick += process_syncSC_timer_Tick;
            syncTimer.Start();
            btnSync.Enabled = false;
            syncSC.Dispose();
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

        void process_syncSC_timer_Tick(object sender, System.EventArgs e)
        {
            SCprocess.Close();
            process.Close();
            bu.Close();
            btnSync.Enabled = true;
        }

    }


}
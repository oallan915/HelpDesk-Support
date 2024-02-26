using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Windows.Forms;
namespace GetIPandName
{
    public partial class main : Form
    {
        System.Windows.Forms.Timer WUPRefreshtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer CPRefreshtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Diagnostics.Process process = new System.Diagnostics.Process();
        System.Diagnostics.Process bu = new System.Diagnostics.Process();


        public main()
        {
            InitializeComponent();       
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Deviceinformation myDevice = new Deviceinformation();

            NComputerInfo.Visible = true;
            txtITSMessage.Text = myDevice.HelpMessage;
            txtOSDate.Text = myDevice.OSInstallDate;
            txtComputerName.Text = myDevice.Hostname;
            txtOSEdition.Text = myDevice.OSEdition;
            txtOSVersion.Text = myDevice.OSVersion;
            txtDevice.Text = myDevice.DeviceManf;
            txtUserName.Text = Environment.UserName;
            txtLastTO.Text = myDevice.LastBootTime;
            txtDomain.Text = myDevice.Domain;
            NComputerInfo.Text = myDevice.Hostname;
            txtOSBuild.Text = myDevice.OSFullBuildNumber;
            txtSN.Text = myDevice.SerialNumber;
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deviceinformation myDevice = new Deviceinformation();
            Clipboard.SetText("Username: " + txtUserName.Text + Environment.NewLine+ "Device name: " + txtComputerName.Text + Environment.NewLine + "SN: " + txtSN.Text + Environment.NewLine + "Device Make & Model: " + txtDevice.Text + Environment.NewLine + "OS Edition: " + txtOSEdition.Text + Environment.NewLine + "OS version & build: " + txtOSVersion.Text +" - "+ txtOSBuild.Text + Environment.NewLine + "OS Install Date: " + txtOSDate.Text);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        // When user clicks the left mouse button display the shortcut menu.  
        // Use the SystemInformation.PrimaryMonitorMaximizedWindowSize property
        // to place the menu at the lower corner of the screen.
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

        void process_SCRefresh_timer_Tick(object sender, System.EventArgs e)
        {        
            process.Close();
            bu.Close();
        }

        void process_CPRefresh_timer_Tick(object sender, System.EventArgs e)
        {   
            btnCP.Enabled = true;
        }
        void process_WUPRefresh_timer_Tick(object sender, System.EventArgs e)
        {
            btnWUP.Enabled = true;
        }

        void process_syncSC_timer_Tick(object sender, System.EventArgs e)
        {
            process.Close();
            bu.Close();         
        }

        private void btnWUP_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:WindowsUpdate");
        }

        private void btnCP_Click(object sender, EventArgs e)
        {      
            Process.Start("CompanyPortal:Microsoft.CompanyPortal_8wekyb3d8bbwe!App");
        }

        private void NComputerInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Width = 743;
            Height = 404;
            Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }

    class Deviceinformation
    {

        private string hostname;
        private string osversion;
        private string osbuild;
        private string ossubbuild;
        private string osinstalldate;
        private string osedition;
        private string osproductname;
        private string osfullbuildnumber;
        private string devicemanf;
        private string domain;
        private string serial = "";
        private string lastboottime;
        private string line;
        public string Hostname
        {
            get {
                hostname = Dns.GetHostName();
                return hostname; 
            }
           
        }
        public string OSVersion
        {
            
            get {
                string osstring = "";
                try
                {
                    osstring = @"software\microsoft\windows nt\currentversion\";
                    RegistryKey OS = Registry.LocalMachine.OpenSubKey(osstring);
                    osversion = OS.GetValue("DisplayVersion").ToString();
                    OS.Dispose();
                    
                } catch (Exception)
                {

                    osstring = "Cannot gather OS version";

                }
                return osversion;
            }
          
        }
        public string OSBuild
        {
            get {
                string osstring = "";

                try
                {
                    osstring = @"software\microsoft\windows nt\currentversion\";
                    RegistryKey OS = Registry.LocalMachine.OpenSubKey(osstring);
                    osbuild = OS.GetValue("CurrentBuild").ToString();
                }
                catch (Exception)
                {

                    osbuild = "Cannot gather OS version";

                }
                return osbuild;
            }

        }
        public string OSSubBuild
        {
            get {
                string osstring = "";

                try
                {
                    osstring = @"software\microsoft\windows nt\currentversion\";
                    RegistryKey OS = Registry.LocalMachine.OpenSubKey(osstring);
                    ossubbuild = OS.GetValue("UBR").ToString();
                }
                catch (Exception)
                {

                    ossubbuild = "Cannot gather OS version";

                }
                return ossubbuild; 
            }

        }
        public string OSInstallDate
        {
            get {
                ManagementObjectSearcher inst = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectCollection instd = inst.Get();
                string install = "";
                foreach (ManagementObject mo in instd)
                {

                    install = mo["InstallDate"].ToString();
                }
                string year = install.Substring(0, 4);
                string month = install.Substring(4, 2);
                string day = install.Substring(6, 2);
                string date = month + "/" + day + "/" + year;
                osinstalldate = date;
                return osinstalldate; 
            }

        }
        public string OSProductname
        {
            get {
                string osstring = "";

                try
                {
                    osstring = @"software\microsoft\windows nt\currentversion";
                    RegistryKey OS = Registry.LocalMachine.OpenSubKey(osstring);
                    osproductname = OS.GetValue("ProductName").ToString();
                }
                catch (Exception)
                {

                    osproductname = "Cannot gather OS version";
                }
                return osproductname; }
       
        }
        public string OSEdition
        {
            get {
                ManagementObjectSearcher inst = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectCollection instd = inst.Get();
                foreach (ManagementObject mo in instd)
                {
                    osedition = mo["Caption"].ToString();
                }
                return osedition; }

        }
        public string OSFullBuildNumber
        {
            get {

                osfullbuildnumber = OSBuild + "." + OSSubBuild;
                return osfullbuildnumber; }

        }
        public string DeviceManf
        {
            get {
                string info = @"Hardware\Description\System\BIOS";
                RegistryKey dev = Registry.LocalMachine.OpenSubKey(info);
                string deviceinfo = dev.GetValue("SystemManufacturer").ToString() + "  " + dev.GetValue("SystemFamily").ToString();
                devicemanf = deviceinfo;
                return devicemanf; }

        }

        public string Domain
        {
            get {
                string AzureCheck = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
                if (AzureCheck.Equals("yu.yale.edu"))
                {
                    domain = "Hybrid Joined";
                }
                else
                {
                    domain = "Azure Only Joined";
                }
                return domain;
            }
           
        }
        public string SerialNumber
        {
            get {
                string snq = "SELECT * FROM Win32_Bios";
                ManagementObjectSearcher moSearch = new ManagementObjectSearcher(snq);
                ManagementObjectCollection moCollection = moSearch.Get();
                foreach (ManagementObject mo in moCollection)
                {
                    serial = mo["SerialNumber"].ToString();
                }
                return serial; }
            
        }
        public string LastBootTime
        {
            get {
                ManagementObjectSearcher inst = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectCollection instd = inst.Get();
                string boottime = "";
                string byear;
                string bmonth;
                string bday;
                foreach (ManagementObject mo in instd)
                {
                    boottime = mo["LastBootupTime"].ToString();
                }
                byear = boottime.Substring(0, 4);
                bmonth = boottime.Substring(4, 2);
                bday = boottime.Substring(6, 2);
                lastboottime = bmonth + "/" + bday + "/" + byear; 
                return lastboottime; }

        }
        public string HelpMessage
        {
            get {
               
                try
                {
                    line = File.ReadAllText(@"C:\Program Files\Device Information\Device Info.txt");
                    
                }
                catch (System.IO.DirectoryNotFoundException)
                {

                    line = "C:\\Program Files\\Device Information directory not found";
                }
                catch (FileNotFoundException)
                {
                    line = "Cannot find Help message file";

                }
                return line;
            }

        }

    }
    
}
namespace GetIPandName
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.lblCName = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtLastTO = new System.Windows.Forms.TextBox();
            this.NComputerInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            this.lblOSEdition = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.txtOSEdition = new System.Windows.Forms.TextBox();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.txtOSVersion = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDriveH = new System.Windows.Forms.TextBox();
            this.lblbuild = new System.Windows.Forms.Label();
            this.txtOSBuild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMac = new System.Windows.Forms.Label();
            this.grbNetwork = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSCrefresh = new System.Windows.Forms.Button();
            this.btnReloadNet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMWiFi = new System.Windows.Forms.TextBox();
            this.txtMethernet = new System.Windows.Forms.TextBox();
            this.txtVPN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsbEthernet = new System.Windows.Forms.ListBox();
            this.txtOSDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCP = new System.Windows.Forms.Button();
            this.btnWUP = new System.Windows.Forms.Button();
            this.grbNetwork.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCName.Location = new System.Drawing.Point(6, 16);
            this.lblCName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(114, 19);
            this.lblCName.TabIndex = 0;
            this.lblCName.Text = "ComputerName:";
            // 
            // txtComputerName
            // 
            this.txtComputerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComputerName.Location = new System.Drawing.Point(127, 16);
            this.txtComputerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.ReadOnly = true;
            this.txtComputerName.Size = new System.Drawing.Size(282, 27);
            this.txtComputerName.TabIndex = 2;
            this.txtComputerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.Location = new System.Drawing.Point(5, 280);
            this.lblNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(63, 19);
            this.lblNCC.TabIndex = 4;
            this.lblNCC.Text = "Domain:";
            // 
            // txtDomain
            // 
            this.txtDomain.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomain.Location = new System.Drawing.Point(127, 272);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.ReadOnly = true;
            this.txtDomain.Size = new System.Drawing.Size(282, 27);
            this.txtDomain.TabIndex = 5;
            this.txtDomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login User:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(127, 49);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(282, 27);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLastTO
            // 
            this.txtLastTO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastTO.Location = new System.Drawing.Point(127, 86);
            this.txtLastTO.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastTO.Name = "txtLastTO";
            this.txtLastTO.ReadOnly = true;
            this.txtLastTO.Size = new System.Drawing.Size(282, 27);
            this.txtLastTO.TabIndex = 10;
            this.txtLastTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NComputerInfo
            // 
            this.NComputerInfo.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NComputerInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("NComputerInfo.Icon")));
            this.NComputerInfo.Text = "Helpdesk Assistant";
            this.NComputerInfo.Visible = true;
            this.NComputerInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NComputerInfo_MouseDoubleClick);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(416, 389);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(330, 44);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Minimize Helpdesk Assistant";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // lblOSEdition
            // 
            this.lblOSEdition.AutoSize = true;
            this.lblOSEdition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSEdition.Location = new System.Drawing.Point(6, 124);
            this.lblOSEdition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOSEdition.Name = "lblOSEdition";
            this.lblOSEdition.Size = new System.Drawing.Size(80, 19);
            this.lblOSEdition.TabIndex = 12;
            this.lblOSEdition.Tag = "Installed Opertating System";
            this.lblOSEdition.Text = "OS Edition:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevice.Location = new System.Drawing.Point(5, 314);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(57, 19);
            this.lblDevice.TabIndex = 13;
            this.lblDevice.Text = "Device:";
            // 
            // txtOSEdition
            // 
            this.txtOSEdition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSEdition.Location = new System.Drawing.Point(127, 124);
            this.txtOSEdition.Margin = new System.Windows.Forms.Padding(2);
            this.txtOSEdition.Name = "txtOSEdition";
            this.txtOSEdition.ReadOnly = true;
            this.txtOSEdition.Size = new System.Drawing.Size(282, 27);
            this.txtOSEdition.TabIndex = 14;
            this.txtOSEdition.Tag = "Operating System";
            this.txtOSEdition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDevice
            // 
            this.txtDevice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevice.Location = new System.Drawing.Point(127, 306);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(2);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.ReadOnly = true;
            this.txtDevice.Size = new System.Drawing.Size(282, 27);
            this.txtDevice.TabIndex = 15;
            this.txtDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.AutoSize = true;
            this.lblOSVersion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSVersion.Location = new System.Drawing.Point(6, 164);
            this.lblOSVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(83, 19);
            this.lblOSVersion.TabIndex = 16;
            this.lblOSVersion.Text = "OS Version:";
            // 
            // txtOSVersion
            // 
            this.txtOSVersion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSVersion.Location = new System.Drawing.Point(127, 164);
            this.txtOSVersion.Margin = new System.Windows.Forms.Padding(2);
            this.txtOSVersion.Name = "txtOSVersion";
            this.txtOSVersion.ReadOnly = true;
            this.txtOSVersion.Size = new System.Drawing.Size(282, 27);
            this.txtOSVersion.TabIndex = 17;
            this.txtOSVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSN.Location = new System.Drawing.Point(6, 346);
            this.lblSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(30, 19);
            this.lblSN.TabIndex = 18;
            this.lblSN.Text = "SN:";
            // 
            // txtSN
            // 
            this.txtSN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(127, 338);
            this.txtSN.Margin = new System.Windows.Forms.Padding(2);
            this.txtSN.Name = "txtSN";
            this.txtSN.ReadOnly = true;
            this.txtSN.Size = new System.Drawing.Size(282, 27);
            this.txtSN.TabIndex = 19;
            this.txtSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Drive Free Space:";
            // 
            // txtFS
            // 
            this.txtFS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFS.Location = new System.Drawing.Point(127, 370);
            this.txtFS.Margin = new System.Windows.Forms.Padding(2);
            this.txtFS.Name = "txtFS";
            this.txtFS.ReadOnly = true;
            this.txtFS.Size = new System.Drawing.Size(282, 27);
            this.txtFS.TabIndex = 21;
            this.txtFS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Drive Health:";
            // 
            // txtDriveH
            // 
            this.txtDriveH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriveH.Location = new System.Drawing.Point(127, 406);
            this.txtDriveH.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriveH.Name = "txtDriveH";
            this.txtDriveH.ReadOnly = true;
            this.txtDriveH.Size = new System.Drawing.Size(282, 27);
            this.txtDriveH.TabIndex = 23;
            this.txtDriveH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblbuild
            // 
            this.lblbuild.AutoSize = true;
            this.lblbuild.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuild.Location = new System.Drawing.Point(5, 199);
            this.lblbuild.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbuild.Name = "lblbuild";
            this.lblbuild.Size = new System.Drawing.Size(68, 19);
            this.lblbuild.TabIndex = 24;
            this.lblbuild.Text = "OS Build:";
            // 
            // txtOSBuild
            // 
            this.txtOSBuild.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSBuild.Location = new System.Drawing.Point(127, 198);
            this.txtOSBuild.Margin = new System.Windows.Forms.Padding(2);
            this.txtOSBuild.Name = "txtOSBuild";
            this.txtOSBuild.ReadOnly = true;
            this.txtOSBuild.Size = new System.Drawing.Size(282, 27);
            this.txtOSBuild.TabIndex = 25;
            this.txtOSBuild.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Boot Time:";
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMac.Location = new System.Drawing.Point(22, 218);
            this.lblMac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(39, 18);
            this.lblMac.TabIndex = 29;
            this.lblMac.Text = "VPN:";
            // 
            // grbNetwork
            // 
            this.grbNetwork.Controls.Add(this.groupBox3);
            this.grbNetwork.Controls.Add(this.btnReloadNet);
            this.grbNetwork.Controls.Add(this.groupBox2);
            this.grbNetwork.Controls.Add(this.txtVPN);
            this.grbNetwork.Controls.Add(this.groupBox1);
            this.grbNetwork.Controls.Add(this.lblMac);
            this.grbNetwork.Location = new System.Drawing.Point(416, 12);
            this.grbNetwork.Name = "grbNetwork";
            this.grbNetwork.Size = new System.Drawing.Size(330, 372);
            this.grbNetwork.TabIndex = 30;
            this.grbNetwork.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWUP);
            this.groupBox3.Controls.Add(this.btnCP);
            this.groupBox3.Controls.Add(this.btnSCrefresh);
            this.groupBox3.Location = new System.Drawing.Point(6, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 56);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Applications";
            // 
            // btnSCrefresh
            // 
            this.btnSCrefresh.Location = new System.Drawing.Point(6, 14);
            this.btnSCrefresh.Name = "btnSCrefresh";
            this.btnSCrefresh.Size = new System.Drawing.Size(94, 36);
            this.btnSCrefresh.TabIndex = 0;
            this.btnSCrefresh.Text = "Software Center";
            this.btnSCrefresh.UseVisualStyleBackColor = true;
            this.btnSCrefresh.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnReloadNet
            // 
            this.btnReloadNet.Location = new System.Drawing.Point(25, 252);
            this.btnReloadNet.Name = "btnReloadNet";
            this.btnReloadNet.Size = new System.Drawing.Size(290, 44);
            this.btnReloadNet.TabIndex = 35;
            this.btnReloadNet.Text = "Reload Network Information";
            this.btnReloadNet.UseVisualStyleBackColor = true;
            this.btnReloadNet.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMWiFi);
            this.groupBox2.Controls.Add(this.txtMethernet);
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 95);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mac Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "Wi-Fi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ethernet:";
            // 
            // txtMWiFi
            // 
            this.txtMWiFi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMWiFi.Location = new System.Drawing.Point(103, 51);
            this.txtMWiFi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMWiFi.Name = "txtMWiFi";
            this.txtMWiFi.ReadOnly = true;
            this.txtMWiFi.Size = new System.Drawing.Size(176, 27);
            this.txtMWiFi.TabIndex = 31;
            this.txtMWiFi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMethernet
            // 
            this.txtMethernet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethernet.Location = new System.Drawing.Point(103, 18);
            this.txtMethernet.Margin = new System.Windows.Forms.Padding(2);
            this.txtMethernet.Name = "txtMethernet";
            this.txtMethernet.ReadOnly = true;
            this.txtMethernet.Size = new System.Drawing.Size(176, 27);
            this.txtMethernet.TabIndex = 30;
            this.txtMethernet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVPN
            // 
            this.txtVPN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVPN.Location = new System.Drawing.Point(109, 216);
            this.txtVPN.Margin = new System.Windows.Forms.Padding(2);
            this.txtVPN.Name = "txtVPN";
            this.txtVPN.ReadOnly = true;
            this.txtVPN.Size = new System.Drawing.Size(176, 27);
            this.txtVPN.TabIndex = 32;
            this.txtVPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsbEthernet);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 95);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Address";
            // 
            // lsbEthernet
            // 
            this.lsbEthernet.BackColor = System.Drawing.SystemColors.Menu;
            this.lsbEthernet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbEthernet.FormattingEnabled = true;
            this.lsbEthernet.ItemHeight = 16;
            this.lsbEthernet.Location = new System.Drawing.Point(6, 13);
            this.lsbEthernet.Name = "lsbEthernet";
            this.lsbEthernet.Size = new System.Drawing.Size(296, 68);
            this.lsbEthernet.TabIndex = 0;
            // 
            // txtOSDate
            // 
            this.txtOSDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSDate.Location = new System.Drawing.Point(127, 235);
            this.txtOSDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtOSDate.Name = "txtOSDate";
            this.txtOSDate.ReadOnly = true;
            this.txtOSDate.Size = new System.Drawing.Size(282, 27);
            this.txtOSDate.TabIndex = 33;
            this.txtOSDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "OS Install Date:";
            // 
            // btnCP
            // 
            this.btnCP.Location = new System.Drawing.Point(106, 14);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(94, 36);
            this.btnCP.TabIndex = 1;
            this.btnCP.Text = "Company Portal";
            this.btnCP.UseVisualStyleBackColor = true;
            this.btnCP.Click += new System.EventHandler(this.txtCP_Click);
            // 
            // btnWUP
            // 
            this.btnWUP.Location = new System.Drawing.Point(207, 14);
            this.btnWUP.Name = "btnWUP";
            this.btnWUP.Size = new System.Drawing.Size(94, 36);
            this.btnWUP.TabIndex = 2;
            this.btnWUP.Text = "Windows Updates";
            this.btnWUP.UseVisualStyleBackColor = true;
            this.btnWUP.Click += new System.EventHandler(this.txtWUP_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(758, 444);
            this.ControlBox = false;
            this.Controls.Add(this.txtOSDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbNetwork);
            this.Controls.Add(this.txtOSBuild);
            this.Controls.Add(this.lblbuild);
            this.Controls.Add(this.txtDriveH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.txtOSVersion);
            this.Controls.Add(this.lblOSVersion);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.txtOSEdition);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.lblOSEdition);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtLastTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.lblCName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helpdesk Assistant";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbNetwork.ResumeLayout(false);
            this.grbNetwork.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtLastTO;
        public System.Windows.Forms.NotifyIcon NComputerInfo;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblOSEdition;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox txtOSEdition;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.TextBox txtOSVersion;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDriveH;
        private System.Windows.Forms.Label lblbuild;
        private System.Windows.Forms.TextBox txtOSBuild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.GroupBox grbNetwork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVPN;
        private System.Windows.Forms.Button btnReloadNet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMWiFi;
        private System.Windows.Forms.TextBox txtMethernet;
        private System.Windows.Forms.ListBox lsbEthernet;
        private System.Windows.Forms.TextBox txtOSDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSCrefresh;
        private System.Windows.Forms.Button btnWUP;
        private System.Windows.Forms.Button btnCP;
    }
}


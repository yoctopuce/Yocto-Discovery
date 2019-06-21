namespace YoctoDiscovery
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.statusStrip2 = new System.Windows.Forms.StatusStrip();
      this.splitContainer3 = new System.Windows.Forms.SplitContainer();
      this.DeviceTree = new System.Windows.Forms.TreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.splitContainer4 = new System.Windows.Forms.SplitContainer();
      this.DevicePanel = new System.Windows.Forms.Panel();
      this.helloPanel = new System.Windows.Forms.Panel();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.usbPanel = new System.Windows.Forms.Panel();
      this.USBstatus = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.functionsPanel = new System.Windows.Forms.Panel();
      this.offlineLabel = new System.Windows.Forms.Label();
      this.functionList = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label10 = new System.Windows.Forms.Label();
      this.networkPanel = new System.Windows.Forms.Panel();
      this.label9 = new System.Windows.Forms.Label();
      this.textBoxIPAddr = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxMacAddr = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.devPanel = new System.Windows.Forms.Panel();
      this.writeProtected = new System.Windows.Forms.Label();
      this.textBoxStatus = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.BeaconLink = new System.Windows.Forms.Label();
      this.beaconState = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.textBoxFirmware = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxLogicalName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxSerial = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxModel = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Banner = new System.Windows.Forms.Label();
      this.logPanel = new System.Windows.Forms.TextBox();
      this.VersionLabel = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SearchParam = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.searchtimer = new System.Windows.Forms.Timer(this.components);
      this.searchresult = new System.Windows.Forms.Label();
      this.splitContainer3.Panel1.SuspendLayout();
      this.splitContainer3.Panel2.SuspendLayout();
      this.splitContainer3.SuspendLayout();
      this.splitContainer4.Panel1.SuspendLayout();
      this.splitContainer4.Panel2.SuspendLayout();
      this.splitContainer4.SuspendLayout();
      this.DevicePanel.SuspendLayout();
      this.helloPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.usbPanel.SuspendLayout();
      this.functionsPanel.SuspendLayout();
      this.networkPanel.SuspendLayout();
      this.devPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // statusStrip2
      // 
      this.statusStrip2.AutoSize = false;
      this.statusStrip2.Location = new System.Drawing.Point(0, 771);
      this.statusStrip2.Name = "statusStrip2";
      this.statusStrip2.Size = new System.Drawing.Size(765, 24);
      this.statusStrip2.TabIndex = 0;
      this.statusStrip2.Text = "statusStrip2";
      // 
      // splitContainer3
      // 
      this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer3.Location = new System.Drawing.Point(0, 0);
      this.splitContainer3.Name = "splitContainer3";
      // 
      // splitContainer3.Panel1
      // 
      this.splitContainer3.Panel1.Controls.Add(this.DeviceTree);
      // 
      // splitContainer3.Panel2
      // 
      this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
      this.splitContainer3.Size = new System.Drawing.Size(765, 771);
      this.splitContainer3.SplitterDistance = 252;
      this.splitContainer3.TabIndex = 1;
      // 
      // DeviceTree
      // 
      this.DeviceTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DeviceTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.DeviceTree.ImageIndex = 0;
      this.DeviceTree.ImageList = this.imageList1;
      this.DeviceTree.Location = new System.Drawing.Point(0, 0);
      this.DeviceTree.Name = "DeviceTree";
      this.DeviceTree.SelectedImageIndex = 0;
      this.DeviceTree.Size = new System.Drawing.Size(252, 770);
      this.DeviceTree.TabIndex = 0;
      this.DeviceTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DeviceTree_AfterSelect);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "offline.png");
      this.imageList1.Images.SetKeyName(1, "online.png");
      this.imageList1.Images.SetKeyName(2, "beacon.png");
      this.imageList1.Images.SetKeyName(3, "error.png");
      // 
      // splitContainer4
      // 
      this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer4.Location = new System.Drawing.Point(0, 0);
      this.splitContainer4.Name = "splitContainer4";
      this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer4.Panel1
      // 
      this.splitContainer4.Panel1.Controls.Add(this.DevicePanel);
      // 
      // splitContainer4.Panel2
      // 
      this.splitContainer4.Panel2.Controls.Add(this.logPanel);
      this.splitContainer4.Size = new System.Drawing.Size(509, 771);
      this.splitContainer4.SplitterDistance = 593;
      this.splitContainer4.TabIndex = 0;
      // 
      // DevicePanel
      // 
      this.DevicePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.DevicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.DevicePanel.Controls.Add(this.helloPanel);
      this.DevicePanel.Controls.Add(this.usbPanel);
      this.DevicePanel.Controls.Add(this.functionsPanel);
      this.DevicePanel.Controls.Add(this.networkPanel);
      this.DevicePanel.Controls.Add(this.devPanel);
      this.DevicePanel.Location = new System.Drawing.Point(0, 0);
      this.DevicePanel.Name = "DevicePanel";
      this.DevicePanel.Size = new System.Drawing.Size(509, 591);
      this.DevicePanel.TabIndex = 0;
      // 
      // helloPanel
      // 
      this.helloPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.helloPanel.Controls.Add(this.pictureBox2);
      this.helloPanel.Controls.Add(this.label8);
      this.helloPanel.Controls.Add(this.label11);
      this.helloPanel.Location = new System.Drawing.Point(3, 407);
      this.helloPanel.Name = "helloPanel";
      this.helloPanel.Size = new System.Drawing.Size(501, 200);
      this.helloPanel.TabIndex = 9;
      this.helloPanel.Visible = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::YoctoDiscovery.Properties.Resources.icon128;
      this.pictureBox2.Location = new System.Drawing.Point(7, 37);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(128, 128);
      this.pictureBox2.TabIndex = 2;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
      // 
      // label8
      // 
      this.label8.Location = new System.Drawing.Point(141, 37);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(339, 70);
      this.label8.TabIndex = 1;
      this.label8.Text = "Welcome to Yocto-Discovery\r\n\r\nThis application will scan your local network as we" +
    "ll as local USB ports and list any Yoctopuce device it may find. Just click on a" +
    " node in the tree on the left.";
      // 
      // label11
      // 
      this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label11.BackColor = System.Drawing.Color.DodgerBlue;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.ForeColor = System.Drawing.Color.White;
      this.label11.Location = new System.Drawing.Point(3, 5);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(495, 23);
      this.label11.TabIndex = 0;
      this.label11.Text = "Hello";
      // 
      // usbPanel
      // 
      this.usbPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.usbPanel.Controls.Add(this.USBstatus);
      this.usbPanel.Controls.Add(this.label12);
      this.usbPanel.Location = new System.Drawing.Point(4, 366);
      this.usbPanel.Name = "usbPanel";
      this.usbPanel.Size = new System.Drawing.Size(501, 75);
      this.usbPanel.TabIndex = 8;
      this.usbPanel.Visible = false;
      // 
      // USBstatus
      // 
      this.USBstatus.Location = new System.Drawing.Point(21, 37);
      this.USBstatus.Name = "USBstatus";
      this.USBstatus.Size = new System.Drawing.Size(459, 33);
      this.USBstatus.TabIndex = 1;
      // 
      // label12
      // 
      this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label12.BackColor = System.Drawing.Color.DodgerBlue;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.ForeColor = System.Drawing.Color.White;
      this.label12.Location = new System.Drawing.Point(3, 5);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(495, 23);
      this.label12.TabIndex = 0;
      this.label12.Text = "Local USB";
      // 
      // functionsPanel
      // 
      this.functionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.functionsPanel.Controls.Add(this.offlineLabel);
      this.functionsPanel.Controls.Add(this.functionList);
      this.functionsPanel.Controls.Add(this.label10);
      this.functionsPanel.Location = new System.Drawing.Point(3, 247);
      this.functionsPanel.Name = "functionsPanel";
      this.functionsPanel.Size = new System.Drawing.Size(501, 121);
      this.functionsPanel.TabIndex = 8;
      this.functionsPanel.Visible = false;
      // 
      // offlineLabel
      // 
      this.offlineLabel.AutoSize = true;
      this.offlineLabel.Location = new System.Drawing.Point(23, 56);
      this.offlineLabel.Name = "offlineLabel";
      this.offlineLabel.Size = new System.Drawing.Size(228, 13);
      this.offlineLabel.TabIndex = 2;
      this.offlineLabel.Text = "Device is OFFLINE, can\'t access functions list.";
      // 
      // functionList
      // 
      this.functionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.functionList.AutoArrange = false;
      this.functionList.BackColor = System.Drawing.SystemColors.Control;
      this.functionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.functionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.functionList.GridLines = true;
      this.functionList.Location = new System.Drawing.Point(23, 31);
      this.functionList.Name = "functionList";
      this.functionList.Size = new System.Drawing.Size(469, 79);
      this.functionList.TabIndex = 1;
      this.functionList.UseCompatibleStateImageBehavior = false;
      this.functionList.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Hardware ID";
      this.columnHeader1.Width = 150;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Logical Name";
      this.columnHeader2.Width = 150;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Value";
      this.columnHeader3.Width = 150;
      // 
      // label10
      // 
      this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label10.BackColor = System.Drawing.Color.DodgerBlue;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.ForeColor = System.Drawing.Color.White;
      this.label10.Location = new System.Drawing.Point(3, 5);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(495, 23);
      this.label10.TabIndex = 0;
      this.label10.Text = "Functions";
      // 
      // networkPanel
      // 
      this.networkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.networkPanel.Controls.Add(this.label9);
      this.networkPanel.Controls.Add(this.textBoxIPAddr);
      this.networkPanel.Controls.Add(this.label5);
      this.networkPanel.Controls.Add(this.textBoxMacAddr);
      this.networkPanel.Controls.Add(this.label6);
      this.networkPanel.Controls.Add(this.label7);
      this.networkPanel.Location = new System.Drawing.Point(4, 166);
      this.networkPanel.Name = "networkPanel";
      this.networkPanel.Size = new System.Drawing.Size(501, 75);
      this.networkPanel.TabIndex = 7;
      this.networkPanel.Visible = false;
      // 
      // label9
      // 
      this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label9.AutoSize = true;
      this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.ForeColor = System.Drawing.Color.Blue;
      this.label9.Location = new System.Drawing.Point(381, 40);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(116, 13);
      this.label9.TabIndex = 5;
      this.label9.Text = "Open in a web browser";
      this.label9.Click += new System.EventHandler(this.label9_Click);
      // 
      // textBoxIPAddr
      // 
      this.textBoxIPAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxIPAddr.Location = new System.Drawing.Point(98, 53);
      this.textBoxIPAddr.Name = "textBoxIPAddr";
      this.textBoxIPAddr.ReadOnly = true;
      this.textBoxIPAddr.Size = new System.Drawing.Size(264, 13);
      this.textBoxIPAddr.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(21, 53);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "IP addr:";
      // 
      // textBoxMacAddr
      // 
      this.textBoxMacAddr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxMacAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxMacAddr.Location = new System.Drawing.Point(98, 40);
      this.textBoxMacAddr.Name = "textBoxMacAddr";
      this.textBoxMacAddr.ReadOnly = true;
      this.textBoxMacAddr.Size = new System.Drawing.Size(257, 13);
      this.textBoxMacAddr.TabIndex = 2;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(21, 40);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(57, 13);
      this.label6.TabIndex = 1;
      this.label6.Text = "MAC addr:";
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label7.BackColor = System.Drawing.Color.DodgerBlue;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.White;
      this.label7.Location = new System.Drawing.Point(3, 5);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(495, 23);
      this.label7.TabIndex = 0;
      this.label7.Text = "Network";
      // 
      // devPanel
      // 
      this.devPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.devPanel.Controls.Add(this.writeProtected);
      this.devPanel.Controls.Add(this.textBoxStatus);
      this.devPanel.Controls.Add(this.label14);
      this.devPanel.Controls.Add(this.BeaconLink);
      this.devPanel.Controls.Add(this.beaconState);
      this.devPanel.Controls.Add(this.label13);
      this.devPanel.Controls.Add(this.textBoxFirmware);
      this.devPanel.Controls.Add(this.label4);
      this.devPanel.Controls.Add(this.textBoxLogicalName);
      this.devPanel.Controls.Add(this.label3);
      this.devPanel.Controls.Add(this.textBoxSerial);
      this.devPanel.Controls.Add(this.label1);
      this.devPanel.Controls.Add(this.textBoxModel);
      this.devPanel.Controls.Add(this.label2);
      this.devPanel.Controls.Add(this.Banner);
      this.devPanel.Location = new System.Drawing.Point(3, 3);
      this.devPanel.Name = "devPanel";
      this.devPanel.Size = new System.Drawing.Size(501, 145);
      this.devPanel.TabIndex = 0;
      // 
      // writeProtected
      // 
      this.writeProtected.AutoSize = true;
      this.writeProtected.Location = new System.Drawing.Point(22, 124);
      this.writeProtected.Name = "writeProtected";
      this.writeProtected.Size = new System.Drawing.Size(291, 13);
      this.writeProtected.TabIndex = 15;
      this.writeProtected.Text = "This device is write protected, No access to beacon control.";
      this.writeProtected.Visible = false;
      // 
      // textBoxStatus
      // 
      this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxStatus.Location = new System.Drawing.Point(99, 92);
      this.textBoxStatus.Name = "textBoxStatus";
      this.textBoxStatus.ReadOnly = true;
      this.textBoxStatus.Size = new System.Drawing.Size(394, 13);
      this.textBoxStatus.TabIndex = 14;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(22, 92);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(40, 13);
      this.label14.TabIndex = 13;
      this.label14.Text = "Status:";
      // 
      // BeaconLink
      // 
      this.BeaconLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.BeaconLink.AutoSize = true;
      this.BeaconLink.Cursor = System.Windows.Forms.Cursors.Hand;
      this.BeaconLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BeaconLink.ForeColor = System.Drawing.Color.Blue;
      this.BeaconLink.Location = new System.Drawing.Point(431, 105);
      this.BeaconLink.Name = "BeaconLink";
      this.BeaconLink.Size = new System.Drawing.Size(61, 13);
      this.BeaconLink.TabIndex = 12;
      this.BeaconLink.Text = "Beacon Off";
      this.BeaconLink.Click += new System.EventHandler(this.BeaconLink_Click);
      // 
      // beaconState
      // 
      this.beaconState.AutoSize = true;
      this.beaconState.Location = new System.Drawing.Point(95, 105);
      this.beaconState.Name = "beaconState";
      this.beaconState.Size = new System.Drawing.Size(27, 13);
      this.beaconState.TabIndex = 10;
      this.beaconState.Text = "N/A";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(21, 105);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(47, 13);
      this.label13.TabIndex = 9;
      this.label13.Text = "Beacon:";
      // 
      // textBoxFirmware
      // 
      this.textBoxFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxFirmware.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxFirmware.Location = new System.Drawing.Point(98, 79);
      this.textBoxFirmware.Name = "textBoxFirmware";
      this.textBoxFirmware.ReadOnly = true;
      this.textBoxFirmware.Size = new System.Drawing.Size(394, 13);
      this.textBoxFirmware.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(21, 79);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Firmware:";
      // 
      // textBoxLogicalName
      // 
      this.textBoxLogicalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxLogicalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxLogicalName.Location = new System.Drawing.Point(98, 66);
      this.textBoxLogicalName.Name = "textBoxLogicalName";
      this.textBoxLogicalName.ReadOnly = true;
      this.textBoxLogicalName.Size = new System.Drawing.Size(394, 13);
      this.textBoxLogicalName.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(21, 66);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Logical name:";
      // 
      // textBoxSerial
      // 
      this.textBoxSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxSerial.Location = new System.Drawing.Point(98, 53);
      this.textBoxSerial.Name = "textBoxSerial";
      this.textBoxSerial.ReadOnly = true;
      this.textBoxSerial.Size = new System.Drawing.Size(394, 13);
      this.textBoxSerial.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Serial:";
      // 
      // textBoxModel
      // 
      this.textBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxModel.Location = new System.Drawing.Point(98, 40);
      this.textBoxModel.Name = "textBoxModel";
      this.textBoxModel.ReadOnly = true;
      this.textBoxModel.Size = new System.Drawing.Size(394, 13);
      this.textBoxModel.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(21, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Model:";
      // 
      // Banner
      // 
      this.Banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.Banner.BackColor = System.Drawing.Color.DodgerBlue;
      this.Banner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Banner.ForeColor = System.Drawing.Color.White;
      this.Banner.Location = new System.Drawing.Point(3, 5);
      this.Banner.Name = "Banner";
      this.Banner.Size = new System.Drawing.Size(495, 23);
      this.Banner.TabIndex = 0;
      this.Banner.Text = "Device";
      // 
      // logPanel
      // 
      this.logPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.logPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.logPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.logPanel.Location = new System.Drawing.Point(0, 3);
      this.logPanel.Multiline = true;
      this.logPanel.Name = "logPanel";
      this.logPanel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.logPanel.Size = new System.Drawing.Size(509, 170);
      this.logPanel.TabIndex = 0;
      // 
      // VersionLabel
      // 
      this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.VersionLabel.Location = new System.Drawing.Point(642, 776);
      this.VersionLabel.Name = "VersionLabel";
      this.VersionLabel.Size = new System.Drawing.Size(110, 13);
      this.VersionLabel.TabIndex = 3;
      this.VersionLabel.Text = "version";
      this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // SearchParam
      // 
      this.SearchParam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.SearchParam.Location = new System.Drawing.Point(28, 773);
      this.SearchParam.Name = "SearchParam";
      this.SearchParam.Size = new System.Drawing.Size(100, 20);
      this.SearchParam.TabIndex = 2;
      this.SearchParam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
      this.pictureBox1.Location = new System.Drawing.Point(3, 774);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(18, 18);
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // searchtimer
      // 
      this.searchtimer.Tick += new System.EventHandler(this.searchtimer_Tick);
      // 
      // searchresult
      // 
      this.searchresult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.searchresult.AutoSize = true;
      this.searchresult.Location = new System.Drawing.Point(134, 776);
      this.searchresult.Name = "searchresult";
      this.searchresult.Size = new System.Drawing.Size(0, 13);
      this.searchresult.TabIndex = 4;
      // 
      // Form1
      // 
      this.ClientSize = new System.Drawing.Size(765, 795);
      this.Controls.Add(this.VersionLabel);
      this.Controls.Add(this.searchresult);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.SearchParam);
      this.Controls.Add(this.splitContainer3);
      this.Controls.Add(this.statusStrip2);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Yocto-Discovery";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.splitContainer3.Panel1.ResumeLayout(false);
      this.splitContainer3.Panel2.ResumeLayout(false);
      this.splitContainer3.ResumeLayout(false);
      this.splitContainer4.Panel1.ResumeLayout(false);
      this.splitContainer4.Panel2.ResumeLayout(false);
      this.splitContainer4.Panel2.PerformLayout();
      this.splitContainer4.ResumeLayout(false);
      this.DevicePanel.ResumeLayout(false);
      this.helloPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.usbPanel.ResumeLayout(false);
      this.functionsPanel.ResumeLayout(false);
      this.functionsPanel.PerformLayout();
      this.networkPanel.ResumeLayout(false);
      this.networkPanel.PerformLayout();
      this.devPanel.ResumeLayout(false);
      this.devPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion







    private System.Windows.Forms.StatusStrip statusStrip2;
    private System.Windows.Forms.SplitContainer splitContainer3;
    private System.Windows.Forms.TreeView DeviceTree;
    private System.Windows.Forms.SplitContainer splitContainer4;
    private System.Windows.Forms.Panel DevicePanel;
    private System.Windows.Forms.TextBox logPanel;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Panel devPanel;
    private System.Windows.Forms.TextBox textBoxSerial;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxModel;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label Banner;
    private System.Windows.Forms.TextBox textBoxLogicalName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel networkPanel;
    private System.Windows.Forms.TextBox textBoxIPAddr;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxMacAddr;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBoxFirmware;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel functionsPanel;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Panel usbPanel;
    private System.Windows.Forms.Label USBstatus;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Panel helloPanel;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label beaconState;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.ListView functionList;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TextBox SearchParam;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Timer searchtimer;
    private System.Windows.Forms.Label searchresult;
    private System.Windows.Forms.Label VersionLabel;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label BeaconLink;
    private System.Windows.Forms.TextBox textBoxStatus;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label offlineLabel;
    private System.Windows.Forms.Label writeProtected;
  }
}


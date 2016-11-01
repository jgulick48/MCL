namespace MineCraftLauncher
{
    partial class MineCraftMonitor
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCrashCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRestartTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelectJar = new System.Windows.Forms.Button();
            this.tbJarLoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLock = new System.Windows.Forms.Button();
            this.cbWI = new System.Windows.Forms.ComboBox();
            this.nudWI = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRW = new System.Windows.Forms.ComboBox();
            this.nudRSW = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbConsole = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReStart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbAR = new System.Windows.Forms.ComboBox();
            this.nudAutoRestartInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCC = new System.Windows.Forms.ComboBox();
            this.nudCrashCheckInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cb64 = new System.Windows.Forms.CheckBox();
            this.cbMMS = new System.Windows.Forms.ComboBox();
            this.nudMaxMem = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIMS = new System.Windows.Forms.ComboBox();
            this.nudStartMem = new System.Windows.Forms.NumericUpDown();
            this.timerSecondTick = new System.Windows.Forms.Timer(this.components);
            this.timerConsoleGrab = new System.Windows.Forms.Timer(this.components);
            this.btnBackupFolder = new System.Windows.Forms.Button();
            this.tbBackupFolder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRSW)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoRestartInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrashCheckInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMem)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCrashCheck,
            this.tsslRestartTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(722, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslCrashCheck
            // 
            this.tsslCrashCheck.Name = "tsslCrashCheck";
            this.tsslCrashCheck.Size = new System.Drawing.Size(118, 17);
            this.tsslCrashCheck.Text = "toolStripStatusLabel1";
            // 
            // tsslRestartTime
            // 
            this.tsslRestartTime.Name = "tsslRestartTime";
            this.tsslRestartTime.Size = new System.Drawing.Size(118, 17);
            this.tsslRestartTime.Text = "toolStripStatusLabel2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Memory Size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBackupFolder);
            this.groupBox1.Controls.Add(this.tbBackupFolder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSelectJar);
            this.groupBox1.Controls.Add(this.tbJarLoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnLock);
            this.groupBox1.Controls.Add(this.cbWI);
            this.groupBox1.Controls.Add(this.nudWI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbRW);
            this.groupBox1.Controls.Add(this.nudRSW);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnReStart);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.cbAR);
            this.groupBox1.Controls.Add(this.nudAutoRestartInterval);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCC);
            this.groupBox1.Controls.Add(this.nudCrashCheckInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb64);
            this.groupBox1.Controls.Add(this.cbMMS);
            this.groupBox1.Controls.Add(this.nudMaxMem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbIMS);
            this.groupBox1.Controls.Add(this.nudStartMem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 545);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSelectJar
            // 
            this.btnSelectJar.Location = new System.Drawing.Point(548, 177);
            this.btnSelectJar.Name = "btnSelectJar";
            this.btnSelectJar.Size = new System.Drawing.Size(98, 23);
            this.btnSelectJar.TabIndex = 28;
            this.btnSelectJar.Text = "Select Jar";
            this.btnSelectJar.UseVisualStyleBackColor = true;
            this.btnSelectJar.Click += new System.EventHandler(this.btnSelectJar_Click);
            // 
            // tbJarLoc
            // 
            this.tbJarLoc.Location = new System.Drawing.Point(115, 177);
            this.tbJarLoc.Name = "tbJarLoc";
            this.tbJarLoc.ReadOnly = true;
            this.tbJarLoc.Size = new System.Drawing.Size(427, 20);
            this.tbJarLoc.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Jar Location:";
            // 
            // btnLock
            // 
            this.btnLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLock.Location = new System.Drawing.Point(620, 429);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(90, 23);
            this.btnLock.TabIndex = 25;
            this.btnLock.Text = "Lock Settings";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // cbWI
            // 
            this.cbWI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWI.FormattingEnabled = true;
            this.cbWI.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.cbWI.Location = new System.Drawing.Point(548, 150);
            this.cbWI.Name = "cbWI";
            this.cbWI.Size = new System.Drawing.Size(98, 21);
            this.cbWI.TabIndex = 24;
            this.cbWI.SelectedIndexChanged += new System.EventHandler(this.cbWI_SelectedIndexChanged);
            // 
            // nudWI
            // 
            this.nudWI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWI.Location = new System.Drawing.Point(115, 151);
            this.nudWI.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWI.Name = "nudWI";
            this.nudWI.Size = new System.Drawing.Size(427, 20);
            this.nudWI.TabIndex = 23;
            this.nudWI.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWI.ValueChanged += new System.EventHandler(this.nudWI_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Warning Interval:";
            // 
            // cbRW
            // 
            this.cbRW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRW.FormattingEnabled = true;
            this.cbRW.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.cbRW.Location = new System.Drawing.Point(548, 124);
            this.cbRW.Name = "cbRW";
            this.cbRW.Size = new System.Drawing.Size(98, 21);
            this.cbRW.TabIndex = 21;
            this.cbRW.SelectedIndexChanged += new System.EventHandler(this.cbRW_SelectedIndexChanged);
            // 
            // nudRSW
            // 
            this.nudRSW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRSW.Location = new System.Drawing.Point(115, 125);
            this.nudRSW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRSW.Name = "nudRSW";
            this.nudRSW.Size = new System.Drawing.Size(427, 20);
            this.nudRSW.TabIndex = 20;
            this.nudRSW.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudRSW.ValueChanged += new System.EventHandler(this.nudRSW_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Restart Warning:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.tbInput);
            this.groupBox2.Controls.Add(this.tbConsole);
            this.groupBox2.Location = new System.Drawing.Point(6, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 266);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server output";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(527, 237);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(6, 239);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(515, 20);
            this.tbInput.TabIndex = 18;
            // 
            // tbConsole
            // 
            this.tbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsole.Location = new System.Drawing.Point(6, 19);
            this.tbConsole.Multiline = true;
            this.tbConsole.Name = "tbConsole";
            this.tbConsole.ReadOnly = true;
            this.tbConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConsole.Size = new System.Drawing.Size(596, 212);
            this.tbConsole.TabIndex = 17;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(620, 458);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop Server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReStart
            // 
            this.btnReStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReStart.Enabled = false;
            this.btnReStart.Location = new System.Drawing.Point(620, 487);
            this.btnReStart.Name = "btnReStart";
            this.btnReStart.Size = new System.Drawing.Size(90, 23);
            this.btnReStart.TabIndex = 15;
            this.btnReStart.Text = "Restart Server";
            this.btnReStart.UseVisualStyleBackColor = true;
            this.btnReStart.Click += new System.EventHandler(this.btnReStart_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(620, 516);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbAR
            // 
            this.cbAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAR.FormattingEnabled = true;
            this.cbAR.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.cbAR.Location = new System.Drawing.Point(548, 98);
            this.cbAR.Name = "cbAR";
            this.cbAR.Size = new System.Drawing.Size(98, 21);
            this.cbAR.TabIndex = 13;
            this.cbAR.SelectedIndexChanged += new System.EventHandler(this.cbAR_SelectedIndexChanged);
            // 
            // nudAutoRestartInterval
            // 
            this.nudAutoRestartInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAutoRestartInterval.Location = new System.Drawing.Point(115, 99);
            this.nudAutoRestartInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAutoRestartInterval.Name = "nudAutoRestartInterval";
            this.nudAutoRestartInterval.Size = new System.Drawing.Size(427, 20);
            this.nudAutoRestartInterval.TabIndex = 12;
            this.nudAutoRestartInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAutoRestartInterval.ValueChanged += new System.EventHandler(this.nudAutoRestartInterval_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Auto Restart:";
            // 
            // cbCC
            // 
            this.cbCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCC.FormattingEnabled = true;
            this.cbCC.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days"});
            this.cbCC.Location = new System.Drawing.Point(548, 71);
            this.cbCC.Name = "cbCC";
            this.cbCC.Size = new System.Drawing.Size(98, 21);
            this.cbCC.TabIndex = 10;
            this.cbCC.SelectedIndexChanged += new System.EventHandler(this.cbCC_SelectedIndexChanged);
            // 
            // nudCrashCheckInterval
            // 
            this.nudCrashCheckInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCrashCheckInterval.Location = new System.Drawing.Point(115, 72);
            this.nudCrashCheckInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCrashCheckInterval.Name = "nudCrashCheckInterval";
            this.nudCrashCheckInterval.Size = new System.Drawing.Size(427, 20);
            this.nudCrashCheckInterval.TabIndex = 9;
            this.nudCrashCheckInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCrashCheckInterval.ValueChanged += new System.EventHandler(this.nudCrashCheckInterval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Crash Checking:";
            // 
            // cb64
            // 
            this.cb64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb64.AutoSize = true;
            this.cb64.Location = new System.Drawing.Point(652, 20);
            this.cb64.Name = "cb64";
            this.cb64.Size = new System.Drawing.Size(53, 17);
            this.cb64.TabIndex = 7;
            this.cb64.Text = "64 Bit";
            this.cb64.UseVisualStyleBackColor = true;
            this.cb64.CheckedChanged += new System.EventHandler(this.cb64_CheckedChanged);
            // 
            // cbMMS
            // 
            this.cbMMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMMS.FormattingEnabled = true;
            this.cbMMS.Items.AddRange(new object[] {
            "MB - MegaBytes",
            "G - GigaBytes"});
            this.cbMMS.Location = new System.Drawing.Point(548, 44);
            this.cbMMS.Name = "cbMMS";
            this.cbMMS.Size = new System.Drawing.Size(98, 21);
            this.cbMMS.TabIndex = 6;
            this.cbMMS.SelectedIndexChanged += new System.EventHandler(this.cbMMS_SelectedIndexChanged);
            // 
            // nudMaxMem
            // 
            this.nudMaxMem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxMem.Location = new System.Drawing.Point(115, 45);
            this.nudMaxMem.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxMem.Name = "nudMaxMem";
            this.nudMaxMem.Size = new System.Drawing.Size(427, 20);
            this.nudMaxMem.TabIndex = 5;
            this.nudMaxMem.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.nudMaxMem.ValueChanged += new System.EventHandler(this.nudMaxMem_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max Memory Size:";
            // 
            // cbIMS
            // 
            this.cbIMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIMS.FormattingEnabled = true;
            this.cbIMS.Items.AddRange(new object[] {
            "MB - MegaBytes",
            "G - GigaBytes"});
            this.cbIMS.Location = new System.Drawing.Point(548, 18);
            this.cbIMS.Name = "cbIMS";
            this.cbIMS.Size = new System.Drawing.Size(98, 21);
            this.cbIMS.TabIndex = 3;
            this.cbIMS.SelectedIndexChanged += new System.EventHandler(this.cbIMS_SelectedIndexChanged);
            // 
            // nudStartMem
            // 
            this.nudStartMem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStartMem.Location = new System.Drawing.Point(115, 18);
            this.nudStartMem.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStartMem.Name = "nudStartMem";
            this.nudStartMem.Size = new System.Drawing.Size(427, 20);
            this.nudStartMem.TabIndex = 2;
            this.nudStartMem.Value = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.nudStartMem.ValueChanged += new System.EventHandler(this.nudStartMem_ValueChanged);
            // 
            // timerSecondTick
            // 
            this.timerSecondTick.Interval = 1000;
            this.timerSecondTick.Tick += new System.EventHandler(this.timerSecondTick_Tick);
            // 
            // timerConsoleGrab
            // 
            this.timerConsoleGrab.Interval = 10;
            this.timerConsoleGrab.Tick += new System.EventHandler(this.timerConsoleGrab_Tick);
            // 
            // btnBackupFolder
            // 
            this.btnBackupFolder.Location = new System.Drawing.Point(548, 203);
            this.btnBackupFolder.Name = "btnBackupFolder";
            this.btnBackupFolder.Size = new System.Drawing.Size(98, 23);
            this.btnBackupFolder.TabIndex = 31;
            this.btnBackupFolder.Text = "Select Folder";
            this.btnBackupFolder.UseVisualStyleBackColor = true;
            this.btnBackupFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbBackupFolder
            // 
            this.tbBackupFolder.Location = new System.Drawing.Point(115, 203);
            this.tbBackupFolder.Name = "tbBackupFolder";
            this.tbBackupFolder.ReadOnly = true;
            this.tbBackupFolder.Size = new System.Drawing.Size(427, 20);
            this.tbBackupFolder.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Backup Location:";
            // 
            // MineCraftMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MineCraftMonitor";
            this.Text = "MineCraft Monitor";
            this.Load += new System.EventHandler(this.MineCraftMonitor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRSW)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoRestartInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCrashCheckInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartMem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCrashCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbConsole;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbAR;
        private System.Windows.Forms.NumericUpDown nudAutoRestartInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCC;
        private System.Windows.Forms.NumericUpDown nudCrashCheckInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb64;
        private System.Windows.Forms.ComboBox cbMMS;
        private System.Windows.Forms.NumericUpDown nudMaxMem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIMS;
        private System.Windows.Forms.NumericUpDown nudStartMem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.ComboBox cbWI;
        private System.Windows.Forms.NumericUpDown nudWI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRW;
        private System.Windows.Forms.NumericUpDown nudRSW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel tsslRestartTime;
        private System.Windows.Forms.Button btnSelectJar;
        private System.Windows.Forms.TextBox tbJarLoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timerSecondTick;
        private System.Windows.Forms.Timer timerConsoleGrab;
        private System.Windows.Forms.Button btnBackupFolder;
        private System.Windows.Forms.TextBox tbBackupFolder;
        private System.Windows.Forms.Label label8;
    }
}


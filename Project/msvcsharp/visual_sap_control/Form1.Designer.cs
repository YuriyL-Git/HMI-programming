namespace visual_sap_control
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
        	this.combo1 = new System.Windows.Forms.ComboBox();
        	this.Edit1 = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.Edit6 = new System.Windows.Forms.TextBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.label12 = new System.Windows.Forms.Label();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.ProgrammingPassCheckBox = new System.Windows.Forms.CheckBox();
        	this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.SetSerialCheckBox = new System.Windows.Forms.CheckBox();
        	this.WriteNFCcheckBox = new System.Windows.Forms.CheckBox();
        	this.labelResult = new System.Windows.Forms.Label();
        	this.button5 = new System.Windows.Forms.Button();
        	this.button6 = new System.Windows.Forms.Button();
        	this.ExecutingBox = new System.Windows.Forms.CheckBox();
        	this.timer2 = new System.Windows.Forms.Timer(this.components);
        	this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
        	this.backgroundProgramming = new System.ComponentModel.BackgroundWorker();
        	this.ProgrammingBar = new System.Windows.Forms.ProgressBar();
        	this.waitingBar = new System.Windows.Forms.ProgressBar();
        	this.setSerialBar = new System.Windows.Forms.ProgressBar();
        	this.nfcInitBar = new System.Windows.Forms.ProgressBar();
        	this.backgroundWaiting = new System.ComponentModel.BackgroundWorker();
        	this.backgroundSetSerial = new System.ComponentModel.BackgroundWorker();
        	this.backgroundWriteInit = new System.ComponentModel.BackgroundWorker();
        	this.TopicLabel = new System.Windows.Forms.Label();
        	this.OkWait = new System.Windows.Forms.PictureBox();
        	this.OkProg = new System.Windows.Forms.PictureBox();
        	this.OkSet = new System.Windows.Forms.PictureBox();
        	this.OkNfc = new System.Windows.Forms.PictureBox();
        	this.NokProg = new System.Windows.Forms.PictureBox();
        	this.NokSet = new System.Windows.Forms.PictureBox();
        	this.NokNfc = new System.Windows.Forms.PictureBox();
        	this.WaitingLabel = new System.Windows.Forms.Label();
        	this.ProgramingLabel = new System.Windows.Forms.Label();
        	this.SetSerialLabel = new System.Windows.Forms.Label();
        	this.NfcInitLabel = new System.Windows.Forms.Label();
        	this.SerNumLabel = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.OkWait)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkProg)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkSet)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkNfc)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokProg)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokSet)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokNfc)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// combo1
        	// 
        	this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.combo1.FormattingEnabled = true;
        	this.combo1.Items.AddRange(new object[] {
			"USB",
			"Ethernet",
			"Serial"});
        	this.combo1.Location = new System.Drawing.Point(12, 12);
        	this.combo1.Name = "combo1";
        	this.combo1.Size = new System.Drawing.Size(32, 31);
        	this.combo1.TabIndex = 0;
        	this.combo1.Visible = false;
        	// 
        	// Edit1
        	// 
        	this.Edit1.Location = new System.Drawing.Point(151, 180);
        	this.Edit1.Name = "Edit1";
        	this.Edit1.Size = new System.Drawing.Size(165, 29);
        	this.Edit1.TabIndex = 6;
        	this.Edit1.Text = "COM2";
        	this.Edit1.Visible = false;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(415, 52);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(93, 23);
        	this.label2.TabIndex = 11;
        	this.label2.Text = "Cyclone1 : ";
        	this.label2.Visible = false;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(406, 15);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(152, 23);
        	this.label7.TabIndex = 21;
        	this.label7.Text = "Image to Execute: ";
        	this.label7.Visible = false;
        	// 
        	// Edit6
        	// 
        	this.Edit6.Location = new System.Drawing.Point(504, 12);
        	this.Edit6.Name = "Edit6";
        	this.Edit6.Size = new System.Drawing.Size(36, 29);
        	this.Edit6.TabIndex = 26;
        	this.Edit6.Text = "1";
        	this.Edit6.Visible = false;
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(518, 78);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(22, 23);
        	this.button1.TabIndex = 31;
        	this.button1.Text = "Read Image Description\r\n";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Visible = false;
        	this.button1.Click += new System.EventHandler(this.button1_Click);
        	// 
        	// button2
        	// 
        	this.button2.BackColor = System.Drawing.Color.Honeydew;
        	this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.button2.ForeColor = System.Drawing.Color.Honeydew;
        	this.button2.Location = new System.Drawing.Point(123, 15);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(10, 23);
        	this.button2.TabIndex = 32;
        	this.button2.Text = "Execute Programming\r\n";
        	this.button2.UseVisualStyleBackColor = false;
        	this.button2.Click += new System.EventHandler(this.button2_Click);
        	// 
        	// label12
        	// 
        	this.label12.Location = new System.Drawing.Point(572, 15);
        	this.label12.Name = "label12";
        	this.label12.Size = new System.Drawing.Size(263, 15);
        	this.label12.TabIndex = 33;
        	this.label12.Text = "label12";
        	this.label12.TextChanged += new System.EventHandler(this.Label12TextChanged);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(546, 216);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(203, 23);
        	this.button3.TabIndex = 38;
        	this.button3.Text = "Display Name\r\n\r\n";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Visible = false;
        	this.button3.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// button4
        	// 
        	this.button4.ForeColor = System.Drawing.Color.Tan;
        	this.button4.Location = new System.Drawing.Point(415, 78);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(89, 23);
        	this.button4.TabIndex = 39;
        	this.button4.Text = "Connect";
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.Visible = false;
        	this.button4.Click += new System.EventHandler(this.Button4Click);
        	// 
        	// textBox1
        	// 
        	this.textBox1.BackColor = System.Drawing.SystemColors.Window;
        	this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
        	this.textBox1.Location = new System.Drawing.Point(153, 120);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(276, 40);
        	this.textBox1.TabIndex = 0;
        	//this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
        	this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(53, 78);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(263, 15);
        	this.label1.TabIndex = 41;
        	this.label1.Text = "Info";
        	this.label1.Visible = false;
        	// 
        	// ProgrammingPassCheckBox
        	// 
        	this.ProgrammingPassCheckBox.Location = new System.Drawing.Point(566, 90);
        	this.ProgrammingPassCheckBox.Name = "ProgrammingPassCheckBox";
        	this.ProgrammingPassCheckBox.Size = new System.Drawing.Size(145, 24);
        	this.ProgrammingPassCheckBox.TabIndex = 43;
        	this.ProgrammingPassCheckBox.Text = "ProgrammingPassCheckBox";
        	this.ProgrammingPassCheckBox.UseVisualStyleBackColor = true;
        	this.ProgrammingPassCheckBox.Visible = false;
        	// 
        	// backgroundWorker1
        	// 
        	this.backgroundWorker1.WorkerSupportsCancellation = true;
        	//this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
        	this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
        	// 
        	// timer1
        	// 
        	this.timer1.Interval = 1000;
        	this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
        	// 
        	// SetSerialCheckBox
        	// 
        	this.SetSerialCheckBox.Location = new System.Drawing.Point(572, 150);
        	this.SetSerialCheckBox.Name = "SetSerialCheckBox";
        	this.SetSerialCheckBox.Size = new System.Drawing.Size(173, 24);
        	this.SetSerialCheckBox.TabIndex = 44;
        	this.SetSerialCheckBox.Text = "SetSerialCheckBox";
        	this.SetSerialCheckBox.UseVisualStyleBackColor = true;
        	this.SetSerialCheckBox.Visible = false;
        	// 
        	// WriteNFCcheckBox
        	// 
        	this.WriteNFCcheckBox.Location = new System.Drawing.Point(572, 180);
        	this.WriteNFCcheckBox.Name = "WriteNFCcheckBox";
        	this.WriteNFCcheckBox.Size = new System.Drawing.Size(157, 24);
        	this.WriteNFCcheckBox.TabIndex = 45;
        	this.WriteNFCcheckBox.Text = "WriteNFCcheckBox";
        	this.WriteNFCcheckBox.UseVisualStyleBackColor = true;
        	this.WriteNFCcheckBox.Visible = false;
        	// 
        	// labelResult
        	// 
        	this.labelResult.Font = new System.Drawing.Font("Lucida Sans Unicode", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.labelResult.ForeColor = System.Drawing.Color.Red;
        	this.labelResult.Location = new System.Drawing.Point(197, 468);
        	this.labelResult.Name = "labelResult";
        	this.labelResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
        	this.labelResult.Size = new System.Drawing.Size(343, 114);
        	this.labelResult.TabIndex = 46;
        	this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// button5
        	// 
        	this.button5.BackColor = System.Drawing.SystemColors.HighlightText;
        	this.button5.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
        	this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.button5.ForeColor = System.Drawing.Color.SeaGreen;
        	this.button5.Location = new System.Drawing.Point(745, 33);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(44, 23);
        	this.button5.TabIndex = 47;
        	this.button5.Text = "X";
        	this.button5.UseVisualStyleBackColor = false;
        	this.button5.Click += new System.EventHandler(this.Button5Click);
        	// 
        	// button6
        	// 
        	this.button6.BackColor = System.Drawing.SystemColors.HighlightText;
        	this.button6.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
        	this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.button6.ForeColor = System.Drawing.Color.Sienna;
        	this.button6.Location = new System.Drawing.Point(685, 33);
        	this.button6.Name = "button6";
        	this.button6.Size = new System.Drawing.Size(44, 23);
        	this.button6.TabIndex = 48;
        	this.button6.Text = "–";
        	this.button6.UseVisualStyleBackColor = false;
        	this.button6.Click += new System.EventHandler(this.Button6Click);
        	// 
        	// ExecutingBox
        	// 
        	this.ExecutingBox.Location = new System.Drawing.Point(572, 120);
        	this.ExecutingBox.Name = "ExecutingBox";
        	this.ExecutingBox.Size = new System.Drawing.Size(139, 24);
        	this.ExecutingBox.TabIndex = 49;
        	this.ExecutingBox.Text = "ExecutingBox";
        	this.ExecutingBox.UseVisualStyleBackColor = true;
        	this.ExecutingBox.Visible = false;
        	// 
        	// backgroundWorker2
        	// 
        	this.backgroundWorker2.WorkerSupportsCancellation = true;
        	this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2DoWork);
        	this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker2RunWorkerCompleted);
        	// 
        	// backgroundProgramming
        	// 
        	this.backgroundProgramming.WorkerReportsProgress = true;
        	this.backgroundProgramming.WorkerSupportsCancellation = true;
        	this.backgroundProgramming.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundProgrammingDoWork);
        	this.backgroundProgramming.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundProgrammingProgressChanged);
        	// 
        	// ProgrammingBar
        	// 
        	this.ProgrammingBar.Location = new System.Drawing.Point(205, 316);
        	this.ProgrammingBar.Maximum = 50;
        	this.ProgrammingBar.Name = "ProgrammingBar";
        	this.ProgrammingBar.Size = new System.Drawing.Size(349, 25);
        	this.ProgrammingBar.Step = 1;
        	this.ProgrammingBar.TabIndex = 50;
        	this.ProgrammingBar.Click += new System.EventHandler(this.ProgressBar1Click);
        	// 
        	// waitingBar
        	// 
        	this.waitingBar.BackColor = System.Drawing.Color.WhiteSmoke;
        	this.waitingBar.ForeColor = System.Drawing.SystemColors.GrayText;
        	this.waitingBar.Location = new System.Drawing.Point(205, 269);
        	this.waitingBar.Maximum = 50;
        	this.waitingBar.Name = "waitingBar";
        	this.waitingBar.Size = new System.Drawing.Size(349, 25);
        	this.waitingBar.Step = 1;
        	this.waitingBar.TabIndex = 51;
        	// 
        	// setSerialBar
        	// 
        	this.setSerialBar.Location = new System.Drawing.Point(205, 364);
        	this.setSerialBar.Maximum = 50;
        	this.setSerialBar.Name = "setSerialBar";
        	this.setSerialBar.Size = new System.Drawing.Size(349, 25);
        	this.setSerialBar.Step = 1;
        	this.setSerialBar.TabIndex = 52;
        	// 
        	// nfcInitBar
        	// 
        	this.nfcInitBar.Location = new System.Drawing.Point(205, 413);
        	this.nfcInitBar.Maximum = 50;
        	this.nfcInitBar.Name = "nfcInitBar";
        	this.nfcInitBar.Size = new System.Drawing.Size(349, 25);
        	this.nfcInitBar.Step = 1;
        	this.nfcInitBar.TabIndex = 53;
        	// 
        	// backgroundWaiting
        	// 
        	this.backgroundWaiting.WorkerReportsProgress = true;
        	this.backgroundWaiting.WorkerSupportsCancellation = true;
        	this.backgroundWaiting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWaitingDoWork);
        	this.backgroundWaiting.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWaitingProgressChanged);
        	this.backgroundWaiting.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWaitingRunWorkerCompleted);
        	// 
        	// backgroundSetSerial
        	// 
        	this.backgroundSetSerial.WorkerReportsProgress = true;
        	this.backgroundSetSerial.WorkerSupportsCancellation = true;
        	this.backgroundSetSerial.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundSetSerialDoWork);
        	this.backgroundSetSerial.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundSetSerialProgressChanged);
        	// 
        	// backgroundWriteInit
        	// 
        	this.backgroundWriteInit.WorkerReportsProgress = true;
        	this.backgroundWriteInit.WorkerSupportsCancellation = true;
        	this.backgroundWriteInit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWriteInitDoWork);
        	this.backgroundWriteInit.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWriteInitProgressChanged);
        	// 
        	// TopicLabel
        	// 
        	this.TopicLabel.BackColor = System.Drawing.Color.LightCyan;
        	this.TopicLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.TopicLabel.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.TopicLabel.ForeColor = System.Drawing.Color.ForestGreen;
        	this.TopicLabel.Location = new System.Drawing.Point(139, 15);
        	this.TopicLabel.Name = "TopicLabel";
        	this.TopicLabel.Size = new System.Drawing.Size(422, 32);
        	this.TopicLabel.TabIndex = 54;
        	this.TopicLabel.Text = "ARISTON HMI-VEL programming";
        	this.TopicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// OkWait
        	// 
        	this.OkWait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkWait.BackgroundImage")));
        	this.OkWait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.OkWait.Location = new System.Drawing.Point(576, 269);
        	this.OkWait.Name = "OkWait";
        	this.OkWait.Size = new System.Drawing.Size(25, 25);
        	this.OkWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.OkWait.TabIndex = 55;
        	this.OkWait.TabStop = false;
        	// 
        	// OkProg
        	// 
        	this.OkProg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkProg.BackgroundImage")));
        	this.OkProg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.OkProg.Location = new System.Drawing.Point(576, 316);
        	this.OkProg.Name = "OkProg";
        	this.OkProg.Size = new System.Drawing.Size(25, 25);
        	this.OkProg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.OkProg.TabIndex = 56;
        	this.OkProg.TabStop = false;
        	// 
        	// OkSet
        	// 
        	this.OkSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkSet.BackgroundImage")));
        	this.OkSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.OkSet.Location = new System.Drawing.Point(576, 364);
        	this.OkSet.Name = "OkSet";
        	this.OkSet.Size = new System.Drawing.Size(25, 25);
        	this.OkSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.OkSet.TabIndex = 57;
        	this.OkSet.TabStop = false;
        	// 
        	// OkNfc
        	// 
        	this.OkNfc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OkNfc.BackgroundImage")));
        	this.OkNfc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.OkNfc.Location = new System.Drawing.Point(576, 413);
        	this.OkNfc.Name = "OkNfc";
        	this.OkNfc.Size = new System.Drawing.Size(25, 25);
        	this.OkNfc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.OkNfc.TabIndex = 58;
        	this.OkNfc.TabStop = false;
        	// 
        	// NokProg
        	// 
        	this.NokProg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NokProg.BackgroundImage")));
        	this.NokProg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.NokProg.Location = new System.Drawing.Point(624, 316);
        	this.NokProg.Name = "NokProg";
        	this.NokProg.Size = new System.Drawing.Size(25, 25);
        	this.NokProg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.NokProg.TabIndex = 60;
        	this.NokProg.TabStop = false;
        	// 
        	// NokSet
        	// 
        	this.NokSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NokSet.BackgroundImage")));
        	this.NokSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.NokSet.Location = new System.Drawing.Point(624, 364);
        	this.NokSet.Name = "NokSet";
        	this.NokSet.Size = new System.Drawing.Size(25, 25);
        	this.NokSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.NokSet.TabIndex = 61;
        	this.NokSet.TabStop = false;
        	// 
        	// NokNfc
        	// 
        	this.NokNfc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NokNfc.BackgroundImage")));
        	this.NokNfc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        	this.NokNfc.Location = new System.Drawing.Point(624, 413);
        	this.NokNfc.Name = "NokNfc";
        	this.NokNfc.Size = new System.Drawing.Size(25, 25);
        	this.NokNfc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.NokNfc.TabIndex = 62;
        	this.NokNfc.TabStop = false;
        	// 
        	// WaitingLabel
        	// 
        	this.WaitingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.WaitingLabel.ForeColor = System.Drawing.Color.Green;
        	this.WaitingLabel.Location = new System.Drawing.Point(29, 269);
        	this.WaitingLabel.Name = "WaitingLabel";
        	this.WaitingLabel.Size = new System.Drawing.Size(170, 25);
        	this.WaitingLabel.TabIndex = 63;
        	this.WaitingLabel.Text = "Waiting for start:";
        	// 
        	// ProgramingLabel
        	// 
        	this.ProgramingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.ProgramingLabel.ForeColor = System.Drawing.Color.Green;
        	this.ProgramingLabel.Location = new System.Drawing.Point(29, 316);
        	this.ProgramingLabel.Name = "ProgramingLabel";
        	this.ProgramingLabel.Size = new System.Drawing.Size(170, 25);
        	this.ProgramingLabel.TabIndex = 64;
        	this.ProgramingLabel.Text = "Programming:";
        	// 
        	// SetSerialLabel
        	// 
        	this.SetSerialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.SetSerialLabel.ForeColor = System.Drawing.Color.Green;
        	this.SetSerialLabel.Location = new System.Drawing.Point(29, 364);
        	this.SetSerialLabel.Name = "SetSerialLabel";
        	this.SetSerialLabel.Size = new System.Drawing.Size(170, 25);
        	this.SetSerialLabel.TabIndex = 65;
        	this.SetSerialLabel.Text = "Set Serial Num:";
        	// 
        	// NfcInitLabel
        	// 
        	this.NfcInitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.NfcInitLabel.ForeColor = System.Drawing.Color.Green;
        	this.NfcInitLabel.Location = new System.Drawing.Point(29, 413);
        	this.NfcInitLabel.Name = "NfcInitLabel";
        	this.NfcInitLabel.Size = new System.Drawing.Size(170, 25);
        	this.NfcInitLabel.TabIndex = 66;
        	this.NfcInitLabel.Text = "Nfc Initialization:";
        	// 
        	// SerNumLabel
        	// 
        	this.SerNumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.SerNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.SerNumLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
        	this.SerNumLabel.Location = new System.Drawing.Point(205, 468);
        	this.SerNumLabel.Name = "SerNumLabel";
        	this.SerNumLabel.Size = new System.Drawing.Size(373, 29);
        	this.SerNumLabel.TabIndex = 67;
        	this.SerNumLabel.Text = "Serial Number: ";
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.LightCyan;
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        	this.ClientSize = new System.Drawing.Size(860, 579);
        	this.ControlBox = false;
        	this.Controls.Add(this.SerNumLabel);
        	this.Controls.Add(this.NfcInitLabel);
        	this.Controls.Add(this.SetSerialLabel);
        	this.Controls.Add(this.ProgramingLabel);
        	this.Controls.Add(this.WaitingLabel);
        	this.Controls.Add(this.NokNfc);
        	this.Controls.Add(this.NokSet);
        	this.Controls.Add(this.NokProg);
        	this.Controls.Add(this.OkNfc);
        	this.Controls.Add(this.OkSet);
        	this.Controls.Add(this.OkProg);
        	this.Controls.Add(this.OkWait);
        	this.Controls.Add(this.TopicLabel);
        	this.Controls.Add(this.nfcInitBar);
        	this.Controls.Add(this.setSerialBar);
        	this.Controls.Add(this.waitingBar);
        	this.Controls.Add(this.ProgrammingBar);
        	this.Controls.Add(this.ExecutingBox);
        	this.Controls.Add(this.button6);
        	this.Controls.Add(this.button5);
        	this.Controls.Add(this.labelResult);
        	this.Controls.Add(this.WriteNFCcheckBox);
        	this.Controls.Add(this.SetSerialCheckBox);
        	this.Controls.Add(this.ProgrammingPassCheckBox);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.label12);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.Edit6);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.Edit1);
        	this.Controls.Add(this.combo1);
        	this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.ForeColor = System.Drawing.Color.Olive;
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.KeyPreview = true;
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "HMI-VEL programming";
        	this.TopMost = true;
        	this.TransparencyKey = System.Drawing.Color.Azure;
        	this.Activated += new System.EventHandler(this.Form1Activated);
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        	this.Load += new System.EventHandler(this.Form1Load);
        	this.TextChanged += new System.EventHandler(this.Form1TextChanged);
        	this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1Paint);
        	this.DoubleClick += new System.EventHandler(this.Form1DoubleClick);
        	((System.ComponentModel.ISupportInitialize)(this.OkWait)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkProg)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkSet)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkNfc)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokProg)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokSet)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokNfc)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.ComboBox combo3;
        private System.Windows.Forms.ComboBox combo4;
        private System.Windows.Forms.ComboBox combo5;
        private System.Windows.Forms.TextBox Edit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Edit6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ProgrammingPassCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox SetSerialCheckBox;
        private System.Windows.Forms.CheckBox WriteNFCcheckBox;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox ExecutingBox;
        private System.Windows.Forms.Timer timer2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundProgramming;
        private System.Windows.Forms.ProgressBar ProgrammingBar;
        private System.Windows.Forms.ProgressBar waitingBar;
        private System.Windows.Forms.ProgressBar setSerialBar;
        private System.Windows.Forms.ProgressBar nfcInitBar;
        private System.ComponentModel.BackgroundWorker backgroundWaiting;
        private System.ComponentModel.BackgroundWorker backgroundSetSerial;
        private System.ComponentModel.BackgroundWorker backgroundWriteInit;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.PictureBox OkWait;
        private System.Windows.Forms.PictureBox OkProg;
        private System.Windows.Forms.PictureBox OkSet;
        private System.Windows.Forms.PictureBox OkNfc;
        private System.Windows.Forms.PictureBox NokProg;
        private System.Windows.Forms.PictureBox NokSet;
        private System.Windows.Forms.PictureBox NokNfc;
        private System.Windows.Forms.Label WaitingLabel;
        private System.Windows.Forms.Label ProgramingLabel;
        private System.Windows.Forms.Label SetSerialLabel;
        private System.Windows.Forms.Label NfcInitLabel;
        private System.Windows.Forms.Label SerNumLabel;
    }
}


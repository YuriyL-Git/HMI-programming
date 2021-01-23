namespace visual_sap_control
{
    partial class MainForm
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.button2 = new System.Windows.Forms.Button();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.ProgrammingPassCheckBox = new System.Windows.Forms.CheckBox();
        	this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.SetSerialCheckBox = new System.Windows.Forms.CheckBox();
        	this.WriteNFCcheckBox = new System.Windows.Forms.CheckBox();
        	this.labelResult = new System.Windows.Forms.Label();
        	this.buttonClose = new System.Windows.Forms.Button();
        	this.buttonMinimize = new System.Windows.Forms.Button();
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
        	this.button7 = new System.Windows.Forms.Button();
        	this.TextBoxTest = new System.Windows.Forms.TextBox();
        	this.button3 = new System.Windows.Forms.Button();
        	this.buttonSettings = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.OkWait)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkProg)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkSet)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.OkNfc)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokProg)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokSet)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.NokNfc)).BeginInit();
        	this.SuspendLayout();
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
        	// 
        	// textBox1
        	// 
        	this.textBox1.BackColor = System.Drawing.SystemColors.Window;
        	this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
        	this.textBox1.Location = new System.Drawing.Point(302, 65);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(276, 29);
        	this.textBox1.TabIndex = 0;
        	this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
        	// 
        	// ProgrammingPassCheckBox
        	// 
        	this.ProgrammingPassCheckBox.Location = new System.Drawing.Point(678, 65);
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
        	this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
        	// 
        	// timer1
        	// 
        	this.timer1.Interval = 1000;
        	this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
        	// 
        	// SetSerialCheckBox
        	// 
        	this.SetSerialCheckBox.Location = new System.Drawing.Point(678, 125);
        	this.SetSerialCheckBox.Name = "SetSerialCheckBox";
        	this.SetSerialCheckBox.Size = new System.Drawing.Size(173, 24);
        	this.SetSerialCheckBox.TabIndex = 44;
        	this.SetSerialCheckBox.Text = "SetSerialCheckBox";
        	this.SetSerialCheckBox.UseVisualStyleBackColor = true;
        	this.SetSerialCheckBox.Visible = false;
        	// 
        	// WriteNFCcheckBox
        	// 
        	this.WriteNFCcheckBox.Location = new System.Drawing.Point(678, 155);
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
        	// buttonClose
        	// 
        	this.buttonClose.BackColor = System.Drawing.SystemColors.HighlightText;
        	this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
        	this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonClose.ForeColor = System.Drawing.Color.SeaGreen;
        	this.buttonClose.Location = new System.Drawing.Point(907, 10);
        	this.buttonClose.Name = "buttonClose";
        	this.buttonClose.Size = new System.Drawing.Size(44, 23);
        	this.buttonClose.TabIndex = 47;
        	this.buttonClose.Text = "X";
        	this.buttonClose.UseVisualStyleBackColor = false;
        	this.buttonClose.Click += new System.EventHandler(this.buttonCloseClick);
        	// 
        	// buttonMinimize
        	// 
        	this.buttonMinimize.BackColor = System.Drawing.SystemColors.HighlightText;
        	this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
        	this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonMinimize.ForeColor = System.Drawing.Color.Sienna;
        	this.buttonMinimize.Location = new System.Drawing.Point(857, 10);
        	this.buttonMinimize.Name = "buttonMinimize";
        	this.buttonMinimize.Size = new System.Drawing.Size(44, 23);
        	this.buttonMinimize.TabIndex = 48;
        	this.buttonMinimize.Text = "–";
        	this.buttonMinimize.UseVisualStyleBackColor = false;
        	this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimizeClick);
        	// 
        	// ExecutingBox
        	// 
        	this.ExecutingBox.Location = new System.Drawing.Point(678, 95);
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
        	this.TopicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.TopicLabel.ForeColor = System.Drawing.Color.ForestGreen;
        	this.TopicLabel.Location = new System.Drawing.Point(227, 6);
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
        	this.WaitingLabel.Size = new System.Drawing.Size(170, 47);
        	this.WaitingLabel.TabIndex = 63;
        	this.WaitingLabel.Text = "Waiting for start:";
        	// 
        	// ProgramingLabel
        	// 
        	this.ProgramingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.ProgramingLabel.ForeColor = System.Drawing.Color.Green;
        	this.ProgramingLabel.Location = new System.Drawing.Point(29, 316);
        	this.ProgramingLabel.Name = "ProgramingLabel";
        	this.ProgramingLabel.Size = new System.Drawing.Size(170, 34);
        	this.ProgramingLabel.TabIndex = 64;
        	this.ProgramingLabel.Text = "Programming:";
        	// 
        	// SetSerialLabel
        	// 
        	this.SetSerialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.SetSerialLabel.ForeColor = System.Drawing.Color.Green;
        	this.SetSerialLabel.Location = new System.Drawing.Point(29, 364);
        	this.SetSerialLabel.Name = "SetSerialLabel";
        	this.SetSerialLabel.Size = new System.Drawing.Size(170, 37);
        	this.SetSerialLabel.TabIndex = 65;
        	this.SetSerialLabel.Text = "Set Serial Num:";
        	// 
        	// NfcInitLabel
        	// 
        	this.NfcInitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        	this.NfcInitLabel.ForeColor = System.Drawing.Color.Green;
        	this.NfcInitLabel.Location = new System.Drawing.Point(29, 413);
        	this.NfcInitLabel.Name = "NfcInitLabel";
        	this.NfcInitLabel.Size = new System.Drawing.Size(170, 37);
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
        	this.SerNumLabel.Size = new System.Drawing.Size(373, 52);
        	this.SerNumLabel.TabIndex = 67;
        	this.SerNumLabel.Text = "Serial Number: ";
        	// 
        	// button7
        	// 
        	this.button7.Location = new System.Drawing.Point(705, 261);
        	this.button7.Name = "button7";
        	this.button7.Size = new System.Drawing.Size(130, 69);
        	this.button7.TabIndex = 68;
        	this.button7.Text = "TestButton";
        	this.button7.UseVisualStyleBackColor = true;
        	this.button7.Click += new System.EventHandler(this.Button7Click);
        	// 
        	// TextBoxTest
        	// 
        	this.TextBoxTest.Location = new System.Drawing.Point(709, 353);
        	this.TextBoxTest.Name = "TextBoxTest";
        	this.TextBoxTest.Size = new System.Drawing.Size(126, 22);
        	this.TextBoxTest.TabIndex = 69;
        	this.TextBoxTest.Text = "USB";
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(705, 216);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(130, 23);
        	this.button3.TabIndex = 71;
        	this.button3.Text = "Test";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.Button3Click);
        	// 
        	// buttonSettings
        	// 
        	this.buttonSettings.BackColor = System.Drawing.SystemColors.HighlightText;
        	this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
        	this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        	this.buttonSettings.ForeColor = System.Drawing.Color.Sienna;
        	this.buttonSettings.Location = new System.Drawing.Point(807, 10);
        	this.buttonSettings.Name = "buttonSettings";
        	this.buttonSettings.Size = new System.Drawing.Size(44, 23);
        	this.buttonSettings.TabIndex = 72;
        	this.buttonSettings.Text = "⚙";
        	this.buttonSettings.UseVisualStyleBackColor = false;
        	this.buttonSettings.Click += new System.EventHandler(this.ButtonSettingsClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.LightCyan;
        	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        	this.ClientSize = new System.Drawing.Size(963, 650);
        	this.ControlBox = false;
        	this.Controls.Add(this.buttonSettings);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.TextBoxTest);
        	this.Controls.Add(this.button7);
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
        	this.Controls.Add(this.buttonMinimize);
        	this.Controls.Add(this.buttonClose);
        	this.Controls.Add(this.labelResult);
        	this.Controls.Add(this.WriteNFCcheckBox);
        	this.Controls.Add(this.SetSerialCheckBox);
        	this.Controls.Add(this.ProgrammingPassCheckBox);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.button2);
        	this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.ForeColor = System.Drawing.Color.Olive;
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.KeyPreview = true;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "HMI-VEL programming";
        	this.TopMost = true;
        	this.TransparencyKey = System.Drawing.Color.Azure;
        	this.Activated += new System.EventHandler(this.MainFormActivated);
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
        	this.Load += new System.EventHandler(this.MainFormLoad);
        	this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
        	this.DoubleClick += new System.EventHandler(this.MainFormDoubleClick);
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

        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.ComboBox combo3;
        private System.Windows.Forms.ComboBox combo4;
        private System.Windows.Forms.ComboBox combo5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ProgrammingPassCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox SetSerialCheckBox;
        private System.Windows.Forms.CheckBox WriteNFCcheckBox;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox TextBoxTest;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSettings;
    }
}


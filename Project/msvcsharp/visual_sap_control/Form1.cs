using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using WindowScrape;
using WindowScrape.Static;
using System.Drawing;

namespace visual_sap_control
{
	public partial class Form1 : Form
	{
		[STAThread]
		
		[DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", SetLastError = true)]
		static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
		[DllImport("User32.dll")]
		public static extern Int32 SetForegroundWindow(int hWnd);

		const uint SWP_NOSIZE = 0x0001;
		const uint SWP_NOZORDER = 0x0004;
		
		public static class GlobalVar
		{
			public static bool FormActiveFocusFlag { get; set; }
			public static bool ProgrammingPassCheckBox { get; set; }
			public static bool ProgrammingError { get; set; }
			public static bool SetSerialCheckBox { get; set; }
			public static bool WriteNFCcheckBox { get; set; }
			
			public static bool boardFailed { get; set; }
			
			
			public static bool boardPassed { get; set; }
			
			public const int waitBeforStarting = 4500;
			public const int setSerialTime = 1000;
			public const int writeInitTime = 14400;
			
			public static bool painted = false;
			
			public static UInt32 connection_type { get; set; }
			public static UInt32 handle { get; set; }
			
		}
		
		public Form1()
		{
			InitializeComponent();
			
			
			
			
		}
		protected void ReallyCenterToScreen()
		{
			Screen screen = Screen.FromControl(this);

			Rectangle workingArea = screen.WorkingArea;
			this.Location = new Point() {
				X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
				Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
			};
		}
		
		public static bool FileIsReady(string path)
		{
			try {
				using (var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read)) {
					return  true;
				}
			} catch (IOException) {
				Thread.Sleep(10);
				return false;
			}
			
		}
		
		public static void KillUtl070()
		{
			try {
				foreach (Process proc in Process.GetProcessesByName("utl070")) {
					proc.Kill();
				}
				
			} catch (Exception ex) {
				
				throw;
			}
			
		}
		/// <summary>
		/// connectionType = "USB" or connectionType ="COM"
		/// </summary>
		/// <param name="connectionType"></param>
		/// <param name="portname"></param>
		public void CycloneInit (String connectionType, int portNumber )
		{
			cyclone_control_api.enumerateAllPorts();
			string portname ="";
			if (connectionType.ToUpper().Equals("USB"))
			{
				GlobalVar.connection_type = cyclone_control_api.CyclonePortType_USB;
				portname = "USB"+portNumber.ToString();
			}
			if (connectionType.ToUpper().Equals("COM"))
			{
				GlobalVar.connection_type = cyclone_control_api.CyclonePortType_Serial;
				portname = "COM"+portNumber.ToString();
			}
			
			
			GlobalVar.handle = cyclone_control_api.connectToCyclone(portname);
			if (GlobalVar.handle == 0) {
				this.WindowState = FormWindowState.Minimized;
				MessageBox.Show("Error Opening Device");

			} 
		}
		
		public static void CycloneEraseAllImages ()
		{
			uint images = cyclone_control_api.countCycloneImages(GlobalVar.handle);
			
			for (uint i = 1; i < images+1; i++)
			{
				cyclone_control_api.eraseCycloneImage(GlobalVar.handle,i);
			}
		}
		
		public static void CycloneUpdateImage(string Path)
		{
			CycloneEraseAllImages();
			cyclone_control_api.addCycloneImage(GlobalVar.handle,1,true, Path);
		
		}
		
		public void CycloneExecuteProgramming()
		{
			CycloneInit(TextBoxTest.Text,1);
			cyclone_control_api.startImageExecution(GlobalVar.handle, 1);
			Application.DoEvents();
			bool cyclone1done = false;

			do
			{
					if (cyclone_control_api.checkCycloneExecutionStatus(GlobalVar.handle) == 0) 
					{
						if (cyclone_control_api.getNumberOfErrors(GlobalVar.handle) == 0)
						{
							GlobalVar.ProgrammingPassCheckBox = true;
							NokProg.Visible = false;
							GlobalVar.ProgrammingError = false;
						} else 
					    {
						  GlobalVar.ProgrammingError = true;
						}
						cyclone1done = true;
					}
			} 
			while (!(cyclone1done));
		}
		
		
		
		//Main procedure----------------------------------------------
		public void ExecuteProgram()
		{
			String pathToUtlDirectory = @"C:\UTL070";
			String serialNumber = textBox1.Text.ToUpper();
			textBox1.Text = "";
			string failMessage = "";
			GlobalVar.boardPassed = true;
			GlobalVar.ProgrammingPassCheckBox = false;
			GlobalVar.SetSerialCheckBox = false;
			GlobalVar.WriteNFCcheckBox = false;
			GlobalVar.ProgrammingError = false;
			GlobalVar.boardFailed = false;
			
			waitingBar.Value = 0;
			ProgrammingBar.Value = 0;
			setSerialBar.Value = 0;
			nfcInitBar.Value = 0;
			
			OkWait.Visible = false;
			OkSet.Visible = false;
			OkProg.Visible = false;
			OkNfc.Visible = false;
			
			NokProg.Visible = false;
			NokSet.Visible = false;
			NokNfc.Visible = false;
			
			labelResult.Text = "";

			
			string startTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
			startTime = startTime.Replace('.', '/');
			
			int index = serialNumber.IndexOf("NS");
			if (index != 6) {
					
				SerNumLabel.Text = "Serial Number: INCORRECT BARCODE";
			} else {
				SerNumLabel.Text = "Serial Number: " + serialNumber;
				Process.Start(pathToUtlDirectory + @"\utl070.exe");
				GlobalVar.FormActiveFocusFlag = true;
				this.BringToFront();
				waitingBar.Value = 0;
				backgroundWaiting.RunWorkerAsync(); // start progress bar for waiting
				Thread.Sleep(GlobalVar.waitBeforStarting);
				OkWait.Visible = true;
				
				
				backgroundProgramming.RunWorkerAsync();
				CycloneExecuteProgramming(); // execute programming board procedure
				
				DateTime now = new DateTime();
				now = DateTime.Now;
				int secNow = now.Hour * 3600 + now.Minute * 60 + now.Second;
				int secCurrent = secNow;
				
				while (!GlobalVar.ProgrammingPassCheckBox && secCurrent - secNow < 10) {
					CycloneExecuteProgramming();
					now = DateTime.Now;
					secCurrent = now.Hour * 3600 + now.Minute * 60 + now.Second;
				}
				
				if (GlobalVar.ProgrammingPassCheckBox) {
					OkProg.Visible = true;
				} else {

					failMessage = "Programming fail";
					GlobalVar.boardPassed = false;
					NokProg.Visible = true;
				}
				
				// start progress bar for wait serial
				
				
				//- clear all unnesesary files in UTL directory------------------
				//	this.WindowState = FormWindowState.Minimized;
				var allowedExtensions = new [] { ".cmd", ".res", ".ans" };
				var files = Directory
					.GetFiles(pathToUtlDirectory).Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
					.ToList();
				
				foreach (var f in files) {
					File.Delete(Path.GetFullPath(f));
				}
				//----------------------------------------------------------------
				
				//-Check if programming is passed and do NFC stuff--------------
				if (GlobalVar.ProgrammingPassCheckBox) {
					
					//---------------- create modified cmd files with correct serial number----
					string[] serialNum = File.ReadAllLines(pathToUtlDirectory + @"\commands\serial_number\utl070.cmd");
					serialNum[1] = serialNumber;
					File.WriteAllLines(pathToUtlDirectory + @"\commands\serial_number\utl070.cmd", serialNum);
					
					serialNum = File.ReadAllLines(pathToUtlDirectory + @"\commands\nfc_write_init\utl070.cmd");
					serialNum[5] = "HSN=" + serialNumber;
					File.WriteAllLines(pathToUtlDirectory + @"\commands\nfc_write_init\utl070.cmd", serialNum);
					//---------------------------------------------------------------------------
					
					for (int j = 0; j < 3; j++) {
						for (int i = 0; i < 3; i++) {
							
							if (j == 0 && i==0) {
								backgroundSetSerial.RunWorkerAsync();
							}
							
							backgroundSetSerial.WorkerSupportsCancellation = true;
							GlobalVar.SetSerialCheckBox = false;
							GlobalVar.WriteNFCcheckBox = false;
							nfcInitBar.Value = 0;
							NokSet.Visible = false;
							NokNfc.Visible = false;
							OkSet.Visible = false;
			
							this.TopMost = false;
							this.SendToBack();
							
							Thread.Sleep(1500);
							
							File.Copy(pathToUtlDirectory + @"\commands\serial_number\utl070.cmd", pathToUtlDirectory + @"\utl070.cmd");
							Thread.Sleep(50);
							int p = 1;
							while (!FileIsReady(pathToUtlDirectory + @"\utl070.ans") && p < 50) {
								Thread.Sleep(100);
								p++;
								
							}
							if (p >= 49) {
								KillUtl070();
								Thread.Sleep(500);
								Process.Start(pathToUtlDirectory + @"\utl070.exe");
								Thread.Sleep(2000);
								this.BringToFront();
								failMessage = "SetSerialNumber";
								GlobalVar.boardPassed = false;
								NokSet.Visible = true;
								continue;
							}
							string result = File.ReadAllText(pathToUtlDirectory + @"\utl070.ans");
							File.Delete(pathToUtlDirectory + @"\utl070.ans");
							if (result.ToUpper().Contains("PASS")) {
								GlobalVar.SetSerialCheckBox = true;
								GlobalVar.boardPassed = true;
								OkSet.Visible = true;
								NokSet.Visible = false;
								break;
								
							} else {
								failMessage = "SetSerialNumber";
								GlobalVar.boardPassed = false;
								KillUtl070();
								Thread.Sleep(500);
								Process.Start(pathToUtlDirectory + @"\utl070.exe");
								Thread.Sleep(2000);
								NokSet.Visible = true;
								this.BringToFront();
							
							}
							
						}
						
						
						if (!GlobalVar.SetSerialCheckBox) {
							failMessage = "SetSerialNumber";
							GlobalVar.boardPassed = false;
						}
						
						if (GlobalVar.SetSerialCheckBox) {
							if (FileIsReady(pathToUtlDirectory + @"\utl070.cmd")) {
								File.Delete(pathToUtlDirectory + @"\utl070.cmd");
								setSerialBar.Value = 50;
								OkSet.Visible = true;
							}
							
							if (j == 0) {
								backgroundWriteInit.RunWorkerAsync();
							}
							
							File.Copy(pathToUtlDirectory + @"\commands\nfc_write_init\utl070.cmd", pathToUtlDirectory + @"\utl070.cmd");
							int p = 1;
							while (!FileIsReady(pathToUtlDirectory + @"\utl070.ans") && p < 200) {
								Thread.Sleep(100);
								p++;
							}
							
							if (p >= 199) {
								KillUtl070();
								Thread.Sleep(500);
								Process.Start(pathToUtlDirectory + @"\utl070.exe");
								Thread.Sleep(1500);
								this.BringToFront();
								this.TopMost = true;
								failMessage = "WriteNfcInitialization";
								GlobalVar.boardPassed = false;
								NokNfc.Visible = true;
								nfcInitBar.Value = 0;
								Thread.Sleep(100);
								continue; // - repeat full cycle, if ans file is not present
							}
							
							string result = File.ReadAllText(pathToUtlDirectory + @"\utl070.ans");
							File.Delete(pathToUtlDirectory + @"\utl070.ans");
							if (result.ToUpper().Contains("PASS")) {
								GlobalVar.WriteNFCcheckBox = true;
								GlobalVar.boardPassed = true;
								OkNfc.Visible = true;
								break;
								
							} else {
								KillUtl070();
								Thread.Sleep(1000);
								Process.Start(pathToUtlDirectory + @"\utl070.exe");
								Thread.Sleep(1000);
								this.BringToFront();
								GlobalVar.boardPassed = false;
								failMessage = "WriteNfcInitialization";
		
								NokNfc.Visible = true;
								continue;
							}
							
						}
						
					}
				}// - end of NFC section cycle--------------------------------------------
				KillUtl070();
				GlobalVar.boardFailed = !GlobalVar.boardPassed;
				
				string endTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
				endTime = endTime.Replace('.', '/');
				string[] tarsLines = File.ReadAllLines("Tars_example.log");
				tarsLines[0] = "S" + serialNumber;
				tarsLines[3] = "N" + Environment.MachineName;
				
				tarsLines[8] = "[" + startTime;
				tarsLines[9] = "]" + endTime;
				
				
				if (GlobalVar.boardPassed) {
					labelResult.ForeColor = System.Drawing.Color.ForestGreen;
					labelResult.Text = "PASS";
				} else {
					tarsLines[7] = "TF";
					List <string> tarsList = tarsLines.ToList();
					tarsList.Add("");
					tarsList.Add("F" + failMessage);
					tarsLines = tarsList.ToArray();
					labelResult.ForeColor = System.Drawing.Color.Red;
					labelResult.Text = "FAIL";
				}
				
				string tarsFileName = Environment.MachineName + "_" + serialNumber + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".tar";
				tarsFileName = @"C:\Tars\" + tarsFileName;
				StreamWriter sw = new StreamWriter(tarsFileName, true);
				foreach (var s in tarsLines) {
					sw.WriteLine(s);
				}
				sw.Close();
				
				
			}
			GlobalVar.FormActiveFocusFlag = false;
			
		}
		//----------------------------finish of Executing section--------------------------------
		
		public void ReturnFocus()
		{
			while (true) {
				Thread.Sleep(1000);
				this.ActiveControl = textBox1;
			}
		}
		

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			cyclone_control_api.disconnectFromAllCyclones();
			
		}

		 
		
		void Form1Load(object sender, EventArgs e)
		{
			GlobalVar.FormActiveFocusFlag = false;
			this.Size = new Size(900, 750);
			this.timer1.Start();
			ReallyCenterToScreen();
			
			this.TopMost = true;
			button5.Left = this.Width - 46;
			button5.Top = 2;
			button6.Top = 2;
			button6.Left = this.Width - 46 - button6.Width;
			
			TopicLabel.Left = (this.ClientSize.Width - TopicLabel.Width) / 2;
			TopicLabel.Top = (this.ClientSize.Height) / 20;
			
			textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2 + 10;
			textBox1.Top = (this.ClientSize.Height) / 6;
			
			int offset = 50;
			
			WaitingLabel.Left = (this.ClientSize.Width - waitingBar.Width - WaitingLabel.Width - 180) / 2 + offset;
			ProgramingLabel.Left = (this.ClientSize.Width - waitingBar.Width - WaitingLabel.Width - 180) / 2 + offset;
			SetSerialLabel.Left = (this.ClientSize.Width - waitingBar.Width - WaitingLabel.Width - 180) / 2 + offset;
			NfcInitLabel.Left = (this.ClientSize.Width - waitingBar.Width - WaitingLabel.Width - 180) / 2 + offset;
			
			waitingBar.Left = (this.ClientSize.Width - waitingBar.Width) / 2 + offset;
			ProgrammingBar.Left = (this.ClientSize.Width - ProgrammingBar.Width) / 2 + offset;
			setSerialBar.Left = (this.ClientSize.Width - setSerialBar.Width) / 2 + offset;
			nfcInitBar.Left = (this.ClientSize.Width - nfcInitBar.Width) / 2 + offset;
			
			OkWait.Left = (this.ClientSize.Width + waitingBar.Width + 50 - OkWait.Width) / 2 + offset;
			OkSet.Left = (this.ClientSize.Width + waitingBar.Width + 50 - OkWait.Width) / 2 + offset;
			OkProg.Left = (this.ClientSize.Width + waitingBar.Width + 50 - OkWait.Width) / 2 + offset;
			OkNfc.Left = (this.ClientSize.Width + waitingBar.Width + 50 - OkWait.Width) / 2 + offset;
			NokProg.Left = (this.ClientSize.Width + waitingBar.Width + 50 - OkWait.Width) / 2 + offset;
			NokSet.Left = (this.ClientSize.Width + waitingBar.Width + 50 - OkWait.Width) / 2 + offset;
			NokNfc.Left = (this.ClientSize.Width + waitingBar.Width + 50 - OkWait.Width) / 2 + offset;
			
			SerNumLabel.Left = (this.ClientSize.Width - SerNumLabel.Width - 230) / 2;
			SerNumLabel.Top = ((this.ClientSize.Height) / 10) * 6 + 50;
			
			OkWait.Visible = false;
			OkSet.Visible = false;
			OkProg.Visible = false;
			OkNfc.Visible = false;
			
			NokProg.Visible = false;
			NokSet.Visible = false;
			NokNfc.Visible = false;
			
			labelResult.Left = (this.ClientSize.Width - labelResult.Width) / 2;
			labelResult.Top = ((this.ClientSize.Height) / 6) * 4 + 60;

		}
		
		

		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter) {
				e.Handled = true;
				backgroundWorker2.RunWorkerAsync(100);
			}
			
		}

		private int BackgroundProcessLogicMethod(BackgroundWorker bw, int a)
		{		
			return 0;
		}
		

		void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.timer1.Start();
			backgroundWorker1.RunWorkerAsync(100);
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			SetForegroundWindow(Handle.ToInt32());
			this.TopMost = true;
			this.BringToFront();
			
			this.ActiveControl = textBox1;
			this.timer1.Start();
			
		}
		void Button5Click(object sender, EventArgs e)
		{
			Close();
			
		}
		void Button6Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			GlobalVar.FormActiveFocusFlag = true;
			
			
		}
		void BackgroundWorker2DoWork(object sender, DoWorkEventArgs e)
		{
			ExecuteProgram();
		}
		
	
		void Form1Activated(object sender, EventArgs e)
		{
			GlobalVar.FormActiveFocusFlag = false;
			
		}
		void BackgroundProgrammingDoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 0; i < 51; i++) {
				Thread.Sleep(109);
				this.BringToFront();
				if (GlobalVar.ProgrammingError && (i==40))
				{
					i = i - 1; 
				}
				if (!GlobalVar.boardPassed) {
					backgroundProgramming.ReportProgress(0);
					NokProg.Visible = true;
					break;
				}
				if (GlobalVar.ProgrammingPassCheckBox) {
					backgroundProgramming.ReportProgress(50);
					break;
				}

				backgroundProgramming.ReportProgress(i);
			}
			
		}
		void BackgroundProgrammingProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			ProgrammingBar.Value = e.ProgressPercentage;
			
		}

		void Form1DoubleClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			ExecuteProgram();
			
		}
		void BackgroundWaitingDoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 0; i < 51; i++) {
				if (i == 30) {
					i = i + 5;
				}
				if (i == 40) {
					i = i + 5;
				}
				
				Thread.Sleep(GlobalVar.waitBeforStarting / 51);
				this.BringToFront();
				backgroundWaiting.ReportProgress(i);
				SetForegroundWindow(Handle.ToInt32());
			}
			
		}
		void BackgroundWaitingProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			waitingBar.Value = e.ProgressPercentage;
		}

		void BackgroundSetSerialDoWork(object sender, DoWorkEventArgs e)
		{
			if ((backgroundSetSerial.CancellationPending == true)) {
				e.Cancel = true;
			} else if (!backgroundSetSerial.CancellationPending) {
				for (int i = 0; i < 51; i++) {
					
					if (i == 30)
					{
						i = i + 8;
					}
				
					if (!GlobalVar.boardPassed) 
					{
						backgroundSetSerial.ReportProgress(0);
						NokSet.Visible = true;
						break;
					}
					
					this.BringToFront();
					Thread.Sleep(GlobalVar.setSerialTime / 51);
					backgroundSetSerial.ReportProgress(i);
					SetForegroundWindow(Handle.ToInt32());
				}
			}
			
		}
		void BackgroundSetSerialProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			setSerialBar.Value = e.ProgressPercentage;
			
		}
		void BackgroundWriteInitDoWork(object sender, DoWorkEventArgs e)
		{
			if ((backgroundWriteInit.CancellationPending == true)) {
				e.Cancel = true;
			} else if (!backgroundWriteInit.CancellationPending) {
				
				for (int i = 0; i < 51; i++) {
					this.BringToFront();
					Thread.Sleep(GlobalVar.writeInitTime / 51);
					backgroundWriteInit.ReportProgress(i);
					SetForegroundWindow(Handle.ToInt32());
					
					if (GlobalVar.boardFailed) {
						backgroundWriteInit.ReportProgress(0);
						NokNfc.Visible = true;
						break;
					}
						
				}
			}
		}
		void BackgroundWriteInitProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			nfcInitBar.Value = e.ProgressPercentage;	
		}

	
		void Form1Paint(object sender, PaintEventArgs e)
		{
			Graphics gs = this.CreateGraphics();
            Brush br1 = new SolidBrush(Color.SteelBlue );
            Brush br2 = new SolidBrush(Color.CadetBlue);
            Pen p1 = new Pen(br1);
            p1.Width =3;

             e.Graphics.Clear(Color.LightCyan);
        
           gs.DrawLine(p1, new Point(0, 0), new Point(0, this.Height));
           gs.DrawLine(p1, new Point(0, 0), new Point(this.Width,0 ));
           gs.DrawLine(p1, new Point(this.Width-1, 0), new Point(this.Width-1,this.Height ));
           gs.DrawLine(p1, new Point(0, this.Height-1), new Point(this.Width,this.Height-1 ));
           GlobalVar.painted =true;
		}
		
		
		void Button7Click(object sender, EventArgs e)
		{
			
			CycloneInit(TextBoxTest.Text,1);
		}
		
		
		void Button3Click(object sender, EventArgs e)
		{ 
			this.WindowState = FormWindowState.Minimized;
			//cyclone_control_api.startImageExecution(GlobalVar.handle, 1);
			CycloneExecuteProgramming();
			
//			uint images = cyclone_control_api.countCycloneImages(GlobalVar.handle);
//			
//			for (uint i = 1; i < images+1; i++)
//			{
//				cyclone_control_api.eraseCycloneImage(GlobalVar.handle,i);
//			}
			
			//CycloneErasaAllImages();
			
			
//			
			//cyclone_control_api.startImageExecution(GlobalVar.handle, 1);
			//CycloneErasaAllImages();
			//cyclone_control_api.addCycloneImage(GlobalVar.handle,1,true, @"C:\Temp\HMI_VEL_KE02_ATG_08_06_02_CRC_0xC1E5.sap");
			
			//CycloneUpdateImage(@"C:\Temp\HMI_VEL_KE02_ATG_08_03_03_CRC_0xC1E5.sap");
		
		}
		
		
	}
}
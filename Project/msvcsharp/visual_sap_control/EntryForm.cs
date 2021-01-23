
using System;
using System.Drawing;
using System.Windows.Forms;
using visual_sap_control;

namespace msvcsharp.visual_sap_control
{
	/// <summary>
	/// Description of EntryForm.
	/// </summary>
	public partial class EntryForm : Form
	{
		public EntryForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void EntryFormLoad(object sender, EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			
			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
	
		}
	}
}

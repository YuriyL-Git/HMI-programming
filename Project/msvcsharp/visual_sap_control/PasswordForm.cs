
using System;
using System.Drawing;
using System.Windows.Forms;

namespace msvcsharp.visual_sap_control
{
	/// <summary>
	/// Description of PasswordForm.
	/// </summary>
	public partial class PasswordForm : Form
	{
		public PasswordForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (passwordTextBox.Text == "Jabil12345") {
				
				this.DialogResult = DialogResult.OK;
			} else {
				// The password is invalid.
				passwordTextBox.Clear();
				MessageBox.Show("Inivalid password.");
				passwordTextBox.Focus();
			}
	
		}
		private void PasswordTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
				buttonOk.PerformClick();
            }
        }
		void PasswordFormLoad(object sender, EventArgs e)
		{
			passwordTextBox.PasswordChar = '*';
			passwordTextBox.Focus();
		}
	}
}

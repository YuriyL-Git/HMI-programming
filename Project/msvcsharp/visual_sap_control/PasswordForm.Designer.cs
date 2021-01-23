
namespace msvcsharp.visual_sap_control
{
	partial class PasswordForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TextBox passwordTextBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonOk = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(115, 118);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 32);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "button1";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.Button1Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(90, 29);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(156, 22);
			this.passwordTextBox.TabIndex = 1;
			this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBoxKeyDown);
			// 
			// PasswordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 253);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.buttonOk);
			this.Name = "PasswordForm";
			this.Text = "PasswordForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}


namespace msvcsharp.visual_sap_control
{
	partial class SettingsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button addProductButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button opentFirmwareButton;
		private System.Windows.Forms.Button openNfcButton;
		private System.Windows.Forms.TextBox nfcFileTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox firmwareFileTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox barcodeMaskTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox barcodeExampleTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox productNameTextBox;
		private System.Windows.Forms.Button editProductButton;
		private System.Windows.Forms.Button deleteProcuctButton;
		private System.Windows.Forms.Label fontLabel;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.addProductButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.opentFirmwareButton = new System.Windows.Forms.Button();
			this.openNfcButton = new System.Windows.Forms.Button();
			this.nfcFileTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.firmwareFileTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.barcodeMaskTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.barcodeExampleTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.productNameTextBox = new System.Windows.Forms.TextBox();
			this.editProductButton = new System.Windows.Forms.Button();
			this.deleteProcuctButton = new System.Windows.Forms.Button();
			this.fontLabel = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(16, 15);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(1248, 150);
			this.dataGridView.TabIndex = 0;
			// 
			// addProductButton
			// 
			this.addProductButton.Location = new System.Drawing.Point(16, 403);
			this.addProductButton.Name = "addProductButton";
			this.addProductButton.Size = new System.Drawing.Size(143, 35);
			this.addProductButton.TabIndex = 1;
			this.addProductButton.Text = "Add new product";
			this.addProductButton.UseVisualStyleBackColor = true;
			this.addProductButton.Click += new System.EventHandler(this.AddProductButtonClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Product Name";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.opentFirmwareButton);
			this.groupBox1.Controls.Add(this.openNfcButton);
			this.groupBox1.Controls.Add(this.nfcFileTextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.firmwareFileTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.barcodeMaskTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.barcodeExampleTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.productNameTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 181);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 216);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// opentFirmwareButton
			// 
			this.opentFirmwareButton.Location = new System.Drawing.Point(527, 126);
			this.opentFirmwareButton.Name = "opentFirmwareButton";
			this.opentFirmwareButton.Size = new System.Drawing.Size(130, 33);
			this.opentFirmwareButton.TabIndex = 14;
			this.opentFirmwareButton.Text = "Open Firmware";
			this.opentFirmwareButton.UseVisualStyleBackColor = true;
			this.opentFirmwareButton.Click += new System.EventHandler(this.OpentFirmwareButtonClick);
			// 
			// openNfcButton
			// 
			this.openNfcButton.Location = new System.Drawing.Point(527, 165);
			this.openNfcButton.Name = "openNfcButton";
			this.openNfcButton.Size = new System.Drawing.Size(130, 33);
			this.openNfcButton.TabIndex = 13;
			this.openNfcButton.Text = "Open Nfc";
			this.openNfcButton.UseVisualStyleBackColor = true;
			this.openNfcButton.Click += new System.EventHandler(this.OpenNfcButtonClick);
			// 
			// nfcFileTextBox
			// 
			this.nfcFileTextBox.Location = new System.Drawing.Point(135, 172);
			this.nfcFileTextBox.Name = "nfcFileTextBox";
			this.nfcFileTextBox.Size = new System.Drawing.Size(368, 22);
			this.nfcFileTextBox.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(11, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Nfc File";
			// 
			// firmwareFileTextBox
			// 
			this.firmwareFileTextBox.Location = new System.Drawing.Point(135, 133);
			this.firmwareFileTextBox.Name = "firmwareFileTextBox";
			this.firmwareFileTextBox.Size = new System.Drawing.Size(368, 22);
			this.firmwareFileTextBox.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(11, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Firmware File";
			// 
			// barcodeMaskTextBox
			// 
			this.barcodeMaskTextBox.Location = new System.Drawing.Point(135, 93);
			this.barcodeMaskTextBox.Name = "barcodeMaskTextBox";
			this.barcodeMaskTextBox.Size = new System.Drawing.Size(368, 22);
			this.barcodeMaskTextBox.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(11, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Barcode Mask";
			// 
			// barcodeExampleTextBox
			// 
			this.barcodeExampleTextBox.Location = new System.Drawing.Point(135, 55);
			this.barcodeExampleTextBox.Name = "barcodeExampleTextBox";
			this.barcodeExampleTextBox.Size = new System.Drawing.Size(368, 22);
			this.barcodeExampleTextBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Barcode Example";
			// 
			// productNameTextBox
			// 
			this.productNameTextBox.Location = new System.Drawing.Point(135, 15);
			this.productNameTextBox.Name = "productNameTextBox";
			this.productNameTextBox.Size = new System.Drawing.Size(368, 22);
			this.productNameTextBox.TabIndex = 3;
			// 
			// editProductButton
			// 
			this.editProductButton.Location = new System.Drawing.Point(197, 403);
			this.editProductButton.Name = "editProductButton";
			this.editProductButton.Size = new System.Drawing.Size(143, 35);
			this.editProductButton.TabIndex = 4;
			this.editProductButton.Text = "Edit product";
			this.editProductButton.UseVisualStyleBackColor = true;
			// 
			// deleteProcuctButton
			// 
			this.deleteProcuctButton.Location = new System.Drawing.Point(376, 403);
			this.deleteProcuctButton.Name = "deleteProcuctButton";
			this.deleteProcuctButton.Size = new System.Drawing.Size(143, 35);
			this.deleteProcuctButton.TabIndex = 5;
			this.deleteProcuctButton.Text = "Delete product";
			this.deleteProcuctButton.UseVisualStyleBackColor = true;
			this.deleteProcuctButton.Click += new System.EventHandler(this.DeleteProcuctButtonClick);
			// 
			// fontLabel
			// 
			this.fontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fontLabel.Location = new System.Drawing.Point(700, 195);
			this.fontLabel.Name = "fontLabel";
			this.fontLabel.Size = new System.Drawing.Size(100, 23);
			this.fontLabel.TabIndex = 6;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			this.openFileDialog.ShowHelp = true;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1277, 473);
			this.Controls.Add(this.fontLabel);
			this.Controls.Add(this.deleteProcuctButton);
			this.Controls.Add(this.editProductButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.addProductButton);
			this.Controls.Add(this.dataGridView);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.Text = "SettingsForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsFormFormClosed);
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			this.SizeChanged += new System.EventHandler(this.SettingsFormSizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}

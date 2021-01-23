
using System;
using System.Drawing;
using System.Windows.Forms;
using visual_sap_control;
using System.Collections.Generic;
using System.ComponentModel;

namespace msvcsharp.visual_sap_control
{
	/// <summary>
	/// Description of SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		//public static BindingList<>
		public static BindingList<ProductProperties> productsDataList = new BindingList<ProductProperties>();
		public void AddProductToGrid(ProductProperties product)
		{
			dataGridView.Rows.Add(product.ProductName, product.BarcodeExample, product.BarcodeMask, product.FirmwareFile, product.NfcFile);
		}
		
		public void UpdateGrid()
		{
			dataGridView.Font = fontLabel.Font;
			dataGridView.Width = this.Width - 50;
		
			dataGridView.DataSource = productsDataList;
			
			dataGridView.Columns[0].HeaderText = "Product Name"; 
			dataGridView.Columns[1].HeaderText = "Barcode Example";
			dataGridView.Columns[2].HeaderText = "Barcode Mask";
			dataGridView.Columns[3].HeaderText = "Firmware File";
			dataGridView.Columns[4].HeaderText = "Nfc File";
			dataGridView.ReadOnly = true;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.Refresh();
			ResizeGrid();
		}
		
		public void ResizeGrid()
		{
			for (int i = 0; i < dataGridView.Columns.Count; i++) {
				dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}
		
		public void SettingsFormLoad(object sender, EventArgs e)
		{
			UpdateGrid();
		}
		void SettingsFormFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm form = new MainForm();
			
			form.Show();
			
		}
		void AddProductButtonClick(object sender, EventArgs e)
		{
			ProductProperties product = new ProductProperties();
			product.ProductName = productNameTextBox.Text;
			product.BarcodeExample = barcodeExampleTextBox.Text;
			product.BarcodeMask = barcodeMaskTextBox.Text;
			product.FirmwareFile = firmwareFileTextBox.Text;
			product.NfcFile = nfcFileTextBox.Text;
			productsDataList.Add(product);
			UpdateGrid();
			
		}
		void SettingsFormSizeChanged(object sender, EventArgs e)
		{
			this.Height = 420;
			if (this.Width < 900)
				this.Width = 900;
			dataGridView.Width = this.Width - 50;
			ResizeGrid();
			
			
		}
		
		void OpentFirmwareButtonClick(object sender, EventArgs e)
		{
			openFileDialog.Filter = "All files(*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				firmwareFileTextBox.Text = openFileDialog.FileName;
			}
		}
		void OpenNfcButtonClick(object sender, EventArgs e)
		{
			openFileDialog.Filter = "All files(*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				nfcFileTextBox.Text = openFileDialog.FileName;
			}
		}
		void DeleteProcuctButtonClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to delete selected product?", "Deletion Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
			{
				//MessageBox.Show(dataGridView.CurrentCell.RowIndex.ToString());
				productsDataList.RemoveAt(dataGridView.CurrentCell.RowIndex);
				UpdateGrid();
			}
		}
	}
}

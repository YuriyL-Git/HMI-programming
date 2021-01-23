
using System;
using System.Drawing;
using System.Windows.Forms;
using visual_sap_control;
using System.Collections.Generic;

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
		
		public static List<ProductProperties> productsDataList = new List<ProductProperties>();
		
		public void AddProductToGrid(ProductProperties product)
		{
			dataGridView.Rows.Add(product.ProductName, product.BarcodeExample, product.BarcodeMask, product.FirmwareFile, product.NfcFile);
		}
		
		public void InitializeGrid()
		{
			dataGridView.Font = fontLabel.Font;
			dataGridView.Width = this.Width - 50;
			
//			var column1 = new DataGridViewColumn();
//			column1.HeaderText = "Product Name"; //текст в шапке
//			column1.Name = "ProductName"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
//			column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
//
//			var column2 = new DataGridViewColumn();
//			column2.HeaderText = "Barcode Example";
//			column2.Name = "BarcodeExample";
//			column2.CellTemplate = new DataGridViewTextBoxCell();
//
//			var column3 = new DataGridViewColumn();
//			column3.HeaderText = "Barcode Mask";
//			column3.Name = "BarcodeMask";
//			column3.CellTemplate = new DataGridViewTextBoxCell();
//			
//			var column4 = new DataGridViewColumn();
//			column4.HeaderText = "Firmware File";
//			column4.Name = "FirmwareFile";
//			column4.CellTemplate = new DataGridViewTextBoxCell();
//			
//			var column5 = new DataGridViewColumn();
//			column5.HeaderText = "Nfc File";
//			column5.Name = "NfcFile";
//			column5.CellTemplate = new DataGridViewTextBoxCell();
//			dataGridView.Columns.Clear();
//
//			dataGridView.Columns.Add(column1);
//			dataGridView.Columns.Add(column2);
//			dataGridView.Columns.Add(column3);
//			dataGridView.Columns.Add(column4);
//			dataGridView.Columns.Add(column5);
			 
//				dataGridView1.Columns[1].Name = "Name";  
//				dataGridView1.Columns[2].Name = "City"; 
			dataGridView.DataSource = null;
			dataGridView.DataSource = productsDataList;
			dataGridView.Refresh();
			dataGridView.Columns[0].HeaderText = "Product Name"; 
			dataGridView.Columns[1].HeaderText = "Barcode Example";
			dataGridView.Columns[2].HeaderText = "Barcode Mask";
			dataGridView.Columns[3].HeaderText = "Firmware File";
			dataGridView.Columns[4].HeaderText = "Nfc File";
			dataGridView.ReadOnly = true;
			dataGridView.AllowUserToAddRows = false;
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
			InitializeGrid();
			ResizeGrid();
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
			InitializeGrid();
			
			
			//AddProductToGrid(product);
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
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				nfcFileTextBox.Text = openFileDialog.FileName;
			}
		}
		void DeleteProcuctButtonClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to delete selected product?", "Deletion Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				//MessageBox.Show("ok");
				
				while (dataGridView.SelectedRows.Count > 0)
					dataGridView.Rows.RemoveAt(dataGridView.SelectedRows[0].Index);
						
			}
		}
	}
}

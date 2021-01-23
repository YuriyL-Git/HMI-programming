
using System;
using System.Drawing;
using System.Windows.Forms;
using visual_sap_control;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;

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
		
		public void SaveProperties()
		{
			List<string> listToSave = new List<string>();
			foreach (ProductProperties prod in productsDataList)
			{
				const string sep = "||";
				string line = prod.ProductName + sep + prod.BarcodeExample + sep + prod.BarcodeMask + sep + prod.FirmwareFile + sep + prod.NfcFile;
				listToSave.Add(line);
			}
			File.WriteAllLines("settings.ini", listToSave);
		}
		
		public void ResizeGrid()
		{
			for (int i = 0; i < dataGridView.Columns.Count; i++) {
				dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
		}
		
		public ProductProperties GetProduct()
		{
			ProductProperties product = new ProductProperties();
			product.ProductName = productNameTextBox.Text;
			product.BarcodeExample = barcodeExampleTextBox.Text;
			product.BarcodeMask = barcodeMaskTextBox.Text;
			product.FirmwareFile = firmwareFileTextBox.Text;
			product.NfcFile = nfcFileTextBox.Text;
			return product;
		}
		
		public void ClearTextBoxes()
		{
			productNameTextBox.Text = "";
			barcodeExampleTextBox.Text = "";
			barcodeMaskTextBox.Text = "";
			firmwareFileTextBox.Text = "";
			nfcFileTextBox.Text = "";
		}
		public void SettingsFormLoad(object sender, EventArgs e)
		{
			UpdateGrid();
		}
		
		void SettingsFormFormClosed(object sender, FormClosedEventArgs e)
		{
			SaveProperties();
			MainForm form = new MainForm();
			form.Show();	
		}
		void AddProductButtonClick(object sender, EventArgs e)
		{
			productsDataList.Add(GetProduct());
			ClearTextBoxes();
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
			if (MessageBox.Show("Delete selected product?", "Deletion Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
			{
				productsDataList.RemoveAt(dataGridView.CurrentCell.RowIndex);
				ClearTextBoxes();
				UpdateGrid();
			}
		}
		void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
		{
			ProductProperties product = productsDataList.ElementAt(dataGridView.CurrentCell.RowIndex);
			productNameTextBox.Text = product.ProductName;
			barcodeExampleTextBox.Text = product.BarcodeExample;
			barcodeMaskTextBox.Text = product.BarcodeMask;
			firmwareFileTextBox.Text = product.FirmwareFile;
			nfcFileTextBox.Text = product.NfcFile;
		}
		void EditProductButtonClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Edit selected product?", "Edition Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
			{
				productsDataList[dataGridView.CurrentCell.RowIndex] = GetProduct();
				UpdateGrid();
			}
		}
	}
}

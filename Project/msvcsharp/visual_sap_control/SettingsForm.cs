
using System;
using System.Drawing;
using System.Windows.Forms;
using visual_sap_control;

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
		void SettingsFormLoad(object sender, EventArgs e)
		{
			dataGridView.Font = fontLabel.Font;
			
			var column1 = new DataGridViewColumn();
			column1.HeaderText = "Product"; //текст в шапке
			column1.Name = "ProductName"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
			column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

			var column2 = new DataGridViewColumn();
			column2.HeaderText = "BarcodeExample"; 
			column2.Name = "BarcodeExample";
			column2.CellTemplate = new DataGridViewTextBoxCell();

			var column3 = new DataGridViewColumn();
			column3.HeaderText = "BarcodeMask";
			column3.Name = "BarcodeMask";
			column3.CellTemplate = new DataGridViewTextBoxCell();
            
			var column4 = new DataGridViewColumn();
			column4.HeaderText = "FirmwareFile";
			column4.Name = "FirmwareFile";
			column4.CellTemplate = new DataGridViewTextBoxCell();
            
			var column5 = new DataGridViewColumn();
			column5.HeaderText = "NfcFile";
			column5.Name = "NfcFile";
			column5.CellTemplate = new DataGridViewTextBoxCell();

			dataGridView.Columns.Add(column1);
			dataGridView.Columns.Add(column2);
			dataGridView.Columns.Add(column3);
			dataGridView.Columns.Add(column4);
			dataGridView.Columns.Add(column5);
			
			dataGridView.Rows.Add();
			dataGridView.ReadOnly = true;

			dataGridView.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
			for (int i = 0; i < dataGridView.Columns.Count - 1; i++) {
				dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}
			dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			for (int i = 0; i < dataGridView.Columns.Count; i++) {
				int colw = dataGridView.Columns[i].Width;
				dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				dataGridView.Columns[i].Width = colw;
			}
			
			
		    //	dataGridView.AutoResizeColumns();            
			//dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			//dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			//dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
	
		}
		void SettingsFormFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm form = new MainForm();
			form.Show();
	
		}
	}
}

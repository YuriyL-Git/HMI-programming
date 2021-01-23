
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
			var column1 = new DataGridViewColumn();
            column1.HeaderText = "ProductName"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "ProductName"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
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

            dataGridView.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
	
		}
		void SettingsFormFormClosed(object sender, FormClosedEventArgs e)
		{
			MainForm form = new MainForm();
			form.Show();
	
		}
	}
}

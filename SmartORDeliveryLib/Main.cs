using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace SmartORDeliveryLib
{
    public partial class Main : Form
    {
        string m_ConnectionString = @SmartORDeliveryLib.Properties.Settings.Default.ConnectionStringSetting.ToString();

        string m_MainFolder = @SmartORDeliveryLib.Properties.Settings.Default.MainFolderSetting.ToString();

        public Main()
        {
            InitializeComponent();
        }

        private List<string> GetFileNames()
        {
            List<string> _resultList = new List<string>();
            string _mainFolder = this.m_MainFolder;
            string _filterWildcard = "*.xls";

            _resultList.Add("Select Cycle Filename");

            string[] files = Directory.GetFiles(_mainFolder, _filterWildcard);
            for (int i = 0; i < files.Length; i++)
            {
                _resultList.Add(Path.GetFileName(files[i]));
            }

            return _resultList;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.filesComboBox.DataSource = this.GetFileNames();
            this.filesComboBox.Focus();
        }


        private void showContentButton_Click(object sender, EventArgs e)
        {
            if (this.filesComboBox.SelectedValue.ToString() != "Select Cycle Filename")
            {
                this.GetContentByCycle(this.filesComboBox.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Please Select Cycle Filename", "Select Cycle Filename", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.filesComboBox.Focus();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.filesComboBox.SelectedValue.ToString() != "Select Cycle Filename")
            {
                this.GetContentByAccountNoAndCycleFile(this.accountNoTextBox.Text, this.filesComboBox.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Please Select Cycle Filename", "Select Cycle Filename", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.filesComboBox.Focus();
            }

        }


        private void GetContentByCycle(string _pCycleFilename)
        {
            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);

            string _firstSheet;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                _firstSheet = dtSchema.Rows[0].Field<string>("TABLE_NAME");
            }

            var adapter = new OleDbDataAdapter(@"SELECT * FROM [" + _firstSheet + "]", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];
            this.contentDataGridView.DataSource = _data;

            if (_data.Rows.Count <= 0)
            {
                MessageBox.Show("No content for Cycle Filename " + _pCycleFilename, "Content Not Found.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void GetContentByAccountNoAndCycleFile(string _pAccountNo, string _pCycleFilename)
        {
            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);

            string _firstSheet;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                _firstSheet = dtSchema.Rows[0].Field<string>("TABLE_NAME");
            }

            var adapter = new OleDbDataAdapter(@"SELECT * FROM [" + _firstSheet + "] where [Account #] =" + _pAccountNo + "", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];
            this.contentDataGridView.DataSource = _data;

            if (_data.Rows.Count <= 0)
            {
                MessageBox.Show("No match found for Account No. " + _pAccountNo + " on Cycle " + _pCycleFilename + ".", "Account No. Not Found.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void GetContentDispatchDate(DateTime _pDispatchDate, string _pCycleFilename)
        {
            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);

            string _firstSheet;
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                DataTable dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                _firstSheet = dtSchema.Rows[0].Field<string>("TABLE_NAME");
            }

            var adapter = new OleDbDataAdapter(@"SELECT * FROM [" + _firstSheet + "] where [DispatchDate] ='" + _pDispatchDate.ToShortDateString() + "'", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];
            this.contentDataGridView.DataSource = _data;

            if (_data.Rows.Count <= 0)
            {
                MessageBox.Show("No match found for Dispatch Date " + _pDispatchDate + " on Cycle " + _pCycleFilename + ".", "Account No. Not Found.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void accountNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (this.filesComboBox.SelectedValue.ToString() != "Select Cycle Filename")
                {
                    this.GetContentByAccountNoAndCycleFile(this.accountNoTextBox.Text, this.filesComboBox.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Please Select Cycle Filename", "Select Cycle Filename", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.filesComboBox.Focus();
                }

            }
        }

        private void searchDateDispatchButton_Click(object sender, EventArgs e)
        {

            if (this.filesComboBox.SelectedValue.ToString() != "Select Cycle Filename")
            {
                this.GetContentDispatchDate(this.dateDispatchedTimePicker.Value, this.filesComboBox.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Please Select Cycle Filename", "Select Cycle Filename", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.filesComboBox.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DispatchForm _DispatchForm = new DispatchForm();

            _DispatchForm.StartPosition = FormStartPosition.CenterScreen;

            _DispatchForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm _DeliveryDetailsForm = new MainForm();

            _DeliveryDetailsForm.StartPosition = FormStartPosition.CenterScreen;

            _DeliveryDetailsForm.ShowDialog();

        }


    }
}

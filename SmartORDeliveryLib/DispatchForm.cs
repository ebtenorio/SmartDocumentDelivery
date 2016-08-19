using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SmartORDeliveryLib
{
    public partial class DispatchForm : Form
    {

        string m_MainFolder = @SmartORDeliveryLib.Properties.Settings.Default.MainFolderSetting.ToString();


        public DispatchForm()
        {
            InitializeComponent();
        }

        private void messenger_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void accountNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (!(this.accountNoTextBox.Text.Trim() == "") && !(this.messenger.Text.Trim() == ""))
                {
                    this.accountNoListBox.Items.Add(this.accountNoTextBox.Text);
                    this.accountNoTextBox.Text = "";
                    this.accountNoTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Please supply both details: Messenger and Delivery No.", "Supply details", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

            }

        }


        public void UpdateDetails(string _pMessenger, string _pAccountNo, string _pCycleFilename, ref bool _hasRec)
        {
            _hasRec = false;

            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);
            var adapter = new OleDbDataAdapter(String.Format(@"UPDATE [BatchDetails$] Set [Messenger]='{0}', [DispatchDate]='{1}', [Delivery Status]='Dispatched' where [Account No]='{2}'", _pMessenger, DateTime.Now.ToShortDateString (), Convert.ToChar(160) + _pAccountNo), connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];

            if (this.isFoundRecord(_pAccountNo, _pCycleFilename)) _hasRec = true;
            else _hasRec = false;
        }

        public bool isFoundRecord(string _pAccountNo, string _pCycleFilename)
        {
            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);
            var adapter = new OleDbDataAdapter(String.Format(@"SELECT * FROM [BatchDetails$] where [Account No]='{0}'", Convert.ToChar(160) + _pAccountNo), connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];

            if (_data.Rows.Count > 0) return true;
            else return false;


        }


        private void DispatchForm_Load(object sender, EventArgs e)
        {
            this.filesComboBox.DataSource = this.GetFileNames();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
         
            if (this.filesComboBox.SelectedValue.ToString() != "Select Cycle Filename")
            {

                int _countSaved = 0;

                bool _hasRec = false;

                string _accountsNotFound = "";

                for (int i = 0; i < this.accountNoListBox.Items.Count; i++)
                {
                    this.UpdateDetails(this.messenger.Text, this.accountNoListBox.Items[i].ToString(), this.filesComboBox.SelectedValue.ToString(), ref _hasRec);
                    if (_hasRec) _countSaved++;
                    else _accountsNotFound = _accountsNotFound + this.accountNoListBox.Items[i].ToString() + Environment.NewLine; 
                }

                if (_countSaved > 0)
                {
                    MessageBox.Show(_countSaved.ToString() + " delivery documents updated with Messenger : " + this.messenger.Text, "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (_accountsNotFound.Trim() != "")
                {
                    MessageBox.Show("Account Numbers NOT FOUND" + Environment.NewLine + _accountsNotFound, "Not found: Account numbers.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.accountNoListBox.Items.Clear();
                this.messenger.Clear();
                this.messenger.Focus();
            }
            else
            {
                MessageBox.Show("Choose a cycle filename.", "Cycle filename", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

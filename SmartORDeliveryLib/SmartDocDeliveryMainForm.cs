using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartDocDeliveryLibrary;
using System.Configuration;
using SmartDocDeliveryLibrary.DTOs;
using System.Data.OleDb;
using System.IO;

namespace SmartORDeliveryLib
{
    public partial class SmartDocDeliveryMainForm : Form
    {
        string m_ConnectionString = @SmartORDeliveryLib.Properties.Settings.Default.ConnectionStringSetting.ToString();

        string m_MainFolder = @SmartORDeliveryLib.Properties.Settings.Default.MainFolderSetting.ToString();

        SmartDocDeliveryLib _SmartDocDeliveryService;

        public SmartDocDeliveryMainForm()
        {
            _SmartDocDeliveryService = new SmartDocDeliveryLib(this.m_ConnectionString);

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.deliveryStatusComboBox.Text.ToUpper () != "SELECT DELIVERY STATUS")
            {
                this.UpdateDetails(this.filesComboBox.SelectedValue.ToString(), this.accountNotextBox.Text, this.deliveryStatusComboBox.Text, this.receivedByTextBox.Text, this.relationshipTextBox.Text, this.messengerTextBox.Text, this.remarksTextBox.Text, this.RTSComboBox.Text);

                MessageBox.Show("Deliver details for Account No. " + this.accountNotextBox.Text + " updated successfully", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.deliveryStatusComboBox.SelectedIndex = 0;

                this.accountNotextBox.Focus();
            }
            else
            {
                MessageBox.Show("Select Delivery Status.", "Delivery Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.deliveryStatusComboBox.Focus();
            }
             
        }

        private void SmartDocDeliveryMainForm_Load(object sender, EventArgs e)
        {
            this.filesComboBox.DataSource = this.GetFileNames();
            this.filesComboBox.Focus();

        }

        public void GetDetailsFromExcel(string _pCycleFilename, string _pAccountNo, ref bool _pHasRecord)
        {
            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);          
            var adapter = new OleDbDataAdapter(@"SELECT * FROM [BatchDetails$] where [Account No] ='" + Convert.ToChar(160) + _pAccountNo + "'", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];

            if (_data.Rows.Count > 0)
            {
                _pHasRecord = true;
                this.deliveryNoTextBox.Text = _data.Rows[0]["Delivery No"].ToString();
                this.sequenceNoTextBox.Text = _data.Rows[0]["Sequence No"].ToString();
                //this.accountNotextBox.Text = _data.Rows[0]["Account No"].ToString();
                this.fileNameTextBox.Text = _data.Rows[0]["FileName"].ToString();
                this.subscribersNameTextBox.Text = _data.Rows[0]["Subscriber Name"].ToString();
                this.addressTextBox.Text = _data.Rows[0]["Address"].ToString();
                this.MINSRNTextBox.Text = _data.Rows[0]["MIN/SRN"].ToString();
                this.brandTextBox.Text = _data.Rows[0]["Brand"].ToString();
                this.zipCodeTextBox.Text = _data.Rows[0]["ZipCode"].ToString();
                this.remarksTextBox.Text = _data.Rows[0]["Remarks"].ToString();
                //this.deliveryStatusTextBox.Text = _data.Rows[0]["Delivery Status"].ToString();
                this.deliveryStatusComboBox.Text = _data.Rows[0]["Delivery Status"].ToString();
                this.receivedByTextBox.Text = _data.Rows[0]["Received By"].ToString();
                this.relationshipTextBox.Text = _data.Rows[0]["Relationship"].ToString();
                this.RTSNewAddressTextBox.Text = _data.Rows[0]["RTS New Address"].ToString();
                //this.RTSReasonTextBox.Text = _data.Rows[0]["RTS Reason"].ToString();


                if (_data.Rows[0]["RTS Reason"].ToString() != "")
                {
                    this.RTSComboBox.Text = _data.Rows[0]["RTS Reason"].ToString();
                }

                this.DCCodeTextBox.Text = _data.Rows[0]["DC Code"].ToString();
                this.DCCNameTextBox.Text = _data.Rows[0]["DC Name"].ToString();
                this.messengerTextBox.Text = _data.Rows[0]["Messenger"].ToString();
                if (_data.Rows[0]["Delivery Status Date"] == DBNull.Value)
                {
                    this.dateDeliveredTimePicker.Value = DateTime.Now;
                }
                else
                {
                    this.dateDeliveredTimePicker.Value = DateTime.Parse(_data.Rows[0]["Delivery Status Date"].ToString());
                }
                
            }
            else
            {
                MessageBox.Show("No data found.", "No data found.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    

        public void UpdateDetails(string _pCycleFilename, string _pAccountNo, string _pDeliveryStatus, string _pReceivedBy, string _pRelationship, string _pMessenger, string _pRemarks, string _pRTSReason)
        {
            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);
            var adapter = new OleDbDataAdapter(String.Format(@"UPDATE [BatchDetails$] Set [Delivery Status]='{0}', [Received By]='{1}', [Relationship]='{2}', [Messenger]='{3}', [Delivery Status Date]='{4}', [Remarks]='{5}', [RTS Reason]='{7}' where [Account No]='{6}'", _pDeliveryStatus, _pReceivedBy, _pRelationship, _pMessenger, this.dateDeliveredTimePicker.Value.ToShortDateString(), _pRemarks, Convert.ToChar(160) + _pAccountNo, _pRTSReason), connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];

            this.deliveryNoTextBox.Text = "";
            this.sequenceNoTextBox.Text = "";
            this.accountNotextBox.Text = "";
            this.fileNameTextBox.Text = "";
            this.subscribersNameTextBox.Text = "";
            this.addressTextBox.Text = "";
            this.MINSRNTextBox.Text = "";
            this.brandTextBox.Text = "";
            this.zipCodeTextBox.Text = "";
            this.remarksTextBox.Text = "";
            //this.deliveryStatusTextBox.Text = "";
            this.deliveryStatusComboBox.SelectedValue = "Select Delivery Status";
            this.receivedByTextBox.Text = "";
            this.relationshipTextBox.Text = "";
            this.RTSNewAddressTextBox.Text = "";
            //this.RTSReasonTextBox.Text = "";
            this.RTSComboBox.SelectedIndex = 0;
            this.DCCodeTextBox.Text = "";
            this.DCCNameTextBox.Text = "";
            this.messengerTextBox.Text = "";


        }

        private void deliveryStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.deliveryStatusComboBox.SelectedValue.ToString().Trim().ToUpper() == "RTS")
            {
                this.RTSComboBox.Enabled = true;
            }
            else
            {
                this.RTSComboBox.Enabled = false;
                
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

        private void relationshipTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.relationshipTextBox.Text.ToUpper() == "OWNER")
            {
                this.receivedByTextBox.Text = this.subscribersNameTextBox.Text;

                this.receivedByTextBox.Enabled = false;
            }
            else
            {
                this.receivedByTextBox.Enabled = true;
            }
        }

        private void accountNotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (Convert.ToInt32(e.KeyChar) == 13)
            {

                if (this.filesComboBox.SelectedValue.ToString() != "Select Cycle Filename")
                {

                    bool _hasRecord = false;

                    this.GetDetailsFromExcel(this.filesComboBox.SelectedValue.ToString(), this.accountNotextBox.Text, ref _hasRecord);

                    if (_hasRecord)
                    {
                        // this.deliveryStatusTextBox.SelectAll();
                        // this.deliveryStatusTextBox.Focus();
                        this.deliveryStatusComboBox.Focus();
                        this.updateButton.Enabled = true;
                    }
                    else
                    {
                        this.updateButton.Enabled = false;

                        MessageBox.Show("No Doc Details found. Please check Account No.", "Account No. not found.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please select cycle name.", "Cycle Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(this.accountNotextBox.Text);
            MessageBox.Show(asciiBytes[0].ToString());
            MessageBox.Show(asciiBytes[1].ToString());
            MessageBox.Show(asciiBytes[2].ToString());
            MessageBox.Show(asciiBytes[3].ToString());
            MessageBox.Show(asciiBytes[4].ToString());
            MessageBox.Show(asciiBytes[5].ToString());
            MessageBox.Show(asciiBytes[6].ToString());
            MessageBox.Show(asciiBytes[7].ToString());
            MessageBox.Show(asciiBytes[8].ToString());
            MessageBox.Show(asciiBytes[9].ToString());
            MessageBox.Show(asciiBytes[10].ToString());
            
        }

        private void SmartDocDeliveryMainForm_Activated(object sender, EventArgs e)
        {
            this.filesComboBox.Focus();
        }

        private void deliveryStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.deliveryStatusComboBox.Text.ToUpper() == "RTS")
            {
                this.RTSComboBox.Enabled = true;
            }
            else
            {
                this.RTSComboBox.Enabled = false;
            }
        }

        private void accountNotextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

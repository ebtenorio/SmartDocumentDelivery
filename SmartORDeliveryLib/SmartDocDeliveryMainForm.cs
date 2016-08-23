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
    public partial class soaTextBox : Form
    {
        string m_ConnectionString = @SmartORDeliveryLib.Properties.Settings.Default.ConnectionStringSetting.ToString();

        string m_MainFolder = @SmartORDeliveryLib.Properties.Settings.Default.MainFolderSetting.ToString();

        SmartDocDeliveryLib _SmartDocDeliveryService;

        public soaTextBox()
        {
            _SmartDocDeliveryService = new SmartDocDeliveryLib(this.m_ConnectionString);

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.deliveryStatusComboBox.Text.ToUpper () != "SELECT DELIVERY STATUS")
            {
                this.UpdateDetails(this.filesComboBox.SelectedValue.ToString(),
                    this.accountNotextBox.Text,
                    this.receivedCheckBox.Checked,
                    this.receivedDatedateTimePicker.Value,
                    this.receivedByTextBox.Text,
                    this.relationshipTextBox.Text, true, this.rtsDateTimePicker.Value,
                    this.rtsReasonComboBox.Text,
                    this.rtsMessengerTextBox.Text,
                    this.rtsNewAddressTextBox.Text,
                    this.remarksTextBox.Text);

                // Clear fields
                this.receivedCheckBox.Checked = false;
                this.receivedDatedateTimePicker.Value = DateTime.Now;
                this.receivedByTextBox.Text = "";
                this.relationshipTextBox.Text = "";
                this.rtsDateTimePicker.Value = DateTime.Now;
                this.rtsReasonComboBox.Text = "";
                this.rtsMessengerTextBox.Text = "";
                this.rtsNewAddressTextBox.Text = "";
                this.remarksTextBox.Text = "";

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
            var adapter = new OleDbDataAdapter(@"SELECT * FROM [Sheet1$] where [Account #] =" + _pAccountNo + "", connectionString);
            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];

            if (_data.Rows.Count > 0)
            {
                _pHasRecord = true;

                //- SOA #
                //- Account #
                //- Billing Period
                //- Account Name
                //- Telephone #
                //- Postal Code
                //- Source_Filename

                this.soaNoTextBox.Text = _data.Rows[0]["SOA #"].ToString();
                this.accountNotextBox.Text = _data.Rows[0]["Account #"].ToString(); ;
                this.billingPeriodNewTextBox.Text = _data.Rows[0]["Billing Period"].ToString(); ;
                this.accountNameTextBox.Text = _data.Rows[0]["Account Name"].ToString(); ;
                this.telephoneNoTextBox.Text = _data.Rows[0]["Telephone #"].ToString(); ;
                this.zipCodeTextBox.Text = _data.Rows[0]["Postal Code"].ToString(); ;
                this.sourceFileNameTextBox.Text = "Source_Filename";


                //this.deliveryNoTextBox.Text = _data.Rows[0]["Delivery No"].ToString();
                //this.sequenceNoTextBox.Text = _data.Rows[0]["Sequence No"].ToString();
                //this.sourceFileNameTextBox.Text = _data.Rows[0]["FileName"].ToString();
                //this.subscribersNameTextBox.Text = _data.Rows[0]["Subscriber Name"].ToString();
                //this.addressTextBox.Text = _data.Rows[0]["Address"].ToString();
                //this.MINSRNTextBox.Text = _data.Rows[0]["MIN/SRN"].ToString();
                //this.brandTextBox.Text = _data.Rows[0]["Brand"].ToString();
                //this.zipCodeTextBox.Text = _data.Rows[0]["ZipCode"].ToString();
                //this.remarksTextBox.Text = _data.Rows[0]["Remarks"].ToString();
                //this.deliveryStatusComboBox.Text = _data.Rows[0]["Delivery Status"].ToString();
                //this.receivedByTextBox.Text = _data.Rows[0]["Received By"].ToString();
                //this.relationshipTextBox.Text = _data.Rows[0]["Relationship"].ToString();
                //this.rtsNewAddressTextBox.Text = _data.Rows[0]["RTS New Address"].ToString();
                //if (_data.Rows[0]["RTS Reason"].ToString() != "")
                //{
                //    this.rtsReasonComboBox.Text = _data.Rows[0]["RTS Reason"].ToString();
                //}
                //this.DCCodeTextBox.Text = _data.Rows[0]["DC Code"].ToString();
                //this.DCCNameTextBox.Text = _data.Rows[0]["DC Name"].ToString();
                //this.rtsMessengerTextBox.Text = _data.Rows[0]["Messenger"].ToString();
                //if (_data.Rows[0]["Delivery Status Date"] == DBNull.Value)
                //{
                //    this.rtsDateTimePicker.Value = DateTime.Now;
                //}
                //else
                //{
                //    this.rtsDateTimePicker.Value = DateTime.Parse(_data.Rows[0]["Delivery Status Date"].ToString());
                //}
                
            }
            else
            {
                MessageBox.Show("No data found.", "No data found.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void UpdateDetails(string _pCycleFilename, string _pAccountNo,
                          bool _pIsReceived, DateTime _pReceivedDate, string _pReceivedBy, string _pRelationship, bool _pIsRTS,
                          DateTime _pRTSDate, string _pRTSReason, string _pRTSMessenger, string _pRTSNewAddress, string _pRemarks)
        {

            
            var connectionString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", this.m_MainFolder + _pCycleFilename);

            var adapter = new OleDbDataAdapter();


            if (this.receivedCheckBox.Checked)
            {
                adapter = new OleDbDataAdapter(String.Format(@"UPDATE [Sheet1$] Set Received={0}, [Received_Date]='{1}', [ReceivedBy]='{2}', [Relationship]='{3}', [RTS]={4}, [RTS_Date]='{5}', [RTS_Reason]='{6}', [RTS_Messenger]='{7}', [RTS_NewAddress]='{8}', [Remarks]='{9}' Where [Account #]={10}",
                                                                                                    _pIsReceived.ToString(), _pReceivedDate.ToString("MM/dd/yyyy"), _pReceivedBy, _pRelationship, _pIsRTS.ToString(), _pRTSDate.ToShortDateString(), _pRTSReason, _pRTSMessenger, _pRTSNewAddress, _pRemarks.Trim(), _pAccountNo), connectionString);
            }
            else
            {
                adapter = new OleDbDataAdapter(String.Format(@"UPDATE [Sheet1$] Set [ReceivedBy]='{0}', [Relationship]='{1}', [RTS]={2}, [RTS_Date]='{3}', [RTS_Reason]='{4}', [RTS_Messenger]='{5}', [RTS_NewAddress]='{6}', [Remarks]='{7}' Where [Account #]={8}",
                                                                                                    _pReceivedBy, _pRelationship, _pIsRTS.ToString(), _pRTSDate.ToShortDateString(), _pRTSReason, _pRTSMessenger, _pRTSNewAddress, _pRemarks.Trim(), _pAccountNo), connectionString);
            }
            

            var ds = new DataSet();
            adapter.Fill(ds, "TransactionTable");
            DataTable _data = ds.Tables["TransactionTable"];

        }

        private void deliveryStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.deliveryStatusComboBox.SelectedValue.ToString().Trim().ToUpper() == "RTS")
            {
                this.rtsReasonComboBox.Enabled = true;
            }
            else
            {
                this.rtsReasonComboBox.Enabled = false;
                
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
                this.rtsReasonComboBox.Enabled = true;
            }
            else
            {
                this.rtsReasonComboBox.Enabled = false;
            }
        }

        private void accountNotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void rtsReasonComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.rtsReasonComboBox.SelectedIndex != 0 && this.rtsReasonComboBox.SelectedIndex != 7)
            {
                this.remarksTextBox.Text = this.rtsReasonComboBox.Text.Substring(5, this.rtsReasonComboBox.Text.Length - 5);             
            }
            else
            {
                this.remarksTextBox.Clear();
            }
        }


    }
}

namespace SmartORDeliveryLib
{
    partial class SmartDocDeliveryMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.updateButton = new System.Windows.Forms.Button();
            this.messengerTextBox = new System.Windows.Forms.TextBox();
            this.receivedByTextBox = new System.Windows.Forms.TextBox();
            this.relationshipTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.deliveryNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DCCNameTextBox = new System.Windows.Forms.TextBox();
            this.DCCodeTextBox = new System.Windows.Forms.TextBox();
            this.RTSNewAddressTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.MINSRNTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.subscribersNameTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.sequenceNoTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.accountNotextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RTSComboBox = new System.Windows.Forms.ComboBox();
            this.deliveryStatusComboBox = new System.Windows.Forms.ComboBox();
            this.dateDeliveredTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filesComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Excel Files (.xls)| *.xls";
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(229, 204);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(154, 23);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // messengerTextBox
            // 
            this.messengerTextBox.Enabled = false;
            this.messengerTextBox.Location = new System.Drawing.Point(126, 19);
            this.messengerTextBox.Name = "messengerTextBox";
            this.messengerTextBox.Size = new System.Drawing.Size(257, 20);
            this.messengerTextBox.TabIndex = 5;
            // 
            // receivedByTextBox
            // 
            this.receivedByTextBox.Location = new System.Drawing.Point(126, 147);
            this.receivedByTextBox.Name = "receivedByTextBox";
            this.receivedByTextBox.Size = new System.Drawing.Size(257, 20);
            this.receivedByTextBox.TabIndex = 9;
            // 
            // relationshipTextBox
            // 
            this.relationshipTextBox.Location = new System.Drawing.Point(126, 122);
            this.relationshipTextBox.Name = "relationshipTextBox";
            this.relationshipTextBox.Size = new System.Drawing.Size(257, 20);
            this.relationshipTextBox.TabIndex = 8;
            this.relationshipTextBox.TextChanged += new System.EventHandler(this.relationshipTextBox_TextChanged);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Location = new System.Drawing.Point(126, 173);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(257, 20);
            this.remarksTextBox.TabIndex = 10;
            // 
            // deliveryNoTextBox
            // 
            this.deliveryNoTextBox.Enabled = false;
            this.deliveryNoTextBox.Location = new System.Drawing.Point(131, 48);
            this.deliveryNoTextBox.Name = "deliveryNoTextBox";
            this.deliveryNoTextBox.Size = new System.Drawing.Size(257, 20);
            this.deliveryNoTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Delivery No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Delivery Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Received By";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Relationship";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Messenger";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.deliveryNoTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DCCNameTextBox);
            this.groupBox1.Controls.Add(this.DCCodeTextBox);
            this.groupBox1.Controls.Add(this.RTSNewAddressTextBox);
            this.groupBox1.Controls.Add(this.zipCodeTextBox);
            this.groupBox1.Controls.Add(this.brandTextBox);
            this.groupBox1.Controls.Add(this.MINSRNTextBox);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.subscribersNameTextBox);
            this.groupBox1.Controls.Add(this.fileNameTextBox);
            this.groupBox1.Controls.Add(this.sequenceNoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 369);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Details";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 338);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "DCName";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(35, 312);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 41;
            this.label18.Text = "DCCode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "RTS New Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "ZipCode";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Brand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "MIN/SRN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Subscriber Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Filename";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Sequence No.";
            // 
            // DCCNameTextBox
            // 
            this.DCCNameTextBox.Enabled = false;
            this.DCCNameTextBox.Location = new System.Drawing.Point(132, 335);
            this.DCCNameTextBox.Name = "DCCNameTextBox";
            this.DCCNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.DCCNameTextBox.TabIndex = 31;
            // 
            // DCCodeTextBox
            // 
            this.DCCodeTextBox.Enabled = false;
            this.DCCodeTextBox.Location = new System.Drawing.Point(132, 309);
            this.DCCodeTextBox.Name = "DCCodeTextBox";
            this.DCCodeTextBox.Size = new System.Drawing.Size(257, 20);
            this.DCCodeTextBox.TabIndex = 30;
            // 
            // RTSNewAddressTextBox
            // 
            this.RTSNewAddressTextBox.Enabled = false;
            this.RTSNewAddressTextBox.Location = new System.Drawing.Point(132, 283);
            this.RTSNewAddressTextBox.Name = "RTSNewAddressTextBox";
            this.RTSNewAddressTextBox.Size = new System.Drawing.Size(257, 20);
            this.RTSNewAddressTextBox.TabIndex = 28;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Enabled = false;
            this.zipCodeTextBox.Location = new System.Drawing.Point(132, 257);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(257, 20);
            this.zipCodeTextBox.TabIndex = 27;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Enabled = false;
            this.brandTextBox.Location = new System.Drawing.Point(132, 231);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(257, 20);
            this.brandTextBox.TabIndex = 26;
            // 
            // MINSRNTextBox
            // 
            this.MINSRNTextBox.Enabled = false;
            this.MINSRNTextBox.Location = new System.Drawing.Point(132, 205);
            this.MINSRNTextBox.Name = "MINSRNTextBox";
            this.MINSRNTextBox.Size = new System.Drawing.Size(257, 20);
            this.MINSRNTextBox.TabIndex = 25;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Enabled = false;
            this.addressTextBox.Location = new System.Drawing.Point(131, 126);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(257, 73);
            this.addressTextBox.TabIndex = 24;
            // 
            // subscribersNameTextBox
            // 
            this.subscribersNameTextBox.Enabled = false;
            this.subscribersNameTextBox.Location = new System.Drawing.Point(131, 100);
            this.subscribersNameTextBox.Name = "subscribersNameTextBox";
            this.subscribersNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.subscribersNameTextBox.TabIndex = 23;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Enabled = false;
            this.fileNameTextBox.Location = new System.Drawing.Point(131, 74);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.fileNameTextBox.TabIndex = 22;
            // 
            // sequenceNoTextBox
            // 
            this.sequenceNoTextBox.Enabled = false;
            this.sequenceNoTextBox.Location = new System.Drawing.Point(131, 22);
            this.sequenceNoTextBox.Name = "sequenceNoTextBox";
            this.sequenceNoTextBox.Size = new System.Drawing.Size(257, 20);
            this.sequenceNoTextBox.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "RTS Reason";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Account No.";
            // 
            // accountNotextBox
            // 
            this.accountNotextBox.Location = new System.Drawing.Point(142, 58);
            this.accountNotextBox.Name = "accountNotextBox";
            this.accountNotextBox.Size = new System.Drawing.Size(257, 20);
            this.accountNotextBox.TabIndex = 11;
            this.accountNotextBox.TextChanged += new System.EventHandler(this.accountNotextBox_TextChanged);
            this.accountNotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNotextBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTSComboBox);
            this.groupBox2.Controls.Add(this.deliveryStatusComboBox);
            this.groupBox2.Controls.Add(this.dateDeliveredTimePicker);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.messengerTextBox);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.receivedByTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.relationshipTextBox);
            this.groupBox2.Controls.Add(this.remarksTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(416, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 243);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Details";
            // 
            // RTSComboBox
            // 
            this.RTSComboBox.Enabled = false;
            this.RTSComboBox.FormattingEnabled = true;
            this.RTSComboBox.Items.AddRange(new object[] {
            "Select RTS Reason",
            "MOVED OUT",
            "INSUFFICIENT ADDRESS",
            "REFUSED TO ACCEPT",
            "UNKNOWN SUBSCRIBER",
            "NO ONE INSIDE TO RECEIVE",
            "OTHERS"});
            this.RTSComboBox.Location = new System.Drawing.Point(126, 96);
            this.RTSComboBox.Name = "RTSComboBox";
            this.RTSComboBox.Size = new System.Drawing.Size(257, 21);
            this.RTSComboBox.TabIndex = 7;
            this.RTSComboBox.Text = "Select RTS Reason";
            // 
            // deliveryStatusComboBox
            // 
            this.deliveryStatusComboBox.FormattingEnabled = true;
            this.deliveryStatusComboBox.Items.AddRange(new object[] {
            "Select Delivery Status",
            "RTS",
            "Delivered"});
            this.deliveryStatusComboBox.Location = new System.Drawing.Point(126, 71);
            this.deliveryStatusComboBox.Name = "deliveryStatusComboBox";
            this.deliveryStatusComboBox.Size = new System.Drawing.Size(257, 21);
            this.deliveryStatusComboBox.TabIndex = 6;
            this.deliveryStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.deliveryStatusComboBox_SelectedIndexChanged);
            // 
            // dateDeliveredTimePicker
            // 
            this.dateDeliveredTimePicker.Location = new System.Drawing.Point(126, 45);
            this.dateDeliveredTimePicker.Name = "dateDeliveredTimePicker";
            this.dateDeliveredTimePicker.Size = new System.Drawing.Size(257, 20);
            this.dateDeliveredTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date Delivered";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(891, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 123);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.Visible = false;
            // 
            // filesComboBox
            // 
            this.filesComboBox.FormattingEnabled = true;
            this.filesComboBox.Location = new System.Drawing.Point(142, 31);
            this.filesComboBox.Name = "filesComboBox";
            this.filesComboBox.Size = new System.Drawing.Size(258, 21);
            this.filesComboBox.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(46, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Cycle Filename";
            // 
            // SmartDocDeliveryMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(846, 479);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.filesComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.accountNotextBox);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SmartDocDeliveryMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return";
            this.Activated += new System.EventHandler(this.SmartDocDeliveryMainForm_Activated);
            this.Load += new System.EventHandler(this.SmartDocDeliveryMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox messengerTextBox;
        private System.Windows.Forms.TextBox receivedByTextBox;
        private System.Windows.Forms.TextBox relationshipTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.TextBox deliveryNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MINSRNTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox subscribersNameTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox accountNotextBox;
        private System.Windows.Forms.TextBox sequenceNoTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox DCCNameTextBox;
        private System.Windows.Forms.TextBox DCCodeTextBox;
        private System.Windows.Forms.TextBox RTSNewAddressTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox filesComboBox;
        private System.Windows.Forms.DateTimePicker dateDeliveredTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox deliveryStatusComboBox;
        private System.Windows.Forms.ComboBox RTSComboBox;
    }
}


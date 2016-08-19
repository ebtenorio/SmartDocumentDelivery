namespace SmartORDeliveryLib
{
    partial class Main
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
            this.label20 = new System.Windows.Forms.Label();
            this.filesComboBox = new System.Windows.Forms.ComboBox();
            this.contentDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showContentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateDispatchedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchDateDispatchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "Cycle Filename";
            // 
            // filesComboBox
            // 
            this.filesComboBox.FormattingEnabled = true;
            this.filesComboBox.Location = new System.Drawing.Point(157, 12);
            this.filesComboBox.Name = "filesComboBox";
            this.filesComboBox.Size = new System.Drawing.Size(240, 21);
            this.filesComboBox.TabIndex = 34;
            // 
            // contentDataGridView
            // 
            this.contentDataGridView.AllowUserToAddRows = false;
            this.contentDataGridView.AllowUserToDeleteRows = false;
            this.contentDataGridView.AllowUserToOrderColumns = true;
            this.contentDataGridView.AllowUserToResizeColumns = false;
            this.contentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contentDataGridView.Location = new System.Drawing.Point(12, 105);
            this.contentDataGridView.Name = "contentDataGridView";
            this.contentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contentDataGridView.Size = new System.Drawing.Size(962, 397);
            this.contentDataGridView.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Search Account No.";
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.Location = new System.Drawing.Point(157, 41);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(240, 20);
            this.accountNoTextBox.TabIndex = 39;
            this.accountNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNoTextBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(403, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(147, 23);
            this.searchButton.TabIndex = 40;
            this.searchButton.Text = "Search Account";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showContentButton
            // 
            this.showContentButton.Location = new System.Drawing.Point(403, 10);
            this.showContentButton.Name = "showContentButton";
            this.showContentButton.Size = new System.Drawing.Size(147, 23);
            this.showContentButton.TabIndex = 41;
            this.showContentButton.Text = "Show Content";
            this.showContentButton.UseVisualStyleBackColor = true;
            this.showContentButton.Click += new System.EventHandler(this.showContentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Search Date Dispatched";
            // 
            // dateDispatchedTimePicker
            // 
            this.dateDispatchedTimePicker.Location = new System.Drawing.Point(157, 69);
            this.dateDispatchedTimePicker.Name = "dateDispatchedTimePicker";
            this.dateDispatchedTimePicker.Size = new System.Drawing.Size(240, 20);
            this.dateDispatchedTimePicker.TabIndex = 43;
            // 
            // searchDateDispatchButton
            // 
            this.searchDateDispatchButton.Location = new System.Drawing.Point(403, 68);
            this.searchDateDispatchButton.Name = "searchDateDispatchButton";
            this.searchDateDispatchButton.Size = new System.Drawing.Size(147, 23);
            this.searchDateDispatchButton.TabIndex = 44;
            this.searchDateDispatchButton.Text = "Search by Dispatched Date";
            this.searchDateDispatchButton.UseVisualStyleBackColor = true;
            this.searchDateDispatchButton.Click += new System.EventHandler(this.searchDateDispatchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 81);
            this.button1.TabIndex = 45;
            this.button1.Text = "Dispatch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(884, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 81);
            this.button2.TabIndex = 46;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchDateDispatchButton);
            this.Controls.Add(this.dateDispatchedTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showContentButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.accountNoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contentDataGridView);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.filesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox filesComboBox;
        private System.Windows.Forms.DataGridView contentDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showContentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateDispatchedTimePicker;
        private System.Windows.Forms.Button searchDateDispatchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
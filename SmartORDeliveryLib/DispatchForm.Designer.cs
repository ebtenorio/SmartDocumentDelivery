namespace SmartORDeliveryLib
{
    partial class DispatchForm
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
            this.messenger = new System.Windows.Forms.TextBox();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.accountNoListBox = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messenger
            // 
            this.messenger.Location = new System.Drawing.Point(99, 55);
            this.messenger.Name = "messenger";
            this.messenger.Size = new System.Drawing.Size(330, 20);
            this.messenger.TabIndex = 0;
            this.messenger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.messenger_KeyPress);
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.Location = new System.Drawing.Point(99, 81);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(330, 20);
            this.accountNoTextBox.TabIndex = 1;
            this.accountNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNoTextBox_KeyPress);
            // 
            // accountNoListBox
            // 
            this.accountNoListBox.FormattingEnabled = true;
            this.accountNoListBox.Location = new System.Drawing.Point(99, 107);
            this.accountNoListBox.Name = "accountNoListBox";
            this.accountNoListBox.Size = new System.Drawing.Size(330, 251);
            this.accountNoListBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(354, 364);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(273, 364);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Messenger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Account No.";
            // 
            // filesComboBox
            // 
            this.filesComboBox.FormattingEnabled = true;
            this.filesComboBox.Location = new System.Drawing.Point(99, 28);
            this.filesComboBox.Name = "filesComboBox";
            this.filesComboBox.Size = new System.Drawing.Size(330, 21);
            this.filesComboBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cycle Filename";
            // 
            // DispatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.accountNoListBox);
            this.Controls.Add(this.accountNoTextBox);
            this.Controls.Add(this.messenger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "DispatchForm";
            this.Text = "Dispatch";
            this.Load += new System.EventHandler(this.DispatchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messenger;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.ListBox accountNoListBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filesComboBox;
        private System.Windows.Forms.Label label3;
    }
}
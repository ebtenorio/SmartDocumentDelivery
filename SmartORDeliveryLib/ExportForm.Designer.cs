namespace SmartORDeliveryLib
{
    partial class ExportForm
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
            this.cycleTreeView = new System.Windows.Forms.TreeView();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.exportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exportAllButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.deliveryNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cycleTreeView
            // 
            this.cycleTreeView.Location = new System.Drawing.Point(12, 38);
            this.cycleTreeView.Name = "cycleTreeView";
            this.cycleTreeView.Size = new System.Drawing.Size(328, 439);
            this.cycleTreeView.TabIndex = 22;
            this.cycleTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cycleTreeView_AfterSelect);
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.AllowUserToAddRows = false;
            this.detailsDataGridView.AllowUserToDeleteRows = false;
            this.detailsDataGridView.AllowUserToOrderColumns = true;
            this.detailsDataGridView.AllowUserToResizeRows = false;
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Location = new System.Drawing.Point(346, 38);
            this.detailsDataGridView.MultiSelect = false;
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.ReadOnly = true;
            this.detailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsDataGridView.ShowEditingIcon = false;
            this.detailsDataGridView.Size = new System.Drawing.Size(567, 439);
            this.detailsDataGridView.TabIndex = 23;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(743, 483);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(170, 23);
            this.exportButton.TabIndex = 24;
            this.exportButton.Text = "Export Selected File";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Data Preview ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cycle Files";
            // 
            // exportAllButton
            // 
            this.exportAllButton.Location = new System.Drawing.Point(743, 528);
            this.exportAllButton.Name = "exportAllButton";
            this.exportAllButton.Size = new System.Drawing.Size(170, 23);
            this.exportAllButton.TabIndex = 27;
            this.exportAllButton.Text = "Export All Completed";
            this.exportAllButton.UseVisualStyleBackColor = true;
            this.exportAllButton.Click += new System.EventHandler(this.exportAllButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(567, 483);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(170, 23);
            this.refreshButton.TabIndex = 28;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deliveryNoTextBox
            // 
            this.deliveryNoTextBox.Location = new System.Drawing.Point(683, 12);
            this.deliveryNoTextBox.Name = "deliveryNoTextBox";
            this.deliveryNoTextBox.Size = new System.Drawing.Size(148, 20);
            this.deliveryNoTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Delivery No.";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(837, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(76, 23);
            this.searchButton.TabIndex = 31;
            this.searchButton.Text = "Refresh";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 522);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deliveryNoTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.exportAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.detailsDataGridView);
            this.Controls.Add(this.cycleTreeView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportForm";
            this.Text = "Export Cycle Files";
            this.Load += new System.EventHandler(this.ExportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView cycleTreeView;
        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exportAllButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox deliveryNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
    }
}
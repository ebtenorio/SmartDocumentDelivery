using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartDocDeliveryLibrary;
using SmartDocDeliveryLibrary.DTOs;

namespace SmartORDeliveryLib
{
    public partial class ExportForm : Form
    {
        string m_ConnectionString = @SmartORDeliveryLib.Properties.Settings.Default.ConnectionStringSetting.ToString();
        SmartDocDeliveryLib _SmartDocDeliveryService;
        TreeNode _mainTreeNode = new TreeNode("Not Exported - Completed Cycles");
        TreeNode _main2TreeNode = new TreeNode("Still to be completed");
        TreeNode _main3TreeNode = new TreeNode("Exported Cycles");
        TreeNode _childTreeNode;
        string _main1Text = ""; string _main2Text = ""; string _main3Text = "";

        public ExportForm()
        {
            _SmartDocDeliveryService = new SmartDocDeliveryLib(this.m_ConnectionString);
            InitializeComponent();
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            this._main1Text = _mainTreeNode.Text;
            this._main2Text = _main2TreeNode.Text;
            this._main3Text = _main3TreeNode.Text;
            this.PopulateTree();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            _SmartDocDeliveryService.SmartDocDeliveryService.ExportToExcel(this.cycleTreeView.SelectedNode.Text);

            _SmartDocDeliveryService.SmartDocDeliveryService.UpdateCycleFilenameStatus(this.cycleTreeView.SelectedNode.Text);

            this.PopulateTree();

            MessageBox.Show("Excel file successfully exported at " + this._SmartDocDeliveryService.SmartDocDeliveryService.GetConfigurationValue("EXPORTPATH"), "Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            
        }

        private void PopulateTree()
        {           
            this.cycleTreeView.Nodes.Clear();
            this._mainTreeNode.Nodes.Clear();
            this._main2TreeNode.Nodes.Clear();
            this._main3TreeNode.Nodes.Clear();
                
            foreach (DTOCycleFilename _CycleName in _SmartDocDeliveryService.SmartDocDeliveryService.GetCycleFilenameList())
            {
                if (!(_SmartDocDeliveryService.SmartDocDeliveryService.GetPercentageCompleted(_CycleName.Filename) < 100))
                {
                    _childTreeNode = new TreeNode(_CycleName.Filename);
                    _mainTreeNode.Nodes.Add(_childTreeNode);
                    _childTreeNode = null;
                }
                else
                {
                    _childTreeNode = new TreeNode(_CycleName.Filename);
                    _main2TreeNode.Nodes.Add(_childTreeNode);
                    _childTreeNode = null;
                }
            }


            foreach (DTOCycleFilename _CycleName in _SmartDocDeliveryService.SmartDocDeliveryService.GetExportedCycleFilenameList())
            {
                _childTreeNode = new TreeNode(_CycleName.Filename);
                _main3TreeNode.Nodes.Add(_childTreeNode);
                _childTreeNode = null;                
            }

            this._mainTreeNode.Text = this._main1Text + " (" + this._mainTreeNode.Nodes.Count + ")";
            this._main2TreeNode.Text = this._main2Text + " (" + this._main2TreeNode.Nodes.Count + ")";
            this._main3TreeNode.Text = this._main3Text + " (" + this._main3TreeNode.Nodes.Count + ")";

            this.cycleTreeView.Nodes.Add(_mainTreeNode);
            this.cycleTreeView.Nodes.Add(_main2TreeNode);
            this.cycleTreeView.Nodes.Add(_main3TreeNode);
            
            this.cycleTreeView.ExpandAll();

            // if (_mainTreeNode.Nodes.Count == 0) this.exportButton.Enabled = false;
            // if (_mainTreeNode.Nodes.Count == 0) { this.exportAllButton.Enabled = false; } else { this.exportAllButton.Enabled = true; }

        }

        private void cycleTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.detailsDataGridView.DataSource = _SmartDocDeliveryService.SmartDocDeliveryService.TransactionListByCycle(this.cycleTreeView.SelectedNode.Text);

            if (((DTODocDeliveryTransactionList)this.detailsDataGridView.DataSource).Count > 0)
            {
                this.exportButton.Enabled = true;
            }
            else
            {
                this.exportButton.Enabled = false;
            }
            

            //if (e.Node.Parent != null)
            //{
            //    if (e.Node.Parent.Text == _mainTreeNode.Text)
            //    {
            //        this.exportButton.Enabled = true;
            //    }
            //    else
            //    {
            //        this.exportButton.Enabled = false;
            //    }
            //}
        }

        private void exportAllButton_Click(object sender, EventArgs e)
        {
            foreach (TreeNode _cycleFilenameNode in this._mainTreeNode.Nodes)
            {
                _SmartDocDeliveryService.SmartDocDeliveryService.ExportToExcel(_cycleFilenameNode.Text);
                _SmartDocDeliveryService.SmartDocDeliveryService.UpdateCycleFilenameStatus(_cycleFilenameNode.Text);
            }
            this.PopulateTree();

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.PopulateTree();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(((DTODocDeliveryTransactionList)this.detailsDataGridView.DataSource).Find(x => x.DeliveryNo == this.deliveryNoTextBox.Text));            
        }
    }

}

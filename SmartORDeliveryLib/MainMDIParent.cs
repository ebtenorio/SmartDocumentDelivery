using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartDocDeliveryLibrary;
using SmartORDeliveryLib;

namespace SmartORDeliveryLib
{
    public partial class MainMDIParent : Form
    {
        string m_ConnectionString = @SmartORDeliveryLib.Properties.Settings.Default.ConnectionStringSetting.ToString();

        SmartDocDeliveryLib _SmartDocDeliveryService;

        private int childFormNumber = 0;

        public MainMDIParent()
        {
            _SmartDocDeliveryService = new SmartDocDeliveryLib(this.m_ConnectionString);

            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainMDIParent_Load(object sender, EventArgs e)
        {
            //if (DateTime.Now.Month == 5 && DateTime.Now.Day == 16)
            //{
            //    MessageBox.Show("TEST VERSION HAS EXPIRED." + Environment.NewLine + "Application will now close.", "Expired Version", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //}
            //else
            //{
                Main _mainForm = new Main();

                _mainForm.StartPosition = FormStartPosition.CenterScreen;

                _mainForm.ShowDialog();
            //}
        }

        private void importCycleFilenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusStrip.Text  = "Importing file data to database...";

            string _filename = "";

            this.openFileDialog.ShowDialog();

            _filename = this.openFileDialog.FileName;

            if (_filename != "")
            {
                _SmartDocDeliveryService.SmartDocDeliveryService.ImportDataFromFile(_filename);

                _SmartDocDeliveryService.SmartDocDeliveryService.InsertCycleFilename(_filename);

                MessageBox.Show("Records have been successfully imported to database.", "Records imported.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No file has been selected.", "No file selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Text = "";

        }

        private void exportCycleFilenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportForm _exportForm = new ExportForm();

            _exportForm.MdiParent = this;

            _exportForm.StartPosition = FormStartPosition.CenterScreen;

            _exportForm.Show();
        }

        private void updateDeliveryDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartDocDeliveryMainForm _DeliveryDocumentForm = new SmartDocDeliveryMainForm();
            
            _DeliveryDocumentForm.StartPosition = FormStartPosition.CenterScreen;

            _DeliveryDocumentForm.Show();

        }

        private void MainMDIParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void dispathToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DispatchForm _DispatchForm = new DispatchForm();
           
            _DispatchForm.StartPosition = FormStartPosition.CenterScreen;

            _DispatchForm.ShowDialog();

        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartDocDeliveryMainForm _DeliveryDetailsForm = new SmartDocDeliveryMainForm();

            _DeliveryDetailsForm.StartPosition = FormStartPosition.CenterScreen;

            _DeliveryDetailsForm.ShowDialog();

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main _main = new Main();

            _main.StartPosition = FormStartPosition.CenterScreen;

            _main.ShowDialog();
        }
    }
}

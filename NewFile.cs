using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManifestVieweRTF
{
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
        }

        public string fileName { get; set; }
        public ManifestFileType FileType { get; set; } = ManifestFileType.Interface;
        public string CommandFileText { get { return txtCommandFileText.Text;}}

        private void cmdOk_Click(object sender, EventArgs e)
        {
            fileName = this.txtFileName.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tmrValidate_Tick(object sender, EventArgs e)
        {
                this.cmdOk.Enabled = (this.txtFileName.Text != "");   
        }

        private void RadioButtons_Clicked(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            FileType = ManifestFileType.Command;

            if (rb.Text.StartsWith("I") && rb.Checked)
            {
                FileType = ManifestFileType.Interface;
                this.PnlCommandFile.Enabled = false;
            }
            else
            {
                this.PnlCommandFile.Enabled = true;
            }
        }

        public static string GetExecutableDirectory()
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(exePath);
        }

        private void NewFile_Load(object sender, EventArgs e)
        {
            ManifestBaseCommandFiles mbcfs = new ManifestBaseCommandFiles();
            string exeDirectory = GetExecutableDirectory();
            mbcfs.ReadManifestFile($"{exeDirectory}\\ManifestBaseCommandFiles.txt");
            this.cmbCommandFileTypes.DataSource = mbcfs.CommandFileTexts.ToArray().Clone();
            this.cmbCommandFileTypes.DisplayMember = "Name";
            this.cmbCommandFileTypes.ValueMember = "Text";
            this.cmbCommandFileTypes.SelectedItem = 0;
        }

        private void cmbCommandFileTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManifestBaseCommandFile cf = cmbCommandFileTypes.SelectedItem as ManifestBaseCommandFile;
            this.txtCommandFileText.Text = cf.Text;
        }

        private void rbCommand_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


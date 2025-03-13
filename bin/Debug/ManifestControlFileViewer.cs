using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ControlSizeSlider;
using LoadManifest;
using System.Linq;

namespace ManifestVieweRTF
{
    public partial class FrmManifestViewer : Form
    {
        string _selectedText = "";
        Dictionary<string, RichTextBox> formatQueue = new Dictionary<string, RichTextBox>();

        SymmetryChars symmetryCharsI = new SymmetryChars();
        SymmetryChars symmetryCharsC = new SymmetryChars();
        List<WindowsSlider> Ws = new List<WindowsSlider>();

        private bool _doNotProcessTextChange = false;

        System.IO.FileInfo fi;

        string _SearchAndHighlight = "";
        string SourceWorkingFolder = "";



        public bool rtbTextChanged { get; private set; }

        public FrmManifestViewer()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                this.fi = new System.IO.FileInfo(ofd.FileName);
                LoadManifest.LoadAndFormatManifestFile lmf = new LoadManifest.LoadAndFormatManifestFile();
                lmf.loadfile(ofd.FileName);
                this.rtfControlFile.Rtf = lmf.GetRtf();
                this.Text = ofd.FileName;
            }
        }

        private void OnRtfControlMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                //If the user has pressed control then do the search for the command file
                string possibleFileSelected = _selectedText;
                openSubFile(possibleFileSelected);
            }
        }

        private void openSubFile(string possibleFileSelected)
        {

            string ControlFileRoot = "";

            string possibleFileName = "";
            try
            {
                ControlFileRoot = GetFileDetails(this.rtfControlFile).FilePath;
                possibleFileName = System.IO.Path.Combine(ControlFileRoot, possibleFileSelected + ".txt");
            }
            catch (Exception)
            {
                return;
            }

            if (System.IO.File.Exists(possibleFileName))
            {
                try
                {
                    LoadManifest.LoadAndFormatManifestFile lmf = new LoadManifest.LoadAndFormatManifestFile();
                    lmf.loadfile(possibleFileName);
                    this.RtfSubFile.Rtf = lmf.GetRtf();
                    this.lblSubControlFile.Text = (possibleFileName);
                    FileDetails fd = new FileDetails() { FileName = possibleFileName, FilePath = ControlFileRoot, TextChanged = "Y" };
                    this.RtfSubFile.Tag = fd;
                }
                catch (Exception ThisError)
                {
                    MessageBox.Show(ThisError.Message);
                }
            }
            else
            {
                //it may be a variable....
                int x = 1;
            }

            LoadManifest.LoadAndFormatManifestFile lmfb = new LoadManifest.LoadAndFormatManifestFile();

        }

        private void FrmManifestViewer_Load(object sender, EventArgs e)
        {
            this.rtfControlFile.MouseClick += new MouseEventHandler(OnRtfControlMouseDoubleClick);
            //this.rtfControlFile.TextChanged += new EventHandler(rtfTextChanged);

            this.rtfControlFile.Tag = new FileDetails();
            this.RtfSubFile.Tag = new FileDetails();
            this.rtfThreadFile.Tag = new FileDetails();

            string[] sb = { "Press right mouse for context menu..." };
            LoadManifest.LoadAndFormatManifestFile lmf = new LoadManifest.LoadAndFormatManifestFile();
            this.rtfControlFile.Rtf = lmf.GetRtf(sb);

            symmetryCharsI.richTextBox = this.rtfControlFile;
            symmetryCharsC.richTextBox = this.RtfSubFile;
            symmetryCharsI.start();
            symmetryCharsC.start();

            WindowsSlider wsA = new WindowsSlider();
            wsA.Type = WindowsSlider.WindowsSliderType.vertical;
            wsA.eventSource = this.lblVSlider;
            wsA.TopControls.Add(this.PnlMain);
            wsA.BottomControls.Add(this.pnlThreadAndControl);

            wsA.Start();

            WindowsSlider wsB = new WindowsSlider();
            wsB.Type = WindowsSlider.WindowsSliderType.horizontal;
            wsB.eventSource = this.lblHSlider;
            wsB.LeftControls.Add(this.PnlDocTree);
            wsB.RightControls.Add(this.PnlMain);
            wsB.RightControls.Add(this.pnlThreadAndControl);
            wsB.RightControls.Add(this.pnlXpath);
            wsB.RightControls.Add(this.lblVSlider);
            wsB.RightControls.Add(this.lblXmlVSlider);
            wsB.Start();

            WindowsSlider wsC = new WindowsSlider();
            wsC.Type = WindowsSlider.WindowsSliderType.horizontal;
            wsC.eventSource = this.lblHControl;
            wsC.LeftControls.Add(this.pnRTF);

            wsC.RightControls.Add(this.PnlSearchResults);
            wsC.Start();

            WindowsSlider wsD = new WindowsSlider();
            wsD.Type = WindowsSlider.WindowsSliderType.vertical;
            wsD.eventSource = this.lblXmlVSlider;
            wsD.TopControls.Add(pnlThreadAndControl);
            wsD.BottomControls.Add(this.pnlXpath);
            wsD.Start();

            WindowsSlider wsE = new WindowsSlider();
            wsE.Type = WindowsSlider.WindowsSliderType.horizontal;
            wsE.eventSource = this.lblXpathHSlider;
            wsE.LeftControls.Add(this.txtXmlFile);
            wsE.RightControls.Add(this.lblXpath);
            wsE.RightControls.Add(this.TxtXpath);
            wsE.Start();

            WindowsSlider wsF = new WindowsSlider();
            wsF.Type = WindowsSlider.WindowsSliderType.horizontal;
            wsF.eventSource = this.lblHThreadAndControl;
            wsF.LeftControls.Add(pnlThread);
            wsF.RightControls.Add(this.PnlSub);
            wsF.Start();


           

            this.Ws.Add(wsA);
            this.Ws.Add(wsB);
            this.Ws.Add(wsC);
            this.Ws.Add(wsD);
            this.Ws.Add(wsE);

            this.SourceWorkingFolder = RegistryHelper.ReadRegistry("WorkingFolder");
            this.txtXmlFile.Text = RegistryHelper.ReadRegistry("XmlFile");
            this.TxtXpath.Text = RegistryHelper.ReadRegistry("XmlPath");
            this.txtXmlResult.Text = RegistryHelper.ReadRegistry("XmlResult");
            this.txtSearch.Text = RegistryHelper.ReadRegistry("RegExPattern");
            this.txtCtrlRegExFilter.Text = RegistryHelper.ReadRegistry("CtrlRegExFilter");
            this.txtIntRegExFilter.Text = RegistryHelper.ReadRegistry("IntRegExFilter");

            if (SourceWorkingFolder != null)
            {
                FilesToTree ftt = new FilesToTree();
                ftt.PopulateTreeViewWithFilesOfType(SourceWorkingFolder, ".*",this.tvFiles, "Threads", "TYPE=THREAD", "THR");
            }
        }

        private bool LoadFileToTargetTextBox(RichTextBox targetTextBox, string Filename)
        {
            LoadManifest.LoadAndFormatManifestFile lmf = new LoadManifest.LoadAndFormatManifestFile();
            lmf.loadfile(Filename);
            targetTextBox.Rtf = lmf.GetRtf();
            return true;
        }
        private bool LoadTextToTargetTextBox(RichTextBox targetTextBox, string Text = "Please press right button, load file to continue...")
        {
            LoadManifest.LoadAndFormatManifestFile lmf = new LoadManifest.LoadAndFormatManifestFile();
            targetTextBox.Rtf = lmf.GetRtf();
            return true;
        }
        private void openSubFile(FileDetails fd, string possibleFileSelected)
        {
            _SearchAndHighlight = rtfControlFile.SelectedText;
            string possibleFileName = "";
            try
            {
                string ControlFileRoot = fd.FilePath;
                possibleFileName = System.IO.Path.Combine(ControlFileRoot, possibleFileSelected + ".txt");
            }
            catch (Exception)
            {
                return;
            }

            if (System.IO.File.Exists(possibleFileName))
            {
                try
                {
                    LoadManifest.LoadAndFormatManifestFile lmf = new LoadManifest.LoadAndFormatManifestFile();
                    lmf.loadfile(possibleFileName);
                    this.RtfSubFile.Rtf = lmf.GetRtf();
                    this.lblSubControlFile.Text = (possibleFileName);
                }
                catch (Exception ThisError)
                {
                    MessageBox.Show(ThisError.Message);
                }
            }
            else
            {
                //it may be a variable....
                int x = 1;
            }
            LoadManifest.LoadAndFormatManifestFile lmfb = new LoadManifest.LoadAndFormatManifestFile();
            lmfb.refreshRTF(this.rtfControlFile);
        }



        private void RtfSubFile_TextChanged(object sender, EventArgs e)
        {
            AddToFormatQueue(RtfSubFile);
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            LoadManifest.LoadAndFormatManifestFile lmfb = new LoadManifest.LoadAndFormatManifestFile();
            lmfb.refreshRTF(this.rtfControlFile);
            lmfb.refreshRTF(this.RtfSubFile);
            Search s = new Search();
            rtfSearchResults.AppendText($"\r\n-------------------- ({this.txtSearch.Text}) -------------------------\r\n");
            rtfSearchResults.AppendText($"{this.LblControlFile.Text}\r\n{s.DoSearch(this.rtfControlFile.Text, this.txtSearch.Text)}");
            lmfb.refreshRTF(this.rtfSearchResults);
        }

        private FileDetails GetFileDetails(RichTextBox rtb)
        {
            FileDetails fd = rtb.Tag as FileDetails;
            if (fd == null)
            {
                return new FileDetails() { TextChanged = "N" };
            }
            else { return rtb.Tag as FileDetails; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ResetTreeView()
        {
            FilesToTree ftt = new FilesToTree();
            string SourceFolder = ftt.SelectFolder();
            if (SourceFolder != "")
            {
                SourceWorkingFolder = SourceFolder;
                this.tvFiles.Nodes.Clear();
                ftt.PopulateTreeViewWithFilesOfType(SourceWorkingFolder, ".*", this.tvFiles, "Threads", "TYPE=THREAD", "THR");
            }
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetTreeView();
        }

        private void tvFiles_DoubleClick(object sender, EventArgs e)
        {

            TreeNode tn = tvFiles.SelectedNode;
            RichTextBox TargetBox = new RichTextBox();
            Label TargetLabel = new Label();

            if (tn==null)
            {
                return;
            }

            try
            {


               
                FileDetails fd = tn.Tag as FileDetails;

                if (fd==null)
                {
                    return;
                }

                switch (fd.FileType)
                {
                    case "THR":
                        TargetBox = rtfThreadFile;

                        if (tn.Nodes.Count == 0)
                        {
                            FilesToTree ftt = new FilesToTree();
                            ControlFolderFinder cff = new ControlFolderFinder();
                            string newworkingfolder = cff.GetControlFolderValue(fd.FullFileName);

                            if (Directory.Exists(newworkingfolder))
                            {
                                ftt.PopulateTreeViewWithFilesOfType(newworkingfolder,this.txtIntRegExFilter.Text, this.tvFiles, "Interfaces", "TYPE=INTERFACE", "INT", tn);
                                ftt.PopulateTreeViewWithFilesOfType(newworkingfolder, this.txtCtrlRegExFilter.Text, this.tvFiles, "Command Files", "TYPE=,FORMAT=", "CMD", tn);
                            }
                        }
                        break;

                    case "INT":
                        TargetBox = rtfControlFile;
                        TargetLabel = this.LblControlFile;
                        break;

                    case "CMD":
                        TargetBox = RtfSubFile;
                        TargetLabel = this.lblSubControlFile;
                        break;
                    default:
                        break;
                }

                if (File.Exists(fd.FullFileName))
                {
                    LoadManifest.LoadAndFormatManifestFile lmfb = new LoadManifest.LoadAndFormatManifestFile();
                    TargetBox.Tag = fd;
                    TargetLabel.Text = fd.FullFileName;

                    lmfb.loadfile(fd.FullFileName);
                    TargetBox.Rtf = lmfb.GetRtf();

                }
                else
                {
                    MessageBox.Show("File not found: " + fd.FullFileName);
                }
            }
            catch (Exception)
            {

            }
        }

        private void cmdXpathGo_Click(object sender, EventArgs e)
        {
            try
            {
                XmlProcessor xml = new XmlProcessor();
                this.txtXmlResult.Text = xml.ApplyXPathToXml(this.txtXmlFile.Text, this.TxtXpath.Text);
            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }

        }

        private void rtfSearchResults_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                _doNotProcessTextChange = true;
                RichTextControlManager rtcm = new RichTextControlManager();
                string lineContents = rtcm.GetLineText(rtfSearchResults, rtcm.GetCurrentLine(rtfSearchResults));
                string[] lineResults = StringSplitter.SplitStringByTab(lineContents);
                string lineNumber = lineResults[0].Replace("Line ", "");
                rtcm.JumpToLine(this.rtfControlFile, int.Parse(lineNumber) - 1);
                rtcm.HighlightLine(this.rtfControlFile, int.Parse(lineNumber) - 1);
                _doNotProcessTextChange = false;
            }
            catch (Exception)
            {
                //Dont worry
            }
        }

        private void JumpToLine(RichTextBox richTextBox, int GotoLine)
        {
            if (GotoLine < 1 || GotoLine > richTextBox.Lines.Length)
            {
                MessageBox.Show("Line number out of range.");
                return;
            }
            int charIndex = richTextBox.GetFirstCharIndexFromLine(GotoLine - 1);
            richTextBox.Select(charIndex, 0);
            richTextBox.ScrollToCaret();
        }
        private void FrmManifestViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryHelper.WriteRegistry("WorkingFolder", this.SourceWorkingFolder);
            RegistryHelper.WriteRegistry("RegExPattern", this.txtSearch.Text);
            RegistryHelper.WriteRegistry("XmlFile", this.txtXmlFile.Text);
            RegistryHelper.WriteRegistry("XmlPath", this.TxtXpath.Text);
            RegistryHelper.WriteRegistry("XmlResult", this.txtXmlResult.Text);

            RegistryHelper.WriteRegistry("CtrlRegExFilter", this.txtCtrlRegExFilter.Text);
            RegistryHelper.WriteRegistry("IntRegExFilter", this.txtIntRegExFilter.Text);

        }

        private void tmrLineIndicator_Tick(object sender, EventArgs e)
        {
            RichTextControlManager rtcm = new RichTextControlManager();
            this.lblControlFileStats.Text = $"Line {rtcm.GetCurrentLine(this.rtfControlFile)}";
            this.txtWorkingFolder.Text = SourceWorkingFolder;
        }

        private RichTextBox GetMenuItemSourceRtb(object sender)
        {
            ToolStripItem menuItem = sender as ToolStripItem;
            ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;
            Control sourceControl = menu.SourceControl;
            RichTextBox rtb = menu.SourceControl as RichTextBox;

            return rtb;
        }

        private void saveWithBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {


            RichTextBox rtb = GetMenuItemSourceRtb(sender);

            if (rtb != null)
            {
                MessageBox.Show($"Context menu opened by: {rtb.Name}");
                FileDetails fd = rtb.Tag as FileDetails;
                FileSaver.SaveFile(fd.FilePath, fd.FileName, rtb.Text.Replace("\n", "\r\n"));
            }
        }

        private void newCommandFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile f = new NewFile();
            f.ShowDialog(this);

            if (f.DialogResult == DialogResult.Cancel)
            {
                return;
            }
            string newFileName = f.fileName;
            FileDetails fd = GetFileDetails(this.rtfControlFile);
            CreateFile cf = new CreateFile() { TextOveride = f.CommandFileText, WorkFolder = fd.FilePath, FileType = f.FileType, NewFileName = $"{f.fileName}.txt" };
            try
            {
                cf.MakeFile();
                FilesToTree ftt = new FilesToTree();

                if (this.SourceWorkingFolder != "")
                {
                    this.tvFiles.Nodes.Clear();
                    ftt.PopulateTreeViewWithFilesOfType(this.SourceWorkingFolder, this.txtIntRegExFilter.Text,this.tvFiles, "Threads", "TYPE=THREAD", "THR");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                f = null;
            }
        }

        private void cmdResultsClear_Click(object sender, EventArgs e)
        {
            this.rtfSearchResults.Clear();
        }



        private void LoadSubFile(RichTextBox rtb)
        {
            string possibleFileSelected = rtb.SelectedText;
            openSubFile(possibleFileSelected);
        }


        private void loadControlFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = GetMenuItemSourceRtb(sender);
            LoadSubFile(rtb);
        }

        public void AddToFormatQueue(RichTextBox rtb)
        {
            if (_doNotProcessTextChange)
            {
                return;
            }
            try
            {
                this.formatQueue.Add(rtb.Name, rtb);
            }
            catch (Exception)
            {

                //not a problem 
            }
        }


        private void rtfControlFile_TextChanged(object sender, EventArgs e)
        {
            AddToFormatQueue(rtfControlFile);
        }

        private void rtfThreadFile_TextChanged(object sender, EventArgs e)
        {
            AddToFormatQueue(rtfThreadFile);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            this.Text = this.formatQueue.Count.ToString();

            _doNotProcessTextChange = true;
            LoadManifest.LoadAndFormatManifestFile lmfb = new LoadManifest.LoadAndFormatManifestFile();
            while (this.formatQueue.Count != 0)
            {

                var item = this.formatQueue.First();
                this.Text = item.Value.Name;
                lmfb.refreshRTF(item.Value);
                formatQueue.Remove(item.Key);

            }
            _doNotProcessTextChange = false;
        }

        private void tvFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void rtfSearchResults_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void CmFileMgt_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cmdClearTreeView_Click(object sender, EventArgs e)
        {
            FilesToTree ftt = new FilesToTree();
                this.tvFiles.Nodes.Clear();
                ftt.PopulateTreeViewWithFilesOfType(SourceWorkingFolder, ".*", this.tvFiles, "Threads", "TYPE=THREAD", "THR");
          
        }

        private void lblRegExFilter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RtfSubFile.WordWrap = !this.RtfSubFile.WordWrap;
        }
    }
}


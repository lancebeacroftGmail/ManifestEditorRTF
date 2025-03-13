
namespace ManifestVieweRTF
{
    partial class FrmManifestViewer
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
            this.components = new System.ComponentModel.Container();
            this.CmFileMgt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadControlFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCommandFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWithBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.pnRTF = new System.Windows.Forms.Panel();
            this.LblControlFile = new System.Windows.Forms.Label();
            this.lblControlFileStats = new System.Windows.Forms.Label();
            this.rtfControlFile = new System.Windows.Forms.RichTextBox();
            this.lblFormatStatus = new System.Windows.Forms.Label();
            this.PnlSearchResults = new System.Windows.Forms.Panel();
            this.cmdResultsClear = new System.Windows.Forms.Button();
            this.rtfSearchResults = new System.Windows.Forms.RichTextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHControl = new System.Windows.Forms.Label();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.lblHSlider = new System.Windows.Forms.Label();
            this.lblVSlider = new System.Windows.Forms.Label();
            this.LblTreeView = new System.Windows.Forms.Label();
            this.PnlDocTree = new System.Windows.Forms.Panel();
            this.txtCtrlRegExFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdClearTreeView = new System.Windows.Forms.Button();
            this.txtIntRegExFilter = new System.Windows.Forms.TextBox();
            this.lblRegExFilter = new System.Windows.Forms.Label();
            this.pnlXpath = new System.Windows.Forms.Panel();
            this.TxtXpath = new System.Windows.Forms.TextBox();
            this.cmdXpathGo = new System.Windows.Forms.Button();
            this.lblXpath = new System.Windows.Forms.Label();
            this.txtXmlResult = new System.Windows.Forms.TextBox();
            this.txtXmlFile = new System.Windows.Forms.TextBox();
            this.lblXmlFileName = new System.Windows.Forms.Label();
            this.lblXpathHSlider = new System.Windows.Forms.Label();
            this.lblXmlVSlider = new System.Windows.Forms.Label();
            this.tmrLineIndicator = new System.Windows.Forms.Timer(this.components);
            this.txtWorkingFolder = new System.Windows.Forms.TextBox();
            this.lblWorkingFolder = new System.Windows.Forms.Label();
            this.PnlSub = new System.Windows.Forms.Panel();
            this.txtCtrlww = new System.Windows.Forms.Button();
            this.lblSubControlFile = new System.Windows.Forms.Label();
            this.RtfSubFile = new System.Windows.Forms.RichTextBox();
            this.pnlThread = new System.Windows.Forms.Panel();
            this.lblThread = new System.Windows.Forms.Label();
            this.rtfThreadFile = new System.Windows.Forms.RichTextBox();
            this.lblHThreadAndControl = new System.Windows.Forms.Label();
            this.pnlThreadAndControl = new System.Windows.Forms.Panel();
            this.onDemandFormat = new System.Windows.Forms.Timer(this.components);
            this.CmFileMgt.SuspendLayout();
            this.cmMenu.SuspendLayout();
            this.PnlMain.SuspendLayout();
            this.pnRTF.SuspendLayout();
            this.PnlSearchResults.SuspendLayout();
            this.PnlDocTree.SuspendLayout();
            this.pnlXpath.SuspendLayout();
            this.PnlSub.SuspendLayout();
            this.pnlThread.SuspendLayout();
            this.pnlThreadAndControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmFileMgt
            // 
            this.CmFileMgt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadControlFileToolStripMenuItem,
            this.newCommandFileToolStripMenuItem,
            this.saveWithBackupToolStripMenuItem});
            this.CmFileMgt.Name = "CmFileMgt";
            this.CmFileMgt.Size = new System.Drawing.Size(176, 70);
            // 
            // loadControlFileToolStripMenuItem
            // 
            this.loadControlFileToolStripMenuItem.Name = "loadControlFileToolStripMenuItem";
            this.loadControlFileToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.loadControlFileToolStripMenuItem.Text = "Load Control File";
            this.loadControlFileToolStripMenuItem.Click += new System.EventHandler(this.loadControlFileToolStripMenuItem_Click);
            // 
            // newCommandFileToolStripMenuItem
            // 
            this.newCommandFileToolStripMenuItem.Name = "newCommandFileToolStripMenuItem";
            this.newCommandFileToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newCommandFileToolStripMenuItem.Text = "New File";
            this.newCommandFileToolStripMenuItem.Click += new System.EventHandler(this.newCommandFileToolStripMenuItem_Click);
            // 
            // saveWithBackupToolStripMenuItem
            // 
            this.saveWithBackupToolStripMenuItem.Name = "saveWithBackupToolStripMenuItem";
            this.saveWithBackupToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveWithBackupToolStripMenuItem.Text = "Save with Backup...";
            this.saveWithBackupToolStripMenuItem.Click += new System.EventHandler(this.saveWithBackupToolStripMenuItem_Click);
            // 
            // cmMenu
            // 
            this.cmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem});
            this.cmMenu.Name = "cmMenu";
            this.cmMenu.Size = new System.Drawing.Size(155, 26);
            this.cmMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmMenu_Opening);
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open Directory";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
            // 
            // PnlMain
            // 
            this.PnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlMain.Controls.Add(this.pnRTF);
            this.PnlMain.Controls.Add(this.PnlSearchResults);
            this.PnlMain.Controls.Add(this.label1);
            this.PnlMain.Controls.Add(this.lblHControl);
            this.PnlMain.Location = new System.Drawing.Point(173, 41);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1021, 265);
            this.PnlMain.TabIndex = 6;
            // 
            // pnRTF
            // 
            this.pnRTF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRTF.Controls.Add(this.LblControlFile);
            this.pnRTF.Controls.Add(this.lblControlFileStats);
            this.pnRTF.Controls.Add(this.rtfControlFile);
            this.pnRTF.Controls.Add(this.lblFormatStatus);
            this.pnRTF.Location = new System.Drawing.Point(3, 3);
            this.pnRTF.Name = "pnRTF";
            this.pnRTF.Size = new System.Drawing.Size(652, 260);
            this.pnRTF.TabIndex = 16;
            // 
            // LblControlFile
            // 
            this.LblControlFile.AutoSize = true;
            this.LblControlFile.Location = new System.Drawing.Point(5, 9);
            this.LblControlFile.Name = "LblControlFile";
            this.LblControlFile.Size = new System.Drawing.Size(185, 13);
            this.LblControlFile.TabIndex = 10;
            this.LblControlFile.Text = "Select a document from the Doc Tree";
            this.LblControlFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblControlFileStats
            // 
            this.lblControlFileStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblControlFileStats.AutoSize = true;
            this.lblControlFileStats.Location = new System.Drawing.Point(601, 9);
            this.lblControlFileStats.Name = "lblControlFileStats";
            this.lblControlFileStats.Size = new System.Drawing.Size(36, 13);
            this.lblControlFileStats.TabIndex = 15;
            this.lblControlFileStats.Text = "Line 0";
            this.lblControlFileStats.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtfControlFile
            // 
            this.rtfControlFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfControlFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfControlFile.ContextMenuStrip = this.CmFileMgt;
            this.rtfControlFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfControlFile.Location = new System.Drawing.Point(3, 30);
            this.rtfControlFile.Name = "rtfControlFile";
            this.rtfControlFile.Size = new System.Drawing.Size(646, 225);
            this.rtfControlFile.TabIndex = 1;
            this.rtfControlFile.Text = "";
            this.rtfControlFile.WordWrap = false;
            this.rtfControlFile.TextChanged += new System.EventHandler(this.rtfControlFile_TextChanged);
            // 
            // lblFormatStatus
            // 
            this.lblFormatStatus.AutoSize = true;
            this.lblFormatStatus.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblFormatStatus.Location = new System.Drawing.Point(196, 9);
            this.lblFormatStatus.Name = "lblFormatStatus";
            this.lblFormatStatus.Size = new System.Drawing.Size(23, 17);
            this.lblFormatStatus.TabIndex = 8;
            this.lblFormatStatus.Text = "J";
            this.lblFormatStatus.Visible = false;
            // 
            // PnlSearchResults
            // 
            this.PnlSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSearchResults.Controls.Add(this.cmdResultsClear);
            this.PnlSearchResults.Controls.Add(this.rtfSearchResults);
            this.PnlSearchResults.Controls.Add(this.txtSearch);
            this.PnlSearchResults.Controls.Add(this.cmdSearch);
            this.PnlSearchResults.Location = new System.Drawing.Point(661, 3);
            this.PnlSearchResults.Name = "PnlSearchResults";
            this.PnlSearchResults.Size = new System.Drawing.Size(358, 260);
            this.PnlSearchResults.TabIndex = 12;
            // 
            // cmdResultsClear
            // 
            this.cmdResultsClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdResultsClear.Location = new System.Drawing.Point(309, 5);
            this.cmdResultsClear.Name = "cmdResultsClear";
            this.cmdResultsClear.Size = new System.Drawing.Size(46, 21);
            this.cmdResultsClear.TabIndex = 9;
            this.cmdResultsClear.Text = "X";
            this.cmdResultsClear.UseVisualStyleBackColor = true;
            this.cmdResultsClear.Click += new System.EventHandler(this.cmdResultsClear_Click);
            // 
            // rtfSearchResults
            // 
            this.rtfSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfSearchResults.ContextMenuStrip = this.CmFileMgt;
            this.rtfSearchResults.Location = new System.Drawing.Point(3, 30);
            this.rtfSearchResults.Name = "rtfSearchResults";
            this.rtfSearchResults.Size = new System.Drawing.Size(352, 225);
            this.rtfSearchResults.TabIndex = 8;
            this.rtfSearchResults.Text = "";
            this.rtfSearchResults.WordWrap = false;
            this.rtfSearchResults.TextChanged += new System.EventHandler(this.rtfSearchResults_TextChanged);
            this.rtfSearchResults.DoubleClick += new System.EventHandler(this.rtfSearchResults_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(3, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearch.Location = new System.Drawing.Point(250, 5);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(57, 21);
            this.cmdSearch.TabIndex = 7;
            this.cmdSearch.Text = "Find...";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHControl
            // 
            this.lblHControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHControl.BackColor = System.Drawing.Color.Aqua;
            this.lblHControl.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblHControl.Location = new System.Drawing.Point(629, 4);
            this.lblHControl.Name = "lblHControl";
            this.lblHControl.Size = new System.Drawing.Size(50, 259);
            this.lblHControl.TabIndex = 13;
            this.lblHControl.Text = " ";
            // 
            // tvFiles
            // 
            this.tvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFiles.ContextMenuStrip = this.cmMenu;
            this.tvFiles.Location = new System.Drawing.Point(1, 108);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(156, 518);
            this.tvFiles.TabIndex = 8;
            this.tvFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFiles_AfterSelect);
            this.tvFiles.DoubleClick += new System.EventHandler(this.tvFiles_DoubleClick);
            // 
            // lblHSlider
            // 
            this.lblHSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHSlider.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblHSlider.Location = new System.Drawing.Point(164, 41);
            this.lblHSlider.Name = "lblHSlider";
            this.lblHSlider.Size = new System.Drawing.Size(11, 629);
            this.lblHSlider.TabIndex = 9;
            this.lblHSlider.Text = " ";
            // 
            // lblVSlider
            // 
            this.lblVSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVSlider.BackColor = System.Drawing.Color.Yellow;
            this.lblVSlider.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.lblVSlider.Location = new System.Drawing.Point(175, 298);
            this.lblVSlider.Name = "lblVSlider";
            this.lblVSlider.Size = new System.Drawing.Size(1017, 14);
            this.lblVSlider.TabIndex = 10;
            this.lblVSlider.Text = " ";
            // 
            // LblTreeView
            // 
            this.LblTreeView.Location = new System.Drawing.Point(0, -2);
            this.LblTreeView.Name = "LblTreeView";
            this.LblTreeView.Size = new System.Drawing.Size(58, 24);
            this.LblTreeView.TabIndex = 11;
            this.LblTreeView.Text = "Doc Tree";
            this.LblTreeView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlDocTree
            // 
            this.PnlDocTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PnlDocTree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlDocTree.Controls.Add(this.txtCtrlRegExFilter);
            this.PnlDocTree.Controls.Add(this.label2);
            this.PnlDocTree.Controls.Add(this.cmdClearTreeView);
            this.PnlDocTree.Controls.Add(this.tvFiles);
            this.PnlDocTree.Controls.Add(this.LblTreeView);
            this.PnlDocTree.Controls.Add(this.txtIntRegExFilter);
            this.PnlDocTree.Controls.Add(this.lblRegExFilter);
            this.PnlDocTree.Location = new System.Drawing.Point(3, 41);
            this.PnlDocTree.Name = "PnlDocTree";
            this.PnlDocTree.Size = new System.Drawing.Size(161, 633);
            this.PnlDocTree.TabIndex = 12;
            // 
            // txtCtrlRegExFilter
            // 
            this.txtCtrlRegExFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCtrlRegExFilter.Location = new System.Drawing.Point(3, 85);
            this.txtCtrlRegExFilter.Name = "txtCtrlRegExFilter";
            this.txtCtrlRegExFilter.Size = new System.Drawing.Size(154, 20);
            this.txtCtrlRegExFilter.TabIndex = 26;
            this.txtCtrlRegExFilter.Text = ".*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "RegEx Ctrl Filter";
            // 
            // cmdClearTreeView
            // 
            this.cmdClearTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClearTreeView.Location = new System.Drawing.Point(118, 5);
            this.cmdClearTreeView.Name = "cmdClearTreeView";
            this.cmdClearTreeView.Size = new System.Drawing.Size(35, 20);
            this.cmdClearTreeView.TabIndex = 25;
            this.cmdClearTreeView.Text = "X";
            this.cmdClearTreeView.UseVisualStyleBackColor = true;
            this.cmdClearTreeView.Click += new System.EventHandler(this.cmdClearTreeView_Click);
            // 
            // txtIntRegExFilter
            // 
            this.txtIntRegExFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIntRegExFilter.Location = new System.Drawing.Point(3, 46);
            this.txtIntRegExFilter.Name = "txtIntRegExFilter";
            this.txtIntRegExFilter.Size = new System.Drawing.Size(154, 20);
            this.txtIntRegExFilter.TabIndex = 22;
            this.txtIntRegExFilter.Text = ".*";
            // 
            // lblRegExFilter
            // 
            this.lblRegExFilter.AutoSize = true;
            this.lblRegExFilter.Location = new System.Drawing.Point(1, 30);
            this.lblRegExFilter.Name = "lblRegExFilter";
            this.lblRegExFilter.Size = new System.Drawing.Size(79, 13);
            this.lblRegExFilter.TabIndex = 23;
            this.lblRegExFilter.Text = "RegEx Int Filter";
            this.lblRegExFilter.Click += new System.EventHandler(this.lblRegExFilter_Click);
            // 
            // pnlXpath
            // 
            this.pnlXpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlXpath.Controls.Add(this.TxtXpath);
            this.pnlXpath.Controls.Add(this.cmdXpathGo);
            this.pnlXpath.Controls.Add(this.lblXpath);
            this.pnlXpath.Controls.Add(this.txtXmlResult);
            this.pnlXpath.Controls.Add(this.txtXmlFile);
            this.pnlXpath.Controls.Add(this.lblXmlFileName);
            this.pnlXpath.Controls.Add(this.lblXpathHSlider);
            this.pnlXpath.Location = new System.Drawing.Point(173, 499);
            this.pnlXpath.Name = "pnlXpath";
            this.pnlXpath.Size = new System.Drawing.Size(1021, 176);
            this.pnlXpath.TabIndex = 13;
            // 
            // TxtXpath
            // 
            this.TxtXpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtXpath.Location = new System.Drawing.Point(525, 8);
            this.TxtXpath.Name = "TxtXpath";
            this.TxtXpath.Size = new System.Drawing.Size(445, 20);
            this.TxtXpath.TabIndex = 3;
            // 
            // cmdXpathGo
            // 
            this.cmdXpathGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdXpathGo.Location = new System.Drawing.Point(969, 8);
            this.cmdXpathGo.Name = "cmdXpathGo";
            this.cmdXpathGo.Size = new System.Drawing.Size(41, 20);
            this.cmdXpathGo.TabIndex = 15;
            this.cmdXpathGo.Text = ">";
            this.cmdXpathGo.UseVisualStyleBackColor = true;
            this.cmdXpathGo.Click += new System.EventHandler(this.cmdXpathGo_Click);
            // 
            // lblXpath
            // 
            this.lblXpath.AutoSize = true;
            this.lblXpath.Location = new System.Drawing.Point(476, 12);
            this.lblXpath.Name = "lblXpath";
            this.lblXpath.Size = new System.Drawing.Size(51, 13);
            this.lblXpath.TabIndex = 4;
            this.lblXpath.Text = "XML File:";
            // 
            // txtXmlResult
            // 
            this.txtXmlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXmlResult.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXmlResult.Location = new System.Drawing.Point(7, 34);
            this.txtXmlResult.Multiline = true;
            this.txtXmlResult.Name = "txtXmlResult";
            this.txtXmlResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXmlResult.Size = new System.Drawing.Size(1004, 137);
            this.txtXmlResult.TabIndex = 2;
            this.txtXmlResult.WordWrap = false;
            // 
            // txtXmlFile
            // 
            this.txtXmlFile.Location = new System.Drawing.Point(61, 8);
            this.txtXmlFile.Name = "txtXmlFile";
            this.txtXmlFile.Size = new System.Drawing.Size(400, 20);
            this.txtXmlFile.TabIndex = 1;
            // 
            // lblXmlFileName
            // 
            this.lblXmlFileName.AutoSize = true;
            this.lblXmlFileName.Location = new System.Drawing.Point(4, 11);
            this.lblXmlFileName.Name = "lblXmlFileName";
            this.lblXmlFileName.Size = new System.Drawing.Size(51, 13);
            this.lblXmlFileName.TabIndex = 0;
            this.lblXmlFileName.Text = "XML File:";
            // 
            // lblXpathHSlider
            // 
            this.lblXpathHSlider.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblXpathHSlider.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblXpathHSlider.Location = new System.Drawing.Point(450, 8);
            this.lblXpathHSlider.Name = "lblXpathHSlider";
            this.lblXpathHSlider.Size = new System.Drawing.Size(15, 20);
            this.lblXpathHSlider.TabIndex = 14;
            this.lblXpathHSlider.Text = " ";
            // 
            // lblXmlVSlider
            // 
            this.lblXmlVSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblXmlVSlider.BackColor = System.Drawing.Color.Navy;
            this.lblXmlVSlider.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.lblXmlVSlider.Location = new System.Drawing.Point(173, 490);
            this.lblXmlVSlider.Name = "lblXmlVSlider";
            this.lblXmlVSlider.Size = new System.Drawing.Size(1021, 20);
            this.lblXmlVSlider.TabIndex = 14;
            this.lblXmlVSlider.Text = " ";
            // 
            // tmrLineIndicator
            // 
            this.tmrLineIndicator.Enabled = true;
            this.tmrLineIndicator.Interval = 200;
            this.tmrLineIndicator.Tick += new System.EventHandler(this.tmrLineIndicator_Tick);
            // 
            // txtWorkingFolder
            // 
            this.txtWorkingFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingFolder.Location = new System.Drawing.Point(88, 13);
            this.txtWorkingFolder.Name = "txtWorkingFolder";
            this.txtWorkingFolder.Size = new System.Drawing.Size(716, 20);
            this.txtWorkingFolder.TabIndex = 20;
            // 
            // lblWorkingFolder
            // 
            this.lblWorkingFolder.AutoSize = true;
            this.lblWorkingFolder.Location = new System.Drawing.Point(3, 16);
            this.lblWorkingFolder.Name = "lblWorkingFolder";
            this.lblWorkingFolder.Size = new System.Drawing.Size(79, 13);
            this.lblWorkingFolder.TabIndex = 21;
            this.lblWorkingFolder.Text = "Working Folder";
            // 
            // PnlSub
            // 
            this.PnlSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlSub.Controls.Add(this.txtCtrlww);
            this.PnlSub.Controls.Add(this.lblSubControlFile);
            this.PnlSub.Controls.Add(this.RtfSubFile);
            this.PnlSub.Location = new System.Drawing.Point(263, 0);
            this.PnlSub.Name = "PnlSub";
            this.PnlSub.Size = new System.Drawing.Size(755, 178);
            this.PnlSub.TabIndex = 7;
            // 
            // txtCtrlww
            // 
            this.txtCtrlww.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCtrlww.Location = new System.Drawing.Point(639, 3);
            this.txtCtrlww.Name = "txtCtrlww";
            this.txtCtrlww.Size = new System.Drawing.Size(109, 19);
            this.txtCtrlww.TabIndex = 4;
            this.txtCtrlww.Text = "text wrap...";
            this.txtCtrlww.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtCtrlww.UseVisualStyleBackColor = true;
            this.txtCtrlww.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSubControlFile
            // 
            this.lblSubControlFile.AutoSize = true;
            this.lblSubControlFile.Location = new System.Drawing.Point(3, 5);
            this.lblSubControlFile.Name = "lblSubControlFile";
            this.lblSubControlFile.Size = new System.Drawing.Size(251, 13);
            this.lblSubControlFile.TabIndex = 3;
            this.lblSubControlFile.Text = "...double click on control file to see sub file contents";
            this.lblSubControlFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RtfSubFile
            // 
            this.RtfSubFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtfSubFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtfSubFile.ContextMenuStrip = this.CmFileMgt;
            this.RtfSubFile.Location = new System.Drawing.Point(3, 28);
            this.RtfSubFile.Name = "RtfSubFile";
            this.RtfSubFile.Size = new System.Drawing.Size(745, 143);
            this.RtfSubFile.TabIndex = 1;
            this.RtfSubFile.Text = "";
            this.RtfSubFile.WordWrap = false;
            this.RtfSubFile.TextChanged += new System.EventHandler(this.RtfSubFile_TextChanged);
            // 
            // pnlThread
            // 
            this.pnlThread.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThread.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlThread.Controls.Add(this.lblThread);
            this.pnlThread.Controls.Add(this.rtfThreadFile);
            this.pnlThread.Location = new System.Drawing.Point(0, 0);
            this.pnlThread.Name = "pnlThread";
            this.pnlThread.Size = new System.Drawing.Size(246, 178);
            this.pnlThread.TabIndex = 18;
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Location = new System.Drawing.Point(8, 5);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(60, 13);
            this.lblThread.TabIndex = 3;
            this.lblThread.Text = "Thread File";
            this.lblThread.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtfThreadFile
            // 
            this.rtfThreadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfThreadFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfThreadFile.ContextMenuStrip = this.CmFileMgt;
            this.rtfThreadFile.Location = new System.Drawing.Point(6, 28);
            this.rtfThreadFile.Name = "rtfThreadFile";
            this.rtfThreadFile.Size = new System.Drawing.Size(233, 143);
            this.rtfThreadFile.TabIndex = 1;
            this.rtfThreadFile.Text = "";
            this.rtfThreadFile.WordWrap = false;
            this.rtfThreadFile.TextChanged += new System.EventHandler(this.rtfThreadFile_TextChanged);
            // 
            // lblHThreadAndControl
            // 
            this.lblHThreadAndControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHThreadAndControl.BackColor = System.Drawing.Color.Red;
            this.lblHThreadAndControl.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.lblHThreadAndControl.Location = new System.Drawing.Point(247, 0);
            this.lblHThreadAndControl.Name = "lblHThreadAndControl";
            this.lblHThreadAndControl.Size = new System.Drawing.Size(10, 178);
            this.lblHThreadAndControl.TabIndex = 17;
            this.lblHThreadAndControl.Text = " ";
            // 
            // pnlThreadAndControl
            // 
            this.pnlThreadAndControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThreadAndControl.Controls.Add(this.pnlThread);
            this.pnlThreadAndControl.Controls.Add(this.PnlSub);
            this.pnlThreadAndControl.Controls.Add(this.lblHThreadAndControl);
            this.pnlThreadAndControl.Location = new System.Drawing.Point(173, 312);
            this.pnlThreadAndControl.Name = "pnlThreadAndControl";
            this.pnlThreadAndControl.Size = new System.Drawing.Size(1021, 181);
            this.pnlThreadAndControl.TabIndex = 19;
            // 
            // onDemandFormat
            // 
            this.onDemandFormat.Enabled = true;
            this.onDemandFormat.Interval = 2000;
            this.onDemandFormat.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmManifestViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 679);
            this.Controls.Add(this.lblWorkingFolder);
            this.Controls.Add(this.txtWorkingFolder);
            this.Controls.Add(this.pnlThreadAndControl);
            this.Controls.Add(this.pnlXpath);
            this.Controls.Add(this.PnlDocTree);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.lblXmlVSlider);
            this.Controls.Add(this.lblVSlider);
            this.Controls.Add(this.lblHSlider);
            this.KeyPreview = true;
            this.Name = "FrmManifestViewer";
            this.Text = "Manifest Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManifestViewer_FormClosing);
            this.Load += new System.EventHandler(this.FrmManifestViewer_Load);
            this.CmFileMgt.ResumeLayout(false);
            this.cmMenu.ResumeLayout(false);
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.pnRTF.ResumeLayout(false);
            this.pnRTF.PerformLayout();
            this.PnlSearchResults.ResumeLayout(false);
            this.PnlSearchResults.PerformLayout();
            this.PnlDocTree.ResumeLayout(false);
            this.PnlDocTree.PerformLayout();
            this.pnlXpath.ResumeLayout(false);
            this.pnlXpath.PerformLayout();
            this.PnlSub.ResumeLayout(false);
            this.PnlSub.PerformLayout();
            this.pnlThread.ResumeLayout(false);
            this.pnlThread.PerformLayout();
            this.pnlThreadAndControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmMenu;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.RichTextBox rtfControlFile;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFormatStatus;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.Label lblHSlider;
        private System.Windows.Forms.Label lblVSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTreeView;
        private System.Windows.Forms.Panel PnlDocTree;
        private System.Windows.Forms.Label LblControlFile;
        private System.Windows.Forms.Panel PnlSearchResults;
        private System.Windows.Forms.Label lblHControl;
        private System.Windows.Forms.RichTextBox rtfSearchResults;
        private System.Windows.Forms.Panel pnlXpath;
        private System.Windows.Forms.Label lblXpathHSlider;
        private System.Windows.Forms.Label lblXpath;
        private System.Windows.Forms.TextBox TxtXpath;
        private System.Windows.Forms.TextBox txtXmlResult;
        private System.Windows.Forms.TextBox txtXmlFile;
        private System.Windows.Forms.Label lblXmlFileName;
        private System.Windows.Forms.Label lblXmlVSlider;
        private System.Windows.Forms.Button cmdXpathGo;
        private System.Windows.Forms.Timer tmrLineIndicator;
        private System.Windows.Forms.ContextMenuStrip CmFileMgt;
        private System.Windows.Forms.ToolStripMenuItem saveWithBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCommandFileToolStripMenuItem;
        private System.Windows.Forms.Button cmdResultsClear;
        private System.Windows.Forms.Label lblControlFileStats;
        private System.Windows.Forms.Panel pnRTF;
        private System.Windows.Forms.TextBox txtWorkingFolder;
        private System.Windows.Forms.Label lblWorkingFolder;
        private System.Windows.Forms.Panel PnlSub;
        private System.Windows.Forms.Label lblSubControlFile;
        private System.Windows.Forms.RichTextBox RtfSubFile;
        private System.Windows.Forms.Panel pnlThread;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.RichTextBox rtfThreadFile;
        private System.Windows.Forms.Label lblHThreadAndControl;
        private System.Windows.Forms.Panel pnlThreadAndControl;
        private System.Windows.Forms.ToolStripMenuItem loadControlFileToolStripMenuItem;
        private System.Windows.Forms.Timer onDemandFormat;
        private System.Windows.Forms.TextBox txtIntRegExFilter;
        private System.Windows.Forms.Label lblRegExFilter;
        private System.Windows.Forms.Button cmdClearTreeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCtrlRegExFilter;
        private System.Windows.Forms.Button txtCtrlww;
    }
}


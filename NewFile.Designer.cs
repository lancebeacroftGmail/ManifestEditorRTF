
using System;

namespace ManifestVieweRTF
{
    partial class NewFile
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
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.tmrValidate = new System.Windows.Forms.Timer(this.components);
            this.rbInterface = new System.Windows.Forms.RadioButton();
            this.rbCommand = new System.Windows.Forms.RadioButton();
            this.cmbCommandFileTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlCommandFile = new System.Windows.Forms.Panel();
            this.lblCommandFiletext = new System.Windows.Forms.Label();
            this.txtCommandFileText = new System.Windows.Forms.TextBox();
            this.PnlCommandFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOk.Location = new System.Drawing.Point(384, 451);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 0;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(478, 450);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(15, 27);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(535, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // tmrValidate
            // 
            this.tmrValidate.Enabled = true;
            this.tmrValidate.Tick += new System.EventHandler(this.tmrValidate_Tick);
            // 
            // rbInterface
            // 
            this.rbInterface.AutoSize = true;
            this.rbInterface.Checked = true;
            this.rbInterface.Location = new System.Drawing.Point(15, 53);
            this.rbInterface.Name = "rbInterface";
            this.rbInterface.Size = new System.Drawing.Size(67, 17);
            this.rbInterface.TabIndex = 4;
            this.rbInterface.TabStop = true;
            this.rbInterface.Text = "Interface";
            this.rbInterface.UseVisualStyleBackColor = true;
            this.rbInterface.Click += new System.EventHandler(this.RadioButtons_Clicked);
            // 
            // rbCommand
            // 
            this.rbCommand.AutoSize = true;
            this.rbCommand.Location = new System.Drawing.Point(88, 53);
            this.rbCommand.Name = "rbCommand";
            this.rbCommand.Size = new System.Drawing.Size(72, 17);
            this.rbCommand.TabIndex = 5;
            this.rbCommand.Text = "Command";
            this.rbCommand.UseVisualStyleBackColor = true;
            this.rbCommand.CheckedChanged += new System.EventHandler(this.rbCommand_CheckedChanged);
            this.rbCommand.Click += new System.EventHandler(this.RadioButtons_Clicked);
            // 
            // cmbCommandFileTypes
            // 
            this.cmbCommandFileTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCommandFileTypes.DisplayMember = "Name";
            this.cmbCommandFileTypes.FormattingEnabled = true;
            this.cmbCommandFileTypes.Location = new System.Drawing.Point(3, 16);
            this.cmbCommandFileTypes.Name = "cmbCommandFileTypes";
            this.cmbCommandFileTypes.Size = new System.Drawing.Size(532, 21);
            this.cmbCommandFileTypes.TabIndex = 6;
            this.cmbCommandFileTypes.SelectedIndexChanged += new System.EventHandler(this.cmbCommandFileTypes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Command Template";
            // 
            // PnlCommandFile
            // 
            this.PnlCommandFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCommandFile.Controls.Add(this.lblCommandFiletext);
            this.PnlCommandFile.Controls.Add(this.txtCommandFileText);
            this.PnlCommandFile.Controls.Add(this.cmbCommandFileTypes);
            this.PnlCommandFile.Controls.Add(this.label2);
            this.PnlCommandFile.Enabled = false;
            this.PnlCommandFile.Location = new System.Drawing.Point(15, 76);
            this.PnlCommandFile.Name = "PnlCommandFile";
            this.PnlCommandFile.Size = new System.Drawing.Size(539, 362);
            this.PnlCommandFile.TabIndex = 8;
            // 
            // lblCommandFiletext
            // 
            this.lblCommandFiletext.AutoSize = true;
            this.lblCommandFiletext.Location = new System.Drawing.Point(3, 46);
            this.lblCommandFiletext.Name = "lblCommandFiletext";
            this.lblCommandFiletext.Size = new System.Drawing.Size(101, 13);
            this.lblCommandFiletext.TabIndex = 9;
            this.lblCommandFiletext.Text = "Command Template";
            // 
            // txtCommandFileText
            // 
            this.txtCommandFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandFileText.Location = new System.Drawing.Point(3, 62);
            this.txtCommandFileText.Multiline = true;
            this.txtCommandFileText.Name = "txtCommandFileText";
            this.txtCommandFileText.Size = new System.Drawing.Size(532, 297);
            this.txtCommandFileText.TabIndex = 8;
            // 
            // NewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(566, 484);
            this.ControlBox = false;
            this.Controls.Add(this.PnlCommandFile);
            this.Controls.Add(this.rbCommand);
            this.Controls.Add(this.rbInterface);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.Name = "NewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New file name...";
            this.Load += new System.EventHandler(this.NewFile_Load);
            this.PnlCommandFile.ResumeLayout(false);
            this.PnlCommandFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Timer tmrValidate;
        private System.Windows.Forms.RadioButton rbInterface;
        private System.Windows.Forms.RadioButton rbCommand;
        private System.Windows.Forms.ComboBox cmbCommandFileTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlCommandFile;
        private System.Windows.Forms.TextBox txtCommandFileText;
        private System.Windows.Forms.Label lblCommandFiletext;
    }
}
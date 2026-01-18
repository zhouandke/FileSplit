namespace FileSplit
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.lblSourceFileSize = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoSplitSizeInGB = new System.Windows.Forms.RadioButton();
            this.rdoSplitSizeInMB = new System.Windows.Forms.RadioButton();
            this.rdoSplitSizeInKB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.nudSplitSize = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnSelectMergeSoureFolderPath = new System.Windows.Forms.Button();
            this.txtMergeSoureFolderPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoExtractSizeInGB = new System.Windows.Forms.RadioButton();
            this.rdoExtractSizeInMB = new System.Windows.Forms.RadioButton();
            this.rdoExtractSizeInKB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoExtractOffsetInGB = new System.Windows.Forms.RadioButton();
            this.rdoExtractOffsetInMB = new System.Windows.Forms.RadioButton();
            this.rdoExtractOffsetInKB = new System.Windows.Forms.RadioButton();
            this.nudExtractSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudExtractOffset = new System.Windows.Forms.NumericUpDown();
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtTargetFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectTargetFolderPath = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitSize)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtractSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtractOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSourceFilePath
            // 
            this.txtSourceFilePath.AllowDrop = true;
            this.txtSourceFilePath.Location = new System.Drawing.Point(12, 12);
            this.txtSourceFilePath.Multiline = true;
            this.txtSourceFilePath.Name = "txtSourceFilePath";
            this.txtSourceFilePath.ReadOnly = true;
            this.txtSourceFilePath.Size = new System.Drawing.Size(1062, 64);
            this.txtSourceFilePath.TabIndex = 2;
            this.txtSourceFilePath.Text = "请拖放文件到此处";
            this.txtSourceFilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFilePath_DragDrop);
            this.txtSourceFilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFilePath_DragEnter);
            // 
            // lblSourceFileSize
            // 
            this.lblSourceFileSize.Location = new System.Drawing.Point(23, 79);
            this.lblSourceFileSize.Name = "lblSourceFileSize";
            this.lblSourceFileSize.Size = new System.Drawing.Size(79, 23);
            this.lblSourceFileSize.TabIndex = 3;
            this.lblSourceFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 146);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 216);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSplit);
            this.tabPage1.Controls.Add(this.nudSplitSize);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 187);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "分割";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoSplitSizeInGB);
            this.panel1.Controls.Add(this.rdoSplitSizeInMB);
            this.panel1.Controls.Add(this.rdoSplitSizeInKB);
            this.panel1.Location = new System.Drawing.Point(225, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 25);
            this.panel1.TabIndex = 4;
            // 
            // rdoSplitSizeInGB
            // 
            this.rdoSplitSizeInGB.AutoSize = true;
            this.rdoSplitSizeInGB.Location = new System.Drawing.Point(170, 4);
            this.rdoSplitSizeInGB.Name = "rdoSplitSizeInGB";
            this.rdoSplitSizeInGB.Size = new System.Drawing.Size(44, 19);
            this.rdoSplitSizeInGB.TabIndex = 2;
            this.rdoSplitSizeInGB.Text = "GB";
            this.rdoSplitSizeInGB.UseVisualStyleBackColor = true;
            // 
            // rdoSplitSizeInMB
            // 
            this.rdoSplitSizeInMB.AutoSize = true;
            this.rdoSplitSizeInMB.Checked = true;
            this.rdoSplitSizeInMB.Location = new System.Drawing.Point(90, 4);
            this.rdoSplitSizeInMB.Name = "rdoSplitSizeInMB";
            this.rdoSplitSizeInMB.Size = new System.Drawing.Size(44, 19);
            this.rdoSplitSizeInMB.TabIndex = 1;
            this.rdoSplitSizeInMB.TabStop = true;
            this.rdoSplitSizeInMB.Text = "MB";
            this.rdoSplitSizeInMB.UseVisualStyleBackColor = true;
            // 
            // rdoSplitSizeInKB
            // 
            this.rdoSplitSizeInKB.AutoSize = true;
            this.rdoSplitSizeInKB.Location = new System.Drawing.Point(10, 4);
            this.rdoSplitSizeInKB.Name = "rdoSplitSizeInKB";
            this.rdoSplitSizeInKB.Size = new System.Drawing.Size(44, 19);
            this.rdoSplitSizeInKB.TabIndex = 0;
            this.rdoSplitSizeInKB.Text = "KB";
            this.rdoSplitSizeInKB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "分割大小";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(9, 143);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(132, 38);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "开始";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // nudSplitSize
            // 
            this.nudSplitSize.Location = new System.Drawing.Point(100, 23);
            this.nudSplitSize.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSplitSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSplitSize.Name = "nudSplitSize";
            this.nudSplitSize.Size = new System.Drawing.Size(100, 25);
            this.nudSplitSize.TabIndex = 0;
            this.nudSplitSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSplitSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMerge);
            this.tabPage3.Controls.Add(this.btnSelectMergeSoureFolderPath);
            this.tabPage3.Controls.Add(this.txtMergeSoureFolderPath);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1054, 187);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "合并";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(9, 143);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(131, 38);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "开始";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnSelectMergeSoureFolderPath
            // 
            this.btnSelectMergeSoureFolderPath.Location = new System.Drawing.Point(9, 22);
            this.btnSelectMergeSoureFolderPath.Name = "btnSelectMergeSoureFolderPath";
            this.btnSelectMergeSoureFolderPath.Size = new System.Drawing.Size(131, 29);
            this.btnSelectMergeSoureFolderPath.TabIndex = 8;
            this.btnSelectMergeSoureFolderPath.Text = "选择源文件夹";
            this.btnSelectMergeSoureFolderPath.UseVisualStyleBackColor = true;
            this.btnSelectMergeSoureFolderPath.Click += new System.EventHandler(this.btnSelectMergeSoureFolderPath_Click);
            // 
            // txtMergeSoureFolderPath
            // 
            this.txtMergeSoureFolderPath.Location = new System.Drawing.Point(154, 23);
            this.txtMergeSoureFolderPath.Name = "txtMergeSoureFolderPath";
            this.txtMergeSoureFolderPath.Size = new System.Drawing.Size(880, 25);
            this.txtMergeSoureFolderPath.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.nudExtractSize);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.nudExtractOffset);
            this.tabPage2.Controls.Add(this.btnExtract);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 187);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "提取";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoExtractSizeInGB);
            this.panel3.Controls.Add(this.rdoExtractSizeInMB);
            this.panel3.Controls.Add(this.rdoExtractSizeInKB);
            this.panel3.Location = new System.Drawing.Point(225, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 25);
            this.panel3.TabIndex = 10;
            // 
            // rdoExtractSizeInGB
            // 
            this.rdoExtractSizeInGB.AutoSize = true;
            this.rdoExtractSizeInGB.Location = new System.Drawing.Point(170, 4);
            this.rdoExtractSizeInGB.Name = "rdoExtractSizeInGB";
            this.rdoExtractSizeInGB.Size = new System.Drawing.Size(44, 19);
            this.rdoExtractSizeInGB.TabIndex = 2;
            this.rdoExtractSizeInGB.Text = "GB";
            this.rdoExtractSizeInGB.UseVisualStyleBackColor = true;
            // 
            // rdoExtractSizeInMB
            // 
            this.rdoExtractSizeInMB.AutoSize = true;
            this.rdoExtractSizeInMB.Checked = true;
            this.rdoExtractSizeInMB.Location = new System.Drawing.Point(90, 4);
            this.rdoExtractSizeInMB.Name = "rdoExtractSizeInMB";
            this.rdoExtractSizeInMB.Size = new System.Drawing.Size(44, 19);
            this.rdoExtractSizeInMB.TabIndex = 1;
            this.rdoExtractSizeInMB.TabStop = true;
            this.rdoExtractSizeInMB.Text = "MB";
            this.rdoExtractSizeInMB.UseVisualStyleBackColor = true;
            // 
            // rdoExtractSizeInKB
            // 
            this.rdoExtractSizeInKB.AutoSize = true;
            this.rdoExtractSizeInKB.Location = new System.Drawing.Point(10, 4);
            this.rdoExtractSizeInKB.Name = "rdoExtractSizeInKB";
            this.rdoExtractSizeInKB.Size = new System.Drawing.Size(44, 19);
            this.rdoExtractSizeInKB.TabIndex = 0;
            this.rdoExtractSizeInKB.Text = "KB";
            this.rdoExtractSizeInKB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "提取大小";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoExtractOffsetInGB);
            this.panel2.Controls.Add(this.rdoExtractOffsetInMB);
            this.panel2.Controls.Add(this.rdoExtractOffsetInKB);
            this.panel2.Location = new System.Drawing.Point(225, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 25);
            this.panel2.TabIndex = 7;
            // 
            // rdoExtractOffsetInGB
            // 
            this.rdoExtractOffsetInGB.AutoSize = true;
            this.rdoExtractOffsetInGB.Location = new System.Drawing.Point(170, 4);
            this.rdoExtractOffsetInGB.Name = "rdoExtractOffsetInGB";
            this.rdoExtractOffsetInGB.Size = new System.Drawing.Size(44, 19);
            this.rdoExtractOffsetInGB.TabIndex = 2;
            this.rdoExtractOffsetInGB.Text = "GB";
            this.rdoExtractOffsetInGB.UseVisualStyleBackColor = true;
            // 
            // rdoExtractOffsetInMB
            // 
            this.rdoExtractOffsetInMB.AutoSize = true;
            this.rdoExtractOffsetInMB.Checked = true;
            this.rdoExtractOffsetInMB.Location = new System.Drawing.Point(90, 4);
            this.rdoExtractOffsetInMB.Name = "rdoExtractOffsetInMB";
            this.rdoExtractOffsetInMB.Size = new System.Drawing.Size(44, 19);
            this.rdoExtractOffsetInMB.TabIndex = 1;
            this.rdoExtractOffsetInMB.TabStop = true;
            this.rdoExtractOffsetInMB.Text = "MB";
            this.rdoExtractOffsetInMB.UseVisualStyleBackColor = true;
            // 
            // rdoExtractOffsetInKB
            // 
            this.rdoExtractOffsetInKB.AutoSize = true;
            this.rdoExtractOffsetInKB.Location = new System.Drawing.Point(10, 4);
            this.rdoExtractOffsetInKB.Name = "rdoExtractOffsetInKB";
            this.rdoExtractOffsetInKB.Size = new System.Drawing.Size(44, 19);
            this.rdoExtractOffsetInKB.TabIndex = 0;
            this.rdoExtractOffsetInKB.Text = "KB";
            this.rdoExtractOffsetInKB.UseVisualStyleBackColor = true;
            // 
            // nudExtractSize
            // 
            this.nudExtractSize.Location = new System.Drawing.Point(100, 59);
            this.nudExtractSize.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudExtractSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudExtractSize.Name = "nudExtractSize";
            this.nudExtractSize.Size = new System.Drawing.Size(100, 25);
            this.nudExtractSize.TabIndex = 8;
            this.nudExtractSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudExtractSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "偏移大小";
            // 
            // nudExtractOffset
            // 
            this.nudExtractOffset.Location = new System.Drawing.Point(100, 23);
            this.nudExtractOffset.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudExtractOffset.Name = "nudExtractOffset";
            this.nudExtractOffset.Size = new System.Drawing.Size(100, 25);
            this.nudExtractOffset.TabIndex = 5;
            this.nudExtractOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(9, 143);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(132, 38);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "开始";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtTargetFolderPath
            // 
            this.txtTargetFolderPath.AllowDrop = true;
            this.txtTargetFolderPath.Location = new System.Drawing.Point(170, 105);
            this.txtTargetFolderPath.Name = "txtTargetFolderPath";
            this.txtTargetFolderPath.Size = new System.Drawing.Size(905, 25);
            this.txtTargetFolderPath.TabIndex = 5;
            this.txtTargetFolderPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtTargetFolderPath_DragDrop);
            this.txtTargetFolderPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtTargetFolderPath_DragEnter);
            // 
            // btnSelectTargetFolderPath
            // 
            this.btnSelectTargetFolderPath.Location = new System.Drawing.Point(12, 103);
            this.btnSelectTargetFolderPath.Name = "btnSelectTargetFolderPath";
            this.btnSelectTargetFolderPath.Size = new System.Drawing.Size(145, 29);
            this.btnSelectTargetFolderPath.TabIndex = 6;
            this.btnSelectTargetFolderPath.Text = "选择输出文件夹";
            this.btnSelectTargetFolderPath.UseVisualStyleBackColor = true;
            this.btnSelectTargetFolderPath.Click += new System.EventHandler(this.btnSelectTargetFolderPath_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(16, 400);
            this.txtLog.MaxLength = 99999999;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1058, 264);
            this.txtLog.TabIndex = 7;
            this.txtLog.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 676);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSelectTargetFolderPath);
            this.Controls.Add(this.txtTargetFolderPath);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblSourceFileSize);
            this.Controls.Add(this.txtSourceFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "文件分割";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSplitSize)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtractSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtractOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceFilePath;
        private System.Windows.Forms.Label lblSourceFileSize;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoSplitSizeInGB;
        private System.Windows.Forms.RadioButton rdoSplitSizeInMB;
        private System.Windows.Forms.RadioButton rdoSplitSizeInKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.NumericUpDown nudSplitSize;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoExtractSizeInGB;
        private System.Windows.Forms.RadioButton rdoExtractSizeInMB;
        private System.Windows.Forms.RadioButton rdoExtractSizeInKB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoExtractOffsetInGB;
        private System.Windows.Forms.RadioButton rdoExtractOffsetInMB;
        private System.Windows.Forms.RadioButton rdoExtractOffsetInKB;
        private System.Windows.Forms.NumericUpDown nudExtractSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudExtractOffset;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtTargetFolderPath;
        private System.Windows.Forms.Button btnSelectTargetFolderPath;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnSelectMergeSoureFolderPath;
        private System.Windows.Forms.TextBox txtMergeSoureFolderPath;
    }
}


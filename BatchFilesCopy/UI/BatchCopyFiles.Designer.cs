namespace BatchFilesCopy.UI
{
    partial class BatchCopyFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchCopyFiles));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBatchAsXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateSourceFilePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripBtnDetails = new System.Windows.Forms.ToolStripDropDownButton();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitbtnCancel = new System.Windows.Forms.ToolStripSplitButton();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnFooterTip = new System.Windows.Forms.ToolStripSplitButton();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.chkLogging = new System.Windows.Forms.CheckBox();
            this.btnRemoveBatch = new System.Windows.Forms.Button();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.btnRunBatchSequence = new System.Windows.Forms.Button();
            this.cbBatchSequence = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btnRunActiveBatch = new System.Windows.Forms.Button();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnValidateActiveBatch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewSrcFiles = new System.Windows.Forms.TreeView();
            this.imgListSrc = new System.Windows.Forms.ImageList(this.components);
            this.treeViewDestFiles = new System.Windows.Forms.TreeView();
            this.imgListDest = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.treeViewSrcFiles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.treeViewDestFiles, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.427464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.800326F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.73024F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.56232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.479654F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1202, 732);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveBatchAsXMLToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem.Text = "Open Batch XML";
            // 
            // saveBatchAsXMLToolStripMenuItem
            // 
            this.saveBatchAsXMLToolStripMenuItem.Name = "saveBatchAsXMLToolStripMenuItem";
            this.saveBatchAsXMLToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveBatchAsXMLToolStripMenuItem.Text = "Save Batch as XML";
            this.saveBatchAsXMLToolStripMenuItem.Click += new System.EventHandler(this.saveBatchAsXMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSequenceToolStripMenuItem,
            this.validateSourceFilePathsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createSequenceToolStripMenuItem
            // 
            this.createSequenceToolStripMenuItem.Name = "createSequenceToolStripMenuItem";
            this.createSequenceToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.createSequenceToolStripMenuItem.Text = "Create Sequence";
            // 
            // validateSourceFilePathsToolStripMenuItem
            // 
            this.validateSourceFilePathsToolStripMenuItem.Name = "validateSourceFilePathsToolStripMenuItem";
            this.validateSourceFilePathsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.validateSourceFilePathsToolStripMenuItem.Text = "Validate Source File Paths";
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnDetails,
            this.toolStripStatuslbl,
            this.toolStripProgBar,
            this.toolStripSplitbtnCancel,
            this.lblFooter,
            this.btnFooterTip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1202, 38);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripBtnDetails
            // 
            this.toolStripBtnDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnDetails.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem});
            this.toolStripBtnDetails.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDetails.Image")));
            this.toolStripBtnDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnDetails.Name = "toolStripBtnDetails";
            this.toolStripBtnDetails.Size = new System.Drawing.Size(29, 36);
            this.toolStripBtnDetails.Text = "toolStripDropDownButton1";
            this.toolStripBtnDetails.Click += new System.EventHandler(this.toolStripBtnDetails_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.showDetailsToolStripMenuItem.Text = "Show details";
            // 
            // toolStripStatuslbl
            // 
            this.toolStripStatuslbl.Name = "toolStripStatuslbl";
            this.toolStripStatuslbl.Size = new System.Drawing.Size(0, 33);
            // 
            // toolStripProgBar
            // 
            this.toolStripProgBar.Name = "toolStripProgBar";
            this.toolStripProgBar.Size = new System.Drawing.Size(100, 32);
            // 
            // toolStripSplitbtnCancel
            // 
            this.toolStripSplitbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitbtnCancel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem});
            this.toolStripSplitbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitbtnCancel.Image")));
            this.toolStripSplitbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitbtnCancel.Name = "toolStripSplitbtnCancel";
            this.toolStripSplitbtnCancel.Size = new System.Drawing.Size(32, 36);
            this.toolStripSplitbtnCancel.Text = "toolStripSplitButton1";
            this.toolStripSplitbtnCancel.ButtonClick += new System.EventHandler(this.toolStripSplitbtnCancel_ButtonClick);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // lblFooter
            // 
            this.lblFooter.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblFooter.Image = ((System.Drawing.Image)(resources.GetObject("lblFooter.Image")));
            this.lblFooter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(961, 33);
            this.lblFooter.Spring = true;
            this.lblFooter.Text = "...";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFooterTip
            // 
            this.btnFooterTip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFooterTip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem});
            this.btnFooterTip.Image = ((System.Drawing.Image)(resources.GetObject("btnFooterTip.Image")));
            this.btnFooterTip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFooterTip.Name = "btnFooterTip";
            this.btnFooterTip.Size = new System.Drawing.Size(32, 36);
            this.btnFooterTip.Text = "toolStripSplitButton1";
            this.btnFooterTip.ButtonClick += new System.EventHandler(this.btnFooterTip_ButtonClick);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.nextToolStripMenuItem.Text = "Next Tip";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.chkLogging);
            this.panel1.Controls.Add(this.btnRemoveBatch);
            this.panel1.Controls.Add(this.btnAddBatch);
            this.panel1.Controls.Add(this.btnRunBatchSequence);
            this.panel1.Controls.Add(this.cbBatchSequence);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.btnRunActiveBatch);
            this.panel1.Controls.Add(this.btnSaveXML);
            this.panel1.Controls.Add(this.btnValidateActiveBatch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 36);
            this.panel1.TabIndex = 26;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(901, 7);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 54;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // chkLogging
            // 
            this.chkLogging.AutoSize = true;
            this.chkLogging.Checked = true;
            this.chkLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLogging.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkLogging.Location = new System.Drawing.Point(1081, 0);
            this.chkLogging.Name = "chkLogging";
            this.chkLogging.Size = new System.Drawing.Size(81, 36);
            this.chkLogging.TabIndex = 53;
            this.chkLogging.Text = "Logging On";
            this.chkLogging.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBatch
            // 
            this.btnRemoveBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRemoveBatch.FlatAppearance.BorderSize = 0;
            this.btnRemoveBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBatch.Location = new System.Drawing.Point(360, 0);
            this.btnRemoveBatch.Name = "btnRemoveBatch";
            this.btnRemoveBatch.Size = new System.Drawing.Size(61, 36);
            this.btnRemoveBatch.TabIndex = 30;
            this.btnRemoveBatch.Text = "Remove Batch";
            this.btnRemoveBatch.UseVisualStyleBackColor = true;
            this.btnRemoveBatch.Click += new System.EventHandler(this.btnRemoveBatch_Click);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddBatch.FlatAppearance.BorderSize = 0;
            this.btnAddBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBatch.Location = new System.Drawing.Point(311, 0);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(49, 36);
            this.btnAddBatch.TabIndex = 29;
            this.btnAddBatch.Text = "Add Batch";
            this.btnAddBatch.UseVisualStyleBackColor = true;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // btnRunBatchSequence
            // 
            this.btnRunBatchSequence.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRunBatchSequence.FlatAppearance.BorderSize = 0;
            this.btnRunBatchSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunBatchSequence.Image = ((System.Drawing.Image)(resources.GetObject("btnRunBatchSequence.Image")));
            this.btnRunBatchSequence.Location = new System.Drawing.Point(277, 0);
            this.btnRunBatchSequence.Name = "btnRunBatchSequence";
            this.btnRunBatchSequence.Size = new System.Drawing.Size(34, 36);
            this.btnRunBatchSequence.TabIndex = 27;
            this.btnRunBatchSequence.UseVisualStyleBackColor = true;
            // 
            // cbBatchSequence
            // 
            this.cbBatchSequence.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbBatchSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBatchSequence.FormattingEnabled = true;
            this.cbBatchSequence.Location = new System.Drawing.Point(103, 0);
            this.cbBatchSequence.Name = "cbBatchSequence";
            this.cbBatchSequence.Size = new System.Drawing.Size(174, 32);
            this.cbBatchSequence.TabIndex = 28;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1162, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 36);
            this.button7.TabIndex = 26;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnRunActiveBatch
            // 
            this.btnRunActiveBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRunActiveBatch.FlatAppearance.BorderSize = 0;
            this.btnRunActiveBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunActiveBatch.Image = ((System.Drawing.Image)(resources.GetObject("btnRunActiveBatch.Image")));
            this.btnRunActiveBatch.Location = new System.Drawing.Point(69, 0);
            this.btnRunActiveBatch.Name = "btnRunActiveBatch";
            this.btnRunActiveBatch.Size = new System.Drawing.Size(34, 36);
            this.btnRunActiveBatch.TabIndex = 25;
            this.btnRunActiveBatch.UseVisualStyleBackColor = true;
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveXML.FlatAppearance.BorderSize = 0;
            this.btnSaveXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveXML.Image")));
            this.btnSaveXML.Location = new System.Drawing.Point(35, 0);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(34, 36);
            this.btnSaveXML.TabIndex = 22;
            this.btnSaveXML.UseVisualStyleBackColor = true;
            // 
            // btnValidateActiveBatch
            // 
            this.btnValidateActiveBatch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnValidateActiveBatch.FlatAppearance.BorderSize = 0;
            this.btnValidateActiveBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateActiveBatch.Image = ((System.Drawing.Image)(resources.GetObject("btnValidateActiveBatch.Image")));
            this.btnValidateActiveBatch.Location = new System.Drawing.Point(0, 0);
            this.btnValidateActiveBatch.Name = "btnValidateActiveBatch";
            this.btnValidateActiveBatch.Size = new System.Drawing.Size(35, 36);
            this.btnValidateActiveBatch.TabIndex = 24;
            this.btnValidateActiveBatch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 225);
            this.panel2.TabIndex = 27;
            // 
            // treeViewSrcFiles
            // 
            this.treeViewSrcFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSrcFiles.ImageIndex = 0;
            this.treeViewSrcFiles.ImageList = this.imgListSrc;
            this.treeViewSrcFiles.Location = new System.Drawing.Point(3, 70);
            this.treeViewSrcFiles.Name = "treeViewSrcFiles";
            this.treeViewSrcFiles.SelectedImageIndex = 0;
            this.treeViewSrcFiles.Size = new System.Drawing.Size(595, 379);
            this.treeViewSrcFiles.TabIndex = 28;
            // 
            // imgListSrc
            // 
            this.imgListSrc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListSrc.ImageStream")));
            this.imgListSrc.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListSrc.Images.SetKeyName(0, "open-book.png");
            this.imgListSrc.Images.SetKeyName(1, "play-button.png");
            // 
            // treeViewDestFiles
            // 
            this.treeViewDestFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDestFiles.ImageIndex = 0;
            this.treeViewDestFiles.ImageList = this.imgListDest;
            this.treeViewDestFiles.Location = new System.Drawing.Point(604, 70);
            this.treeViewDestFiles.Name = "treeViewDestFiles";
            this.treeViewDestFiles.SelectedImageIndex = 0;
            this.treeViewDestFiles.Size = new System.Drawing.Size(595, 379);
            this.treeViewDestFiles.TabIndex = 29;
            // 
            // imgListDest
            // 
            this.imgListDest.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListDest.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListDest.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BatchCopyFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BatchCopyFiles";
            this.Text = "Batch Copy";
            this.Load += new System.EventHandler(this.BatchCopyFiles_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslbl;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBatchAsXMLToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSequenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateSourceFilePathsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnValidateActiveBatch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnRunActiveBatch;
        private System.Windows.Forms.ToolStripStatusLabel lblFooter;
        private System.Windows.Forms.ToolStripSplitButton btnFooterTip;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.Button btnRunBatchSequence;
        private System.Windows.Forms.ComboBox cbBatchSequence;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.Button btnRemoveBatch;
        private System.Windows.Forms.CheckBox chkLogging;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitbtnCancel;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TreeView treeViewSrcFiles;
        private System.Windows.Forms.ImageList imgListSrc;
        private System.Windows.Forms.TreeView treeViewDestFiles;
        private System.Windows.Forms.ImageList imgListDest;
        private System.Windows.Forms.ToolStripDropDownButton toolStripBtnDetails;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
    }
}
namespace BatchCopyCore.UI.Controls
{
    partial class CopyByCodeSource
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPreviewCopy = new System.Windows.Forms.Button();
            this.btn_destFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btn_SrcFolder = new System.Windows.Forms.Button();
            this.txt_srcFolder = new System.Windows.Forms.TextBox();
            this.lblSourceList = new System.Windows.Forms.Label();
            this.cbCSVSourceList = new System.Windows.Forms.CheckBox();
            this.btnExemptedFiles = new System.Windows.Forms.Button();
            this.lblExemptedFile = new System.Windows.Forms.Label();
            this.cbCSVExemptedList = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLarge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLess = new System.Windows.Forms.TextBox();
            this.cb_destFolderStructure = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncludeFileExtensions = new System.Windows.Forms.Button();
            this.txtIncludeFiles = new System.Windows.Forms.TextBox();
            this.txtExemptedList = new System.Windows.Forms.TextBox();
            this.btnExemptedFileExtensions = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtFileSearchPattern = new System.Windows.Forms.TextBox();
            this.lblFileSearchPattern = new System.Windows.Forms.Label();
            this.chkNestedFSrcFiles = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fbd_SrcFolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_destFolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_SrcFileBrowse = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreviewCopy
            // 
            this.btnPreviewCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviewCopy.Location = new System.Drawing.Point(630, 4);
            this.btnPreviewCopy.Name = "btnPreviewCopy";
            this.btnPreviewCopy.Size = new System.Drawing.Size(163, 23);
            this.btnPreviewCopy.TabIndex = 32;
            this.btnPreviewCopy.Text = "Preview list of files to copy";
            this.btnPreviewCopy.UseVisualStyleBackColor = true;
            this.btnPreviewCopy.Click += new System.EventHandler(this.btnPreviewCopy_Click);
            this.btnPreviewCopy.MouseHover += new System.EventHandler(this.btnPreviewCopy_MouseHover);
            // 
            // btn_destFolder
            // 
            this.btn_destFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_destFolder.Location = new System.Drawing.Point(1121, 86);
            this.btn_destFolder.Name = "btn_destFolder";
            this.btn_destFolder.Size = new System.Drawing.Size(36, 22);
            this.btn_destFolder.TabIndex = 34;
            this.btn_destFolder.Text = "...";
            this.btn_destFolder.UseVisualStyleBackColor = true;
            this.btn_destFolder.Click += new System.EventHandler(this.btn_destFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 83);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(137, 34);
            this.label2.TabIndex = 33;
            this.label2.Text = "* Destination folder";
            // 
            // txtDestination
            // 
            this.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(274, 86);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(840, 23);
            this.txtDestination.TabIndex = 31;
            // 
            // btn_SrcFolder
            // 
            this.btn_SrcFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SrcFolder.Location = new System.Drawing.Point(1121, 3);
            this.btn_SrcFolder.Name = "btn_SrcFolder";
            this.btn_SrcFolder.Size = new System.Drawing.Size(36, 22);
            this.btn_SrcFolder.TabIndex = 40;
            this.btn_SrcFolder.Text = "...";
            this.btn_SrcFolder.UseVisualStyleBackColor = true;
            this.btn_SrcFolder.Click += new System.EventHandler(this.btn_SrcFolder_Click);
            // 
            // txt_srcFolder
            // 
            this.txt_srcFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_srcFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_srcFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_srcFolder.Location = new System.Drawing.Point(274, 3);
            this.txt_srcFolder.Name = "txt_srcFolder";
            this.txt_srcFolder.Size = new System.Drawing.Size(840, 22);
            this.txt_srcFolder.TabIndex = 38;
            // 
            // lblSourceList
            // 
            this.lblSourceList.AutoSize = true;
            this.lblSourceList.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSourceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceList.Location = new System.Drawing.Point(117, 0);
            this.lblSourceList.Name = "lblSourceList";
            this.lblSourceList.Padding = new System.Windows.Forms.Padding(3);
            this.lblSourceList.Size = new System.Drawing.Size(151, 33);
            this.lblSourceList.TabIndex = 39;
            this.lblSourceList.Text = "* Select source folder";
            // 
            // cbCSVSourceList
            // 
            this.cbCSVSourceList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCSVSourceList.AutoSize = true;
            this.cbCSVSourceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCSVSourceList.Location = new System.Drawing.Point(15, 3);
            this.cbCSVSourceList.Name = "cbCSVSourceList";
            this.cbCSVSourceList.Size = new System.Drawing.Size(92, 19);
            this.cbCSVSourceList.TabIndex = 42;
            this.cbCSVSourceList.Text = "Use CSV list";
            this.cbCSVSourceList.UseVisualStyleBackColor = true;
            this.cbCSVSourceList.CheckedChanged += new System.EventHandler(this.cbCSVSourceList_CheckedChanged);
            // 
            // btnExemptedFiles
            // 
            this.btnExemptedFiles.Location = new System.Drawing.Point(340, 0);
            this.btnExemptedFiles.Name = "btnExemptedFiles";
            this.btnExemptedFiles.Size = new System.Drawing.Size(36, 23);
            this.btnExemptedFiles.TabIndex = 44;
            this.btnExemptedFiles.Text = "...";
            this.btnExemptedFiles.UseVisualStyleBackColor = true;
            this.btnExemptedFiles.Click += new System.EventHandler(this.btnExemptedFiles_Click);
            // 
            // lblExemptedFile
            // 
            this.lblExemptedFile.AutoSize = true;
            this.lblExemptedFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblExemptedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExemptedFile.Location = new System.Drawing.Point(127, 174);
            this.lblExemptedFile.Margin = new System.Windows.Forms.Padding(0);
            this.lblExemptedFile.Name = "lblExemptedFile";
            this.lblExemptedFile.Size = new System.Drawing.Size(144, 32);
            this.lblExemptedFile.TabIndex = 45;
            this.lblExemptedFile.Text = "Exempted file extensions";
            // 
            // cbCSVExemptedList
            // 
            this.cbCSVExemptedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCSVExemptedList.AutoSize = true;
            this.cbCSVExemptedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCSVExemptedList.Location = new System.Drawing.Point(15, 177);
            this.cbCSVExemptedList.Name = "cbCSVExemptedList";
            this.cbCSVExemptedList.Size = new System.Drawing.Size(92, 19);
            this.cbCSVExemptedList.TabIndex = 46;
            this.cbCSVExemptedList.Text = "Use CSV list";
            this.cbCSVExemptedList.UseVisualStyleBackColor = true;
            this.cbCSVExemptedList.CheckedChanged += new System.EventHandler(this.cbCSVExemptedList_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.484715F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.88217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.01046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.622652F));
            this.tableLayoutPanel1.Controls.Add(this.cbCSVSourceList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_srcFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSourceList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtDestination, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_destFolder, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblExemptedFile, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbCSVExemptedList, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_SrcFolder, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.92544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.46855F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.004711F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.003741F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.41782F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.40192F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.97126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.31489F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49167F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 241);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.lbl_Error);
            this.panel3.Controls.Add(this.btnCopy);
            this.panel3.Controls.Add(this.btnPreviewCopy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(113, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1001, 29);
            this.panel3.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(799, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Create CSV list";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(14, 9);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(35, 13);
            this.lbl_Error.TabIndex = 51;
            this.lbl_Error.Text = "label3";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(891, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(107, 23);
            this.btnCopy.TabIndex = 50;
            this.btnCopy.Text = "Copy current batch";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtLarge);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtLess);
            this.panel2.Controls.Add(this.cb_destFolderStructure);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(274, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 23);
            this.panel2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(476, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Select files  : Larger then -";
            // 
            // txtLarge
            // 
            this.txtLarge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLarge.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtLarge.Location = new System.Drawing.Point(606, 0);
            this.txtLarge.Margin = new System.Windows.Forms.Padding(0);
            this.txtLarge.Name = "txtLarge";
            this.txtLarge.Size = new System.Drawing.Size(61, 20);
            this.txtLarge.TabIndex = 51;
            this.txtLarge.Text = "-";
            this.txtLarge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLarge.Enter += new System.EventHandler(this.txtLarge_Enter);
            this.txtLarge.Leave += new System.EventHandler(this.txtLarge_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(667, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "(mb)  Less then -";
            // 
            // txtLess
            // 
            this.txtLess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLess.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtLess.Location = new System.Drawing.Point(752, 0);
            this.txtLess.Margin = new System.Windows.Forms.Padding(0);
            this.txtLess.Name = "txtLess";
            this.txtLess.Size = new System.Drawing.Size(61, 20);
            this.txtLess.TabIndex = 49;
            this.txtLess.Text = "-";
            this.txtLess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLess.Enter += new System.EventHandler(this.txtLess_Enter);
            this.txtLess.Leave += new System.EventHandler(this.txtLess_Leave);
            // 
            // cb_destFolderStructure
            // 
            this.cb_destFolderStructure.BackColor = System.Drawing.SystemColors.Window;
            this.cb_destFolderStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.cb_destFolderStructure.FormattingEnabled = true;
            this.cb_destFolderStructure.Items.AddRange(new object[] {
            "Maintain source folder structure",
            "Create folders according to time stamps ranges",
            "Create dictionary style folders, from a-z ",
            "Remove all sub folders, copy all files to destination folder only"});
            this.cb_destFolderStructure.Location = new System.Drawing.Point(161, 0);
            this.cb_destFolderStructure.Margin = new System.Windows.Forms.Padding(0);
            this.cb_destFolderStructure.Name = "cb_destFolderStructure";
            this.cb_destFolderStructure.Size = new System.Drawing.Size(315, 21);
            this.cb_destFolderStructure.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "* Destination folder structure";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.Location = new System.Drawing.Point(813, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "(mb)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnIncludeFileExtensions);
            this.panel1.Controls.Add(this.txtIncludeFiles);
            this.panel1.Controls.Add(this.btnExemptedFiles);
            this.panel1.Controls.Add(this.txtExemptedList);
            this.panel1.Controls.Add(this.btnExemptedFileExtensions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(274, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 26);
            this.panel1.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, -1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Include Files Extensions";
            // 
            // btnIncludeFileExtensions
            // 
            this.btnIncludeFileExtensions.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncludeFileExtensions.Location = new System.Drawing.Point(509, 0);
            this.btnIncludeFileExtensions.Name = "btnIncludeFileExtensions";
            this.btnIncludeFileExtensions.Size = new System.Drawing.Size(13, 22);
            this.btnIncludeFileExtensions.TabIndex = 48;
            this.btnIncludeFileExtensions.Text = ".";
            this.btnIncludeFileExtensions.UseVisualStyleBackColor = true;
            this.btnIncludeFileExtensions.Click += new System.EventHandler(this.btnIncludeFileExtensions_Click);
            // 
            // txtIncludeFiles
            // 
            this.txtIncludeFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncludeFiles.Enabled = false;
            this.txtIncludeFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncludeFiles.Location = new System.Drawing.Point(525, 0);
            this.txtIncludeFiles.Name = "txtIncludeFiles";
            this.txtIncludeFiles.Size = new System.Drawing.Size(317, 23);
            this.txtIncludeFiles.TabIndex = 44;
            // 
            // txtExemptedList
            // 
            this.txtExemptedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExemptedList.Enabled = false;
            this.txtExemptedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExemptedList.Location = new System.Drawing.Point(16, 0);
            this.txtExemptedList.Name = "txtExemptedList";
            this.txtExemptedList.Size = new System.Drawing.Size(318, 23);
            this.txtExemptedList.TabIndex = 43;
            // 
            // btnExemptedFileExtensions
            // 
            this.btnExemptedFileExtensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExemptedFileExtensions.Location = new System.Drawing.Point(0, 0);
            this.btnExemptedFileExtensions.Name = "btnExemptedFileExtensions";
            this.btnExemptedFileExtensions.Size = new System.Drawing.Size(13, 23);
            this.btnExemptedFileExtensions.TabIndex = 46;
            this.btnExemptedFileExtensions.Text = ".";
            this.btnExemptedFileExtensions.UseVisualStyleBackColor = true;
            this.btnExemptedFileExtensions.Click += new System.EventHandler(this.btnExemptedFileExtensions_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtFileSearchPattern);
            this.panel4.Controls.Add(this.lblFileSearchPattern);
            this.panel4.Controls.Add(this.chkNestedFSrcFiles);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(274, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(840, 28);
            this.panel4.TabIndex = 53;
            // 
            // txtFileSearchPattern
            // 
            this.txtFileSearchPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileSearchPattern.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFileSearchPattern.Location = new System.Drawing.Point(94, 0);
            this.txtFileSearchPattern.Name = "txtFileSearchPattern";
            this.txtFileSearchPattern.Size = new System.Drawing.Size(530, 20);
            this.txtFileSearchPattern.TabIndex = 54;
            this.txtFileSearchPattern.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // lblFileSearchPattern
            // 
            this.lblFileSearchPattern.AutoSize = true;
            this.lblFileSearchPattern.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFileSearchPattern.Location = new System.Drawing.Point(0, 0);
            this.lblFileSearchPattern.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileSearchPattern.Name = "lblFileSearchPattern";
            this.lblFileSearchPattern.Size = new System.Drawing.Size(94, 13);
            this.lblFileSearchPattern.TabIndex = 53;
            this.lblFileSearchPattern.Text = "File search pattern";
            // 
            // chkNestedFSrcFiles
            // 
            this.chkNestedFSrcFiles.AutoSize = true;
            this.chkNestedFSrcFiles.Checked = true;
            this.chkNestedFSrcFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNestedFSrcFiles.Location = new System.Drawing.Point(642, 3);
            this.chkNestedFSrcFiles.Margin = new System.Windows.Forms.Padding(0);
            this.chkNestedFSrcFiles.Name = "chkNestedFSrcFiles";
            this.chkNestedFSrcFiles.Size = new System.Drawing.Size(196, 17);
            this.chkNestedFSrcFiles.TabIndex = 52;
            this.chkNestedFSrcFiles.Text = "Include files from nested folders also";
            this.chkNestedFSrcFiles.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(113, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1044, 1);
            this.panel5.TabIndex = 54;
            // 
            // fbd_SrcFileBrowse
            // 
            this.fbd_SrcFileBrowse.FileName = "openFileDialog1";
            // 
            // CopyByCodeSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CopyByCodeSource";
            this.Size = new System.Drawing.Size(1160, 241);
            this.Load += new System.EventHandler(this.CopyByCodeSource_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPreviewCopy;
        private System.Windows.Forms.Button btn_destFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btn_SrcFolder;
        private System.Windows.Forms.TextBox txt_srcFolder;
        private System.Windows.Forms.Label lblSourceList;
        private System.Windows.Forms.CheckBox cbCSVSourceList;
        private System.Windows.Forms.Button btnExemptedFiles;
        private System.Windows.Forms.Label lblExemptedFile;
        private System.Windows.Forms.CheckBox cbCSVExemptedList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_destFolderStructure;
        private System.Windows.Forms.TextBox txtIncludeFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExemptedList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLess;
        private System.Windows.Forms.TextBox txtLarge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIncludeFileExtensions;
        private System.Windows.Forms.Button btnExemptedFileExtensions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.FolderBrowserDialog fbd_SrcFolderBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbd_destFolderBrowse;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.CheckBox chkNestedFSrcFiles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtFileSearchPattern;
        private System.Windows.Forms.Label lblFileSearchPattern;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.OpenFileDialog fbd_SrcFileBrowse;
    }
}

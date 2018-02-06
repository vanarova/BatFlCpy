namespace BatchFilesCopy.UI
{
    partial class RunDetails
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
            this.txtProgressLog = new System.Windows.Forms.TextBox();
            this.pnlRunDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRunDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProgressLog
            // 
            this.txtProgressLog.Location = new System.Drawing.Point(8, 8);
            this.txtProgressLog.Multiline = true;
            this.txtProgressLog.Name = "txtProgressLog";
            this.txtProgressLog.Size = new System.Drawing.Size(331, 104);
            this.txtProgressLog.TabIndex = 0;
            // 
            // pnlRunDetails
            // 
            this.pnlRunDetails.Controls.Add(this.txtProgressLog);
            this.pnlRunDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRunDetails.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlRunDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlRunDetails.Name = "pnlRunDetails";
            this.pnlRunDetails.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRunDetails.Size = new System.Drawing.Size(351, 269);
            this.pnlRunDetails.TabIndex = 1;
            // 
            // RunDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 269);
            this.Controls.Add(this.pnlRunDetails);
            this.Name = "RunDetails";
            this.Text = "RunDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RunDetails_FormClosing);
            this.pnlRunDetails.ResumeLayout(false);
            this.pnlRunDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtProgressLog;
        private System.Windows.Forms.FlowLayoutPanel pnlRunDetails;
    }
}
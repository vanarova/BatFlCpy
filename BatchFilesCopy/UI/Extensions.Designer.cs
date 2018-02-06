namespace BatchFilesCopy.UI
{
    partial class Extensions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extensions));
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExtensions
            // 
            this.txtExtensions.Location = new System.Drawing.Point(24, 114);
            this.txtExtensions.Multiline = true;
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(363, 111);
            this.txtExtensions.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(329, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblExtensions
            // 
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Location = new System.Drawing.Point(30, 31);
            this.lblExtensions.Name = "lblExtensions";
            this.lblExtensions.Size = new System.Drawing.Size(328, 52);
            this.lblExtensions.TabIndex = 2;
            this.lblExtensions.Text = "Please provide comma separated file extensions list in below format -\r\n\r\nExample " +
    "-\r\n.txt, .jpg, .png, .c, .doc";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(277, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input in incorrect format.";
            // 
            // Extensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblExtensions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtExtensions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extensions";
            this.Text = "Extensions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExtensions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblExtensions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
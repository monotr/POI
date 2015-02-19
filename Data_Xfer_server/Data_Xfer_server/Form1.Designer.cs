namespace Data_Xfer_server
{
    partial class Form1
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
            this.lbConnections = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lbConnections
            // 
            this.lbConnections.FormattingEnabled = true;
            this.lbConnections.Location = new System.Drawing.Point(11, 33);
            this.lbConnections.Name = "lbConnections";
            this.lbConnections.Size = new System.Drawing.Size(178, 121);
            this.lbConnections.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "My IP Address is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 177);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lbConnections);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbConnections;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


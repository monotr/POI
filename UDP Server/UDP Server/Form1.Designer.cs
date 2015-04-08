namespace UDP_Server
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
            this.conectionsList = new System.Windows.Forms.ListBox();
            this.videoReceived = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // conectionsList
            // 
            this.conectionsList.FormattingEnabled = true;
            this.conectionsList.Location = new System.Drawing.Point(12, 12);
            this.conectionsList.Name = "conectionsList";
            this.conectionsList.Size = new System.Drawing.Size(260, 238);
            this.conectionsList.TabIndex = 0;
            // 
            // videoReceived
            // 
            this.videoReceived.Location = new System.Drawing.Point(278, 12);
            this.videoReceived.Name = "videoReceived";
            this.videoReceived.Size = new System.Drawing.Size(261, 238);
            this.videoReceived.TabIndex = 1;
            this.videoReceived.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.videoReceived);
            this.Controls.Add(this.conectionsList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "UDP Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoReceived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox conectionsList;
        private System.Windows.Forms.PictureBox videoReceived;
    }
}


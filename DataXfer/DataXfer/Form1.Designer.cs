namespace DataXfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server:";
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(59, 6);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(100, 20);
            this.tbFilename.TabIndex = 2;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(59, 39);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(100, 20);
            this.tbServer.TabIndex = 3;
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(178, 6);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(75, 23);
            this.browse_btn.TabIndex = 4;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(178, 42);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 5;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 79);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP/IP Data Xfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}


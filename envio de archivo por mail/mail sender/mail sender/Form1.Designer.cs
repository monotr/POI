namespace mail_sender
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
            this.To = new System.Windows.Forms.TextBox();
            this.from_textbox = new System.Windows.Forms.TextBox();
            this.body_textbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.file = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.subobject_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.path_texbox = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(207, 10);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(339, 20);
            this.To.TabIndex = 0;
            // 
            // from_textbox
            // 
            this.from_textbox.Location = new System.Drawing.Point(207, 36);
            this.from_textbox.Name = "from_textbox";
            this.from_textbox.Size = new System.Drawing.Size(339, 20);
            this.from_textbox.TabIndex = 0;
            // 
            // body_textbox
            // 
            this.body_textbox.Location = new System.Drawing.Point(207, 142);
            this.body_textbox.Multiline = true;
            this.body_textbox.Name = "body_textbox";
            this.body_textbox.Size = new System.Drawing.Size(339, 128);
            this.body_textbox.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(447, 276);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(99, 26);
            this.file.TabIndex = 1;
            this.file.Text = "File";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(447, 308);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(99, 26);
            this.send.TabIndex = 1;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // subobject_textbox
            // 
            this.subobject_textbox.Location = new System.Drawing.Point(207, 103);
            this.subobject_textbox.Name = "subobject_textbox";
            this.subobject_textbox.Size = new System.Drawing.Size(339, 20);
            this.subobject_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subobject";
            // 
            // path_texbox
            // 
            this.path_texbox.Location = new System.Drawing.Point(157, 282);
            this.path_texbox.Name = "path_texbox";
            this.path_texbox.Size = new System.Drawing.Size(275, 20);
            this.path_texbox.TabIndex = 3;
            this.path_texbox.TextChanged += new System.EventHandler(this.path_texbox_TextChanged);
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(207, 62);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(339, 20);
            this.txtcontra.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 342);
            this.Controls.Add(this.path_texbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.file);
            this.Controls.Add(this.body_textbox);
            this.Controls.Add(this.subobject_textbox);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.from_textbox);
            this.Controls.Add(this.To);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox from_textbox;
        private System.Windows.Forms.TextBox body_textbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox subobject_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox path_texbox;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label4;
    }
}


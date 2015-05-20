namespace clientSide
{
    partial class Correo
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
            this.path_texbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Button();
            this.body_textbox = new System.Windows.Forms.TextBox();
            this.subobject_textbox = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.from_textbox = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // path_texbox
            // 
            this.path_texbox.Location = new System.Drawing.Point(201, 303);
            this.path_texbox.Name = "path_texbox";
            this.path_texbox.Size = new System.Drawing.Size(275, 20);
            this.path_texbox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Asunto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Para";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "De:";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(491, 329);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(99, 26);
            this.send.TabIndex = 9;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(491, 297);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(99, 26);
            this.file.TabIndex = 10;
            this.file.Text = "File";
            this.file.UseVisualStyleBackColor = true;
            // 
            // body_textbox
            // 
            this.body_textbox.Location = new System.Drawing.Point(251, 163);
            this.body_textbox.Multiline = true;
            this.body_textbox.Name = "body_textbox";
            this.body_textbox.Size = new System.Drawing.Size(339, 128);
            this.body_textbox.TabIndex = 4;
            // 
            // subobject_textbox
            // 
            this.subobject_textbox.Location = new System.Drawing.Point(251, 124);
            this.subobject_textbox.Name = "subobject_textbox";
            this.subobject_textbox.Size = new System.Drawing.Size(339, 20);
            this.subobject_textbox.TabIndex = 5;
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(251, 83);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(339, 20);
            this.txtcontra.TabIndex = 6;
            // 
            // from_textbox
            // 
            this.from_textbox.Location = new System.Drawing.Point(251, 57);
            this.from_textbox.Name = "from_textbox";
            this.from_textbox.Size = new System.Drawing.Size(339, 20);
            this.from_textbox.TabIndex = 7;
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(251, 31);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(339, 20);
            this.To.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 397);
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
            this.Text = "Correo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path_texbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.TextBox body_textbox;
        private System.Windows.Forms.TextBox subobject_textbox;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox from_textbox;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
namespace Encrypt
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
            this.original_txt = new System.Windows.Forms.RichTextBox();
            this.encryptado_txt = new System.Windows.Forms.RichTextBox();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.desencrypt_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desencryptado_txt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // original_txt
            // 
            this.original_txt.Location = new System.Drawing.Point(12, 28);
            this.original_txt.Name = "original_txt";
            this.original_txt.Size = new System.Drawing.Size(202, 96);
            this.original_txt.TabIndex = 0;
            this.original_txt.Text = "";
            // 
            // encryptado_txt
            // 
            this.encryptado_txt.Location = new System.Drawing.Point(12, 176);
            this.encryptado_txt.Name = "encryptado_txt";
            this.encryptado_txt.Size = new System.Drawing.Size(202, 96);
            this.encryptado_txt.TabIndex = 1;
            this.encryptado_txt.Text = "";
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(76, 130);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.encrypt_btn.TabIndex = 2;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // desencrypt_btn
            // 
            this.desencrypt_btn.Location = new System.Drawing.Point(76, 278);
            this.desencrypt_btn.Name = "desencrypt_btn";
            this.desencrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.desencrypt_btn.TabIndex = 3;
            this.desencrypt_btn.Text = "Desencrypt";
            this.desencrypt_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encryptado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desencryptado";
            // 
            // desencryptado_txt
            // 
            this.desencryptado_txt.Location = new System.Drawing.Point(12, 325);
            this.desencryptado_txt.Name = "desencryptado_txt";
            this.desencryptado_txt.Size = new System.Drawing.Size(202, 96);
            this.desencryptado_txt.TabIndex = 6;
            this.desencryptado_txt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desencryptado_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desencrypt_btn);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.encryptado_txt);
            this.Controls.Add(this.original_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox original_txt;
        private System.Windows.Forms.RichTextBox encryptado_txt;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Button desencrypt_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox desencryptado_txt;
    }
}


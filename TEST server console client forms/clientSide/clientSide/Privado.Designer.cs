namespace clientSide
{
    partial class Privado
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
            this.clientes_grid = new System.Windows.Forms.DataGridView();
            this.User_Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textToSend_txt2 = new System.Windows.Forms.RichTextBox();
            this.conversation = new System.Windows.Forms.RichTextBox();
            this.textToSend_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncorreo = new System.Windows.Forms.Button();
            this.btnvideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientes_grid
            // 
            this.clientes_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Nickname,
            this.User_IP});
            this.clientes_grid.Location = new System.Drawing.Point(427, 80);
            this.clientes_grid.Name = "clientes_grid";
            this.clientes_grid.Size = new System.Drawing.Size(243, 150);
            this.clientes_grid.TabIndex = 33;
            // 
            // User_Nickname
            // 
            this.User_Nickname.HeaderText = "Nickname";
            this.User_Nickname.Name = "User_Nickname";
            // 
            // User_IP
            // 
            this.User_IP.HeaderText = "IP";
            this.User_IP.Name = "User_IP";
            // 
            // textToSend_txt2
            // 
            this.textToSend_txt2.Location = new System.Drawing.Point(483, 323);
            this.textToSend_txt2.Name = "textToSend_txt2";
            this.textToSend_txt2.Size = new System.Drawing.Size(387, 62);
            this.textToSend_txt2.TabIndex = 26;
            this.textToSend_txt2.Text = "";
            this.textToSend_txt2.Visible = false;
            // 
            // conversation
            // 
            this.conversation.Location = new System.Drawing.Point(15, 75);
            this.conversation.Name = "conversation";
            this.conversation.ReadOnly = true;
            this.conversation.Size = new System.Drawing.Size(387, 119);
            this.conversation.TabIndex = 0;
            this.conversation.Text = "";
            // 
            // textToSend_txt
            // 
            this.textToSend_txt.Location = new System.Drawing.Point(15, 208);
            this.textToSend_txt.Multiline = true;
            this.textToSend_txt.Name = "textToSend_txt";
            this.textToSend_txt.Size = new System.Drawing.Size(387, 62);
            this.textToSend_txt.TabIndex = 1;
            this.textToSend_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textToSend_txt_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // btncorreo
            // 
            this.btncorreo.Location = new System.Drawing.Point(116, 276);
            this.btncorreo.Name = "btncorreo";
            this.btncorreo.Size = new System.Drawing.Size(75, 23);
            this.btncorreo.TabIndex = 3;
            this.btncorreo.Text = "Correo";
            this.btncorreo.UseVisualStyleBackColor = true;
            this.btncorreo.Click += new System.EventHandler(this.btncorreo_Click);
            // 
            // btnvideo
            // 
            this.btnvideo.Location = new System.Drawing.Point(217, 276);
            this.btnvideo.Name = "btnvideo";
            this.btnvideo.Size = new System.Drawing.Size(75, 23);
            this.btnvideo.TabIndex = 4;
            this.btnvideo.Text = "Videochat";
            this.btnvideo.UseVisualStyleBackColor = true;
            this.btnvideo.Click += new System.EventHandler(this.btnvideo_Click);
            // 
            // Privado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 347);
            this.Controls.Add(this.btnvideo);
            this.Controls.Add(this.btncorreo);
            this.Controls.Add(this.clientes_grid);
            this.Controls.Add(this.textToSend_txt2);
            this.Controls.Add(this.conversation);
            this.Controls.Add(this.textToSend_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Privado";
            this.Text = "Privado";
            ((System.ComponentModel.ISupportInitialize)(this.clientes_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientes_grid;
        private System.Windows.Forms.RichTextBox textToSend_txt2;
        private System.Windows.Forms.RichTextBox conversation;
        private System.Windows.Forms.TextBox textToSend_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_IP;
        private System.Windows.Forms.Button btncorreo;
        private System.Windows.Forms.Button btnvideo;
    }
}
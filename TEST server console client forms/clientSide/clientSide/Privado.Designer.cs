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
            this.clientes_grid.Location = new System.Drawing.Point(498, 74);
            this.clientes_grid.Name = "clientes_grid";
            this.clientes_grid.Size = new System.Drawing.Size(242, 138);
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
            this.textToSend_txt2.Location = new System.Drawing.Point(563, 323);
            this.textToSend_txt2.Name = "textToSend_txt2";
            this.textToSend_txt2.Size = new System.Drawing.Size(451, 33);
            this.textToSend_txt2.TabIndex = 26;
            this.textToSend_txt2.Text = "";
            this.textToSend_txt2.Visible = false;
            // 
            // conversation
            // 
            this.conversation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conversation.Location = new System.Drawing.Point(17, 69);
            this.conversation.Name = "conversation";
            this.conversation.ReadOnly = true;
            this.conversation.Size = new System.Drawing.Size(451, 110);
            this.conversation.TabIndex = 0;
            this.conversation.Text = "";
            // 
            // textToSend_txt
            // 
            this.textToSend_txt.Location = new System.Drawing.Point(17, 192);
            this.textToSend_txt.Multiline = true;
            this.textToSend_txt.Name = "textToSend_txt";
            this.textToSend_txt.Size = new System.Drawing.Size(451, 58);
            this.textToSend_txt.TabIndex = 1;
            this.textToSend_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textToSend_txt_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // btncorreo
            // 
            this.btncorreo.BackColor = System.Drawing.Color.SlateGray;
            this.btncorreo.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btncorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncorreo.ForeColor = System.Drawing.Color.White;
            this.btncorreo.Location = new System.Drawing.Point(135, 255);
            this.btncorreo.Name = "btncorreo";
            this.btncorreo.Size = new System.Drawing.Size(87, 21);
            this.btncorreo.TabIndex = 3;
            this.btncorreo.Text = "Correo";
            this.btncorreo.UseVisualStyleBackColor = false;
            this.btncorreo.Click += new System.EventHandler(this.btncorreo_Click);
            // 
            // btnvideo
            // 
            this.btnvideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvideo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnvideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvideo.Font = new System.Drawing.Font("Quantum Flat BRK", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvideo.ForeColor = System.Drawing.Color.White;
            this.btnvideo.Location = new System.Drawing.Point(581, 234);
            this.btnvideo.Name = "btnvideo";
            this.btnvideo.Size = new System.Drawing.Size(133, 47);
            this.btnvideo.TabIndex = 4;
            this.btnvideo.Text = "Videochat";
            this.btnvideo.UseVisualStyleBackColor = false;
            this.btnvideo.Click += new System.EventHandler(this.btnvideo_Click);
            // 
            // Privado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(798, 320);
            this.Controls.Add(this.btnvideo);
            this.Controls.Add(this.btncorreo);
            this.Controls.Add(this.clientes_grid);
            this.Controls.Add(this.textToSend_txt2);
            this.Controls.Add(this.conversation);
            this.Controls.Add(this.textToSend_txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
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
namespace clientSide
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textToSend_txt = new System.Windows.Forms.TextBox();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conversation = new System.Windows.Forms.RichTextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.contactos_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Conectar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textToSend_txt
            // 
            this.textToSend_txt.Location = new System.Drawing.Point(20, 200);
            this.textToSend_txt.Name = "textToSend_txt";
            this.textToSend_txt.Size = new System.Drawing.Size(239, 20);
            this.textToSend_txt.TabIndex = 4;
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(78, 40);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(100, 20);
            this.nickname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nickname";
            // 
            // conversation
            // 
            this.conversation.Location = new System.Drawing.Point(20, 67);
            this.conversation.Name = "conversation";
            this.conversation.Size = new System.Drawing.Size(239, 119);
            this.conversation.TabIndex = 7;
            this.conversation.Text = "";
            this.conversation.TextChanged += new System.EventHandler(this.conversation_TextChanged);
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(304, 60);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(164, 21);
            this.comboEstado.TabIndex = 8;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            this.comboEstado.ValueMemberChanged += new System.EventHandler(this.comboEstado_ValueMemberChanged);
            // 
            // contactos_list
            // 
            this.contactos_list.FormattingEnabled = true;
            this.contactos_list.Location = new System.Drawing.Point(304, 111);
            this.contactos_list.Name = "contactos_list";
            this.contactos_list.Size = new System.Drawing.Size(164, 134);
            this.contactos_list.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 303);
            this.Controls.Add(this.contactos_list);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.conversation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.textToSend_txt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textToSend_txt;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox conversation;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.ListBox contactos_list;
    }
}


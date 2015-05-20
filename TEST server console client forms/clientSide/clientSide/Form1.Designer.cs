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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.conversation = new System.Windows.Forms.RichTextBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.textToSend_txt = new System.Windows.Forms.TextBox();
            this.textToSend_txt2 = new System.Windows.Forms.RichTextBox();
            this.zumbido = new System.Windows.Forms.Button();
            this.emotes = new System.Windows.Forms.Button();
            this.emotesmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.convprivada = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clientes_grid = new System.Windows.Forms.DataGridView();
            this.User_Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnjuego = new System.Windows.Forms.Button();
            this.kappa = new System.Windows.Forms.Button();
            this.smile = new System.Windows.Forms.Button();
            this.sad = new System.Windows.Forms.Button();
            this.happy = new System.Windows.Forms.Button();
            this.cring = new System.Windows.Forms.Button();
            this.me = new System.Windows.Forms.Button();
            this.scream = new System.Windows.Forms.Button();
            this.whut = new System.Windows.Forms.Button();
            this.wow = new System.Windows.Forms.Button();
            this.wink = new System.Windows.Forms.Button();
            this.smush = new System.Windows.Forms.Button();
            this.like = new System.Windows.Forms.Button();
            this.heart = new System.Windows.Forms.Button();
            this.faiñ = new System.Windows.Forms.Button();
            this.sleepi = new System.Windows.Forms.Button();
            this.bcwarior = new System.Windows.Forms.Button();
            this.death = new System.Windows.Forms.Button();
            this.emotesmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_grid)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(20, 268);
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
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(78, 40);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(100, 20);
            this.nickname.TabIndex = 5;
            this.nickname.TextChanged += new System.EventHandler(this.nickname_TextChanged);
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
            this.conversation.Size = new System.Drawing.Size(387, 119);
            this.conversation.TabIndex = 7;
            this.conversation.Text = "";
            this.conversation.TextChanged += new System.EventHandler(this.conversation_TextChanged);
            // 
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(374, 9);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(164, 21);
            this.comboEstado.TabIndex = 8;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            this.comboEstado.ValueMemberChanged += new System.EventHandler(this.comboEstado_ValueMemberChanged);
            // 
            // textToSend_txt
            // 
            this.textToSend_txt.Location = new System.Drawing.Point(20, 200);
            this.textToSend_txt.Multiline = true;
            this.textToSend_txt.Name = "textToSend_txt";
            this.textToSend_txt.Size = new System.Drawing.Size(387, 62);
            this.textToSend_txt.TabIndex = 4;
            // 
            // textToSend_txt2
            // 
            this.textToSend_txt2.Location = new System.Drawing.Point(488, 315);
            this.textToSend_txt2.Name = "textToSend_txt2";
            this.textToSend_txt2.Size = new System.Drawing.Size(387, 62);
            this.textToSend_txt2.TabIndex = 9;
            this.textToSend_txt2.Text = "";
            this.textToSend_txt2.Visible = false;
            this.textToSend_txt2.TextChanged += new System.EventHandler(this.textToSend_txt2_TextChanged);
            // 
            // zumbido
            // 
            this.zumbido.Location = new System.Drawing.Point(343, 268);
            this.zumbido.Name = "zumbido";
            this.zumbido.Size = new System.Drawing.Size(25, 25);
            this.zumbido.TabIndex = 10;
            this.zumbido.Text = "Z";
            this.zumbido.UseVisualStyleBackColor = true;
            this.zumbido.Click += new System.EventHandler(this.zumbido_Click);
            // 
            // emotes
            // 
            this.emotes.Location = new System.Drawing.Point(374, 268);
            this.emotes.Name = "emotes";
            this.emotes.Size = new System.Drawing.Size(25, 25);
            this.emotes.TabIndex = 10;
            this.emotes.Text = "button3";
            this.emotes.UseVisualStyleBackColor = true;
            this.emotes.Click += new System.EventHandler(this.emotes_Click);
            // 
            // emotesmenu
            // 
            this.emotesmenu.BackColor = System.Drawing.Color.White;
            this.emotesmenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emotesmenu.Controls.Add(this.kappa);
            this.emotesmenu.Controls.Add(this.smile);
            this.emotesmenu.Controls.Add(this.sad);
            this.emotesmenu.Controls.Add(this.happy);
            this.emotesmenu.Controls.Add(this.cring);
            this.emotesmenu.Controls.Add(this.me);
            this.emotesmenu.Controls.Add(this.scream);
            this.emotesmenu.Controls.Add(this.whut);
            this.emotesmenu.Controls.Add(this.wow);
            this.emotesmenu.Controls.Add(this.wink);
            this.emotesmenu.Controls.Add(this.smush);
            this.emotesmenu.Controls.Add(this.like);
            this.emotesmenu.Controls.Add(this.heart);
            this.emotesmenu.Controls.Add(this.faiñ);
            this.emotesmenu.Controls.Add(this.sleepi);
            this.emotesmenu.Controls.Add(this.bcwarior);
            this.emotesmenu.Controls.Add(this.death);
            this.emotesmenu.ForeColor = System.Drawing.Color.White;
            this.emotesmenu.Location = new System.Drawing.Point(255, 67);
            this.emotesmenu.Name = "emotesmenu";
            this.emotesmenu.Size = new System.Drawing.Size(152, 195);
            this.emotesmenu.TabIndex = 12;
            this.emotesmenu.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estado";
            // 
            // convprivada
            // 
            this.convprivada.Enabled = false;
            this.convprivada.Location = new System.Drawing.Point(433, 207);
            this.convprivada.Name = "convprivada";
            this.convprivada.Size = new System.Drawing.Size(105, 48);
            this.convprivada.TabIndex = 15;
            this.convprivada.Text = "Iniciar conversación privada";
            this.convprivada.UseVisualStyleBackColor = true;
            this.convprivada.Click += new System.EventHandler(this.convprivada_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // clientes_grid
            // 
            this.clientes_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_Nickname,
            this.User_Estado,
            this.User_IP});
            this.clientes_grid.Location = new System.Drawing.Point(431, 43);
            this.clientes_grid.Name = "clientes_grid";
            this.clientes_grid.Size = new System.Drawing.Size(344, 150);
            this.clientes_grid.TabIndex = 17;
            this.clientes_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientes_grid_CellContentClick);
            this.clientes_grid.SelectionChanged += new System.EventHandler(this.clientes_grid_SelectionChanged);
            // 
            // User_Nickname
            // 
            this.User_Nickname.HeaderText = "Nickname";
            this.User_Nickname.Name = "User_Nickname";
            // 
            // User_Estado
            // 
            this.User_Estado.HeaderText = "Estado";
            this.User_Estado.Name = "User_Estado";
            // 
            // User_IP
            // 
            this.User_IP.HeaderText = "IP";
            this.User_IP.Name = "User_IP";
            // 
            // btnjuego
            // 
            this.btnjuego.Location = new System.Drawing.Point(554, 216);
            this.btnjuego.Name = "btnjuego";
            this.btnjuego.Size = new System.Drawing.Size(97, 39);
            this.btnjuego.TabIndex = 18;
            this.btnjuego.Text = "Iniciar Juego";
            this.btnjuego.UseVisualStyleBackColor = true;
            this.btnjuego.Click += new System.EventHandler(this.btnjuego_Click);
            // 
            // kappa
            // 
            this.kappa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kappa.FlatAppearance.BorderSize = 0;
            this.kappa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kappa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.kappa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kappa.Image = global::clientSide.Properties.Resources.kappa;
            this.kappa.Location = new System.Drawing.Point(3, 3);
            this.kappa.Name = "kappa";
            this.kappa.Size = new System.Drawing.Size(30, 30);
            this.kappa.TabIndex = 0;
            this.kappa.UseVisualStyleBackColor = true;
            this.kappa.Click += new System.EventHandler(this.kappa_Click);
            // 
            // smile
            // 
            this.smile.FlatAppearance.BorderSize = 0;
            this.smile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.smile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.smile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smile.Image = ((System.Drawing.Image)(resources.GetObject("smile.Image")));
            this.smile.Location = new System.Drawing.Point(39, 3);
            this.smile.Name = "smile";
            this.smile.Size = new System.Drawing.Size(30, 30);
            this.smile.TabIndex = 0;
            this.smile.UseVisualStyleBackColor = true;
            this.smile.Click += new System.EventHandler(this.smile_Click);
            // 
            // sad
            // 
            this.sad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sad.FlatAppearance.BorderSize = 0;
            this.sad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sad.Image = ((System.Drawing.Image)(resources.GetObject("sad.Image")));
            this.sad.Location = new System.Drawing.Point(75, 3);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(30, 30);
            this.sad.TabIndex = 0;
            this.sad.UseVisualStyleBackColor = true;
            this.sad.Click += new System.EventHandler(this.sad_Click);
            // 
            // happy
            // 
            this.happy.FlatAppearance.BorderSize = 0;
            this.happy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.happy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.happy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.happy.Image = ((System.Drawing.Image)(resources.GetObject("happy.Image")));
            this.happy.Location = new System.Drawing.Point(111, 3);
            this.happy.Name = "happy";
            this.happy.Size = new System.Drawing.Size(30, 30);
            this.happy.TabIndex = 0;
            this.happy.UseVisualStyleBackColor = true;
            this.happy.Click += new System.EventHandler(this.happy_Click);
            // 
            // cring
            // 
            this.cring.FlatAppearance.BorderSize = 0;
            this.cring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.cring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cring.Image = ((System.Drawing.Image)(resources.GetObject("cring.Image")));
            this.cring.Location = new System.Drawing.Point(3, 39);
            this.cring.Name = "cring";
            this.cring.Size = new System.Drawing.Size(30, 30);
            this.cring.TabIndex = 0;
            this.cring.UseVisualStyleBackColor = true;
            this.cring.Click += new System.EventHandler(this.cring_Click);
            // 
            // me
            // 
            this.me.FlatAppearance.BorderSize = 0;
            this.me.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.me.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.me.Image = ((System.Drawing.Image)(resources.GetObject("me.Image")));
            this.me.Location = new System.Drawing.Point(39, 39);
            this.me.Name = "me";
            this.me.Size = new System.Drawing.Size(30, 30);
            this.me.TabIndex = 0;
            this.me.UseVisualStyleBackColor = true;
            this.me.Click += new System.EventHandler(this.me_Click);
            // 
            // scream
            // 
            this.scream.FlatAppearance.BorderSize = 0;
            this.scream.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.scream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scream.Image = ((System.Drawing.Image)(resources.GetObject("scream.Image")));
            this.scream.Location = new System.Drawing.Point(75, 39);
            this.scream.Name = "scream";
            this.scream.Size = new System.Drawing.Size(30, 30);
            this.scream.TabIndex = 0;
            this.scream.UseVisualStyleBackColor = true;
            this.scream.Click += new System.EventHandler(this.scream_Click);
            // 
            // whut
            // 
            this.whut.FlatAppearance.BorderSize = 0;
            this.whut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.whut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whut.Image = ((System.Drawing.Image)(resources.GetObject("whut.Image")));
            this.whut.Location = new System.Drawing.Point(111, 39);
            this.whut.Name = "whut";
            this.whut.Size = new System.Drawing.Size(30, 30);
            this.whut.TabIndex = 0;
            this.whut.UseVisualStyleBackColor = true;
            this.whut.Click += new System.EventHandler(this.whut_Click);
            // 
            // wow
            // 
            this.wow.FlatAppearance.BorderSize = 0;
            this.wow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.wow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wow.Image = ((System.Drawing.Image)(resources.GetObject("wow.Image")));
            this.wow.Location = new System.Drawing.Point(3, 75);
            this.wow.Name = "wow";
            this.wow.Size = new System.Drawing.Size(30, 30);
            this.wow.TabIndex = 0;
            this.wow.UseVisualStyleBackColor = true;
            this.wow.Click += new System.EventHandler(this.wow_Click);
            // 
            // wink
            // 
            this.wink.FlatAppearance.BorderSize = 0;
            this.wink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.wink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wink.Image = ((System.Drawing.Image)(resources.GetObject("wink.Image")));
            this.wink.Location = new System.Drawing.Point(39, 75);
            this.wink.Name = "wink";
            this.wink.Size = new System.Drawing.Size(30, 30);
            this.wink.TabIndex = 0;
            this.wink.UseVisualStyleBackColor = true;
            this.wink.Click += new System.EventHandler(this.wink_Click);
            // 
            // smush
            // 
            this.smush.FlatAppearance.BorderSize = 0;
            this.smush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.smush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smush.Image = ((System.Drawing.Image)(resources.GetObject("smush.Image")));
            this.smush.Location = new System.Drawing.Point(75, 75);
            this.smush.Name = "smush";
            this.smush.Size = new System.Drawing.Size(30, 30);
            this.smush.TabIndex = 0;
            this.smush.UseVisualStyleBackColor = true;
            this.smush.Click += new System.EventHandler(this.smush_Click);
            // 
            // like
            // 
            this.like.FlatAppearance.BorderSize = 0;
            this.like.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.like.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.like.Image = global::clientSide.Properties.Resources.like;
            this.like.Location = new System.Drawing.Point(111, 75);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(30, 30);
            this.like.TabIndex = 0;
            this.like.UseVisualStyleBackColor = true;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // heart
            // 
            this.heart.FlatAppearance.BorderSize = 0;
            this.heart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.heart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heart.Image = global::clientSide.Properties.Resources.heart;
            this.heart.Location = new System.Drawing.Point(3, 111);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(30, 30);
            this.heart.TabIndex = 0;
            this.heart.UseVisualStyleBackColor = true;
            this.heart.Click += new System.EventHandler(this.heart_Click);
            // 
            // faiñ
            // 
            this.faiñ.FlatAppearance.BorderSize = 0;
            this.faiñ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.faiñ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faiñ.Image = global::clientSide.Properties.Resources.fail;
            this.faiñ.Location = new System.Drawing.Point(39, 111);
            this.faiñ.Name = "faiñ";
            this.faiñ.Size = new System.Drawing.Size(30, 30);
            this.faiñ.TabIndex = 0;
            this.faiñ.UseVisualStyleBackColor = true;
            this.faiñ.Click += new System.EventHandler(this.faiñ_Click);
            // 
            // sleepi
            // 
            this.sleepi.FlatAppearance.BorderSize = 0;
            this.sleepi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sleepi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sleepi.Image = global::clientSide.Properties.Resources.boring;
            this.sleepi.Location = new System.Drawing.Point(75, 111);
            this.sleepi.Name = "sleepi";
            this.sleepi.Size = new System.Drawing.Size(30, 30);
            this.sleepi.TabIndex = 0;
            this.sleepi.UseVisualStyleBackColor = true;
            this.sleepi.Click += new System.EventHandler(this.sleepi_Click);
            // 
            // bcwarior
            // 
            this.bcwarior.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bcwarior.FlatAppearance.BorderSize = 0;
            this.bcwarior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bcwarior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bcwarior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcwarior.Image = global::clientSide.Properties.Resources.pink;
            this.bcwarior.Location = new System.Drawing.Point(111, 111);
            this.bcwarior.Name = "bcwarior";
            this.bcwarior.Size = new System.Drawing.Size(30, 30);
            this.bcwarior.TabIndex = 0;
            this.bcwarior.UseVisualStyleBackColor = true;
            this.bcwarior.Click += new System.EventHandler(this.bcwarior_Click);
            // 
            // death
            // 
            this.death.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.death.FlatAppearance.BorderSize = 0;
            this.death.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.death.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.death.Image = global::clientSide.Properties.Resources.dead;
            this.death.Location = new System.Drawing.Point(3, 147);
            this.death.Name = "death";
            this.death.Size = new System.Drawing.Size(30, 30);
            this.death.TabIndex = 0;
            this.death.UseVisualStyleBackColor = true;
            this.death.Click += new System.EventHandler(this.death_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 339);
            this.Controls.Add(this.btnjuego);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.convprivada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emotesmenu);
            this.Controls.Add(this.clientes_grid);
            this.Controls.Add(this.textToSend_txt2);
            this.Controls.Add(this.emotes);
            this.Controls.Add(this.zumbido);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.emotesmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientes_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox conversation;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.TextBox textToSend_txt;
        private System.Windows.Forms.RichTextBox textToSend_txt2;
        private System.Windows.Forms.Button zumbido;
        private System.Windows.Forms.Button emotes;
        private System.Windows.Forms.FlowLayoutPanel emotesmenu;
        private System.Windows.Forms.Button kappa;
        private System.Windows.Forms.Button smile;
        private System.Windows.Forms.Button sad;
        private System.Windows.Forms.Button happy;
        private System.Windows.Forms.Button cring;
        private System.Windows.Forms.Button me;
        private System.Windows.Forms.Button scream;
        private System.Windows.Forms.Button whut;
        private System.Windows.Forms.Button wow;
        private System.Windows.Forms.Button wink;
        private System.Windows.Forms.Button smush;
        private System.Windows.Forms.Button like;
        private System.Windows.Forms.Button heart;
        private System.Windows.Forms.Button faiñ;
        private System.Windows.Forms.Button sleepi;
        private System.Windows.Forms.Button bcwarior;
        private System.Windows.Forms.Button death;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convprivada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView clientes_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_IP;
        private System.Windows.Forms.Button btnjuego;
    }
}


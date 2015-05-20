namespace clientSide
{
    partial class Juego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.playerList = new System.Windows.Forms.ListBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.turno_label = new System.Windows.Forms.Label();
            this.diceBut = new System.Windows.Forms.Button();
            this.player3_image = new System.Windows.Forms.PictureBox();
            this.player2_image = new System.Windows.Forms.PictureBox();
            this.player1_image = new System.Windows.Forms.PictureBox();
            this.dice_image = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.diceList_image = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player3_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerList
            // 
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(520, 24);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(120, 95);
            this.playerList.TabIndex = 17;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(597, 455);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 16;
            this.reset_btn.Text = "Reiniciar";
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // turno_label
            // 
            this.turno_label.AutoSize = true;
            this.turno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turno_label.Location = new System.Drawing.Point(505, 305);
            this.turno_label.Name = "turno_label";
            this.turno_label.Size = new System.Drawing.Size(155, 24);
            this.turno_label.TabIndex = 15;
            this.turno_label.Text = "Turno: Jugador 1";
            // 
            // diceBut
            // 
            this.diceBut.Location = new System.Drawing.Point(543, 268);
            this.diceBut.Name = "diceBut";
            this.diceBut.Size = new System.Drawing.Size(75, 23);
            this.diceBut.TabIndex = 11;
            this.diceBut.Text = "Tirar dado";
            this.diceBut.UseVisualStyleBackColor = true;
            // 
            // player3_image
            // 
            this.player3_image.Image = ((System.Drawing.Image)(resources.GetObject("player3_image.Image")));
            this.player3_image.Location = new System.Drawing.Point(24, 409);
            this.player3_image.Name = "player3_image";
            this.player3_image.Size = new System.Drawing.Size(25, 25);
            this.player3_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player3_image.TabIndex = 14;
            this.player3_image.TabStop = false;
            // 
            // player2_image
            // 
            this.player2_image.Image = ((System.Drawing.Image)(resources.GetObject("player2_image.Image")));
            this.player2_image.Location = new System.Drawing.Point(38, 423);
            this.player2_image.Name = "player2_image";
            this.player2_image.Size = new System.Drawing.Size(25, 25);
            this.player2_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2_image.TabIndex = 13;
            this.player2_image.TabStop = false;
            // 
            // player1_image
            // 
            this.player1_image.Image = ((System.Drawing.Image)(resources.GetObject("player1_image.Image")));
            this.player1_image.Location = new System.Drawing.Point(49, 435);
            this.player1_image.Name = "player1_image";
            this.player1_image.Size = new System.Drawing.Size(25, 25);
            this.player1_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1_image.TabIndex = 12;
            this.player1_image.TabStop = false;
            // 
            // dice_image
            // 
            this.dice_image.Image = ((System.Drawing.Image)(resources.GetObject("dice_image.Image")));
            this.dice_image.Location = new System.Drawing.Point(530, 162);
            this.dice_image.Name = "dice_image";
            this.dice_image.Size = new System.Drawing.Size(100, 100);
            this.dice_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_image.TabIndex = 10;
            this.dice_image.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 466);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // diceList_image
            // 
            this.diceList_image.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.diceList_image.ImageSize = new System.Drawing.Size(16, 16);
            this.diceList_image.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 484);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.turno_label);
            this.Controls.Add(this.player3_image);
            this.Controls.Add(this.player2_image);
            this.Controls.Add(this.player1_image);
            this.Controls.Add(this.diceBut);
            this.Controls.Add(this.dice_image);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Juego";
            this.Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)(this.player3_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label turno_label;
        private System.Windows.Forms.PictureBox player3_image;
        private System.Windows.Forms.PictureBox player2_image;
        private System.Windows.Forms.PictureBox player1_image;
        private System.Windows.Forms.Button diceBut;
        private System.Windows.Forms.PictureBox dice_image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList diceList_image;
    }
}
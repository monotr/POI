namespace serpientesYescaleras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dice_image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.diceList_image = new System.Windows.Forms.ImageList(this.components);
            this.player1_image = new System.Windows.Forms.PictureBox();
            this.player2_image = new System.Windows.Forms.PictureBox();
            this.player3_image = new System.Windows.Forms.PictureBox();
            this.turno_label = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 466);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dice_image
            // 
            this.dice_image.Image = ((System.Drawing.Image)(resources.GetObject("dice_image.Image")));
            this.dice_image.Location = new System.Drawing.Point(518, 150);
            this.dice_image.Name = "dice_image";
            this.dice_image.Size = new System.Drawing.Size(100, 100);
            this.dice_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice_image.TabIndex = 1;
            this.dice_image.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tirar dado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diceList_image
            // 
            this.diceList_image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("diceList_image.ImageStream")));
            this.diceList_image.TransparentColor = System.Drawing.Color.Transparent;
            this.diceList_image.Images.SetKeyName(0, "d1.png");
            this.diceList_image.Images.SetKeyName(1, "d2.png");
            this.diceList_image.Images.SetKeyName(2, "d3.png");
            this.diceList_image.Images.SetKeyName(3, "d4.png");
            this.diceList_image.Images.SetKeyName(4, "d5.png");
            this.diceList_image.Images.SetKeyName(5, "d6.png");
            // 
            // player1_image
            // 
            this.player1_image.Image = ((System.Drawing.Image)(resources.GetObject("player1_image.Image")));
            this.player1_image.Location = new System.Drawing.Point(37, 423);
            this.player1_image.Name = "player1_image";
            this.player1_image.Size = new System.Drawing.Size(25, 25);
            this.player1_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1_image.TabIndex = 3;
            this.player1_image.TabStop = false;
            // 
            // player2_image
            // 
            this.player2_image.Image = ((System.Drawing.Image)(resources.GetObject("player2_image.Image")));
            this.player2_image.Location = new System.Drawing.Point(26, 411);
            this.player2_image.Name = "player2_image";
            this.player2_image.Size = new System.Drawing.Size(25, 25);
            this.player2_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2_image.TabIndex = 4;
            this.player2_image.TabStop = false;
            // 
            // player3_image
            // 
            this.player3_image.Image = ((System.Drawing.Image)(resources.GetObject("player3_image.Image")));
            this.player3_image.Location = new System.Drawing.Point(12, 397);
            this.player3_image.Name = "player3_image";
            this.player3_image.Size = new System.Drawing.Size(25, 25);
            this.player3_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player3_image.TabIndex = 5;
            this.player3_image.TabStop = false;
            // 
            // turno_label
            // 
            this.turno_label.AutoSize = true;
            this.turno_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turno_label.Location = new System.Drawing.Point(493, 293);
            this.turno_label.Name = "turno_label";
            this.turno_label.Size = new System.Drawing.Size(155, 24);
            this.turno_label.TabIndex = 6;
            this.turno_label.Text = "Turno: Jugador 1";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(585, 443);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 7;
            this.reset_btn.Text = "Reiniciar";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 472);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.turno_label);
            this.Controls.Add(this.player3_image);
            this.Controls.Add(this.player2_image);
            this.Controls.Add(this.player1_image);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dice_image);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox dice_image;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList diceList_image;
        private System.Windows.Forms.PictureBox player1_image;
        private System.Windows.Forms.PictureBox player2_image;
        private System.Windows.Forms.PictureBox player3_image;
        private System.Windows.Forms.Label turno_label;
        private System.Windows.Forms.Button reset_btn;

    }
}


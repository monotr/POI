namespace webcam_test
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EspacioCamara = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Estado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(458, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Estado
            // 
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(41, 17);
            this.Estado.Text = "Listo...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Cámara";
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(120, 338);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(231, 21);
            this.cbxDispositivos.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(366, 338);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EspacioCamara);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 320);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Webcam";
            // 
            // EspacioCamara
            // 
            this.EspacioCamara.Location = new System.Drawing.Point(6, 19);
            this.EspacioCamara.Name = "EspacioCamara";
            this.EspacioCamara.Size = new System.Drawing.Size(414, 295);
            this.EspacioCamara.TabIndex = 0;
            this.EspacioCamara.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cbxDispositivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Webcam";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox EspacioCamara;
        private System.Windows.Forms.ToolStripStatusLabel Estado;
    }
}


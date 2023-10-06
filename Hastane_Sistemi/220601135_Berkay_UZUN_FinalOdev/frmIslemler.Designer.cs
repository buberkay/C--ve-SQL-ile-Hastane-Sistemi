namespace _220601135_Berkay_UZUN_FinalOdev
{
    partial class frmIslemler
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
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnIlac = new System.Windows.Forms.Button();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.btnRecete = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.Black;
            this.btnHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHasta.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHasta.Location = new System.Drawing.Point(166, 96);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(143, 78);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.Text = "Hasta İşlemleri";
            this.btnHasta.UseVisualStyleBackColor = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnIlac
            // 
            this.btnIlac.BackColor = System.Drawing.Color.Black;
            this.btnIlac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlac.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIlac.Location = new System.Drawing.Point(511, 329);
            this.btnIlac.Name = "btnIlac";
            this.btnIlac.Size = new System.Drawing.Size(143, 78);
            this.btnIlac.TabIndex = 1;
            this.btnIlac.Text = "İlaç İşlemleri";
            this.btnIlac.UseVisualStyleBackColor = false;
            this.btnIlac.Click += new System.EventHandler(this.btnIlac_Click);
            // 
            // btnMuayene
            // 
            this.btnMuayene.BackColor = System.Drawing.Color.Black;
            this.btnMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayene.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMuayene.Location = new System.Drawing.Point(511, 96);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Size = new System.Drawing.Size(143, 78);
            this.btnMuayene.TabIndex = 2;
            this.btnMuayene.Text = "Muayene Ekle";
            this.btnMuayene.UseVisualStyleBackColor = false;
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // btnRecete
            // 
            this.btnRecete.BackColor = System.Drawing.Color.Black;
            this.btnRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRecete.Location = new System.Drawing.Point(166, 329);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(143, 78);
            this.btnRecete.TabIndex = 3;
            this.btnRecete.Text = "Reçete Yaz";
            this.btnRecete.UseVisualStyleBackColor = false;
            this.btnRecete.Click += new System.EventHandler(this.btnRecete_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Salmon;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(772, 471);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(98, 36);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_220601135_Berkay_UZUN_FinalOdev.Properties.Resources.hastane;
            this.pictureBox1.Location = new System.Drawing.Point(332, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(910, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.btnMuayene);
            this.Controls.Add(this.btnIlac);
            this.Controls.Add(this.btnHasta);
            this.Name = "frmIslemler";
            this.Text = "Islemler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnIlac;
        private System.Windows.Forms.Button btnMuayene;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace _220601135_Berkay_UZUN_FinalOdev
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabGirisKayit = new System.Windows.Forms.TabControl();
            this.tabKAyitSayfa = new System.Windows.Forms.TabPage();
            this.btnKayit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifreKayit = new System.Windows.Forms.TextBox();
            this.txtTCKayit = new System.Windows.Forms.MaskedTextBox();
            this.tabGirisSayfa = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifreGiris = new System.Windows.Forms.TextBox();
            this.txtTCGiris = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabGirisKayit.SuspendLayout();
            this.tabKAyitSayfa.SuspendLayout();
            this.tabGirisSayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGirisKayit
            // 
            this.tabGirisKayit.Controls.Add(this.tabKAyitSayfa);
            this.tabGirisKayit.Controls.Add(this.tabGirisSayfa);
            this.tabGirisKayit.Location = new System.Drawing.Point(122, 1);
            this.tabGirisKayit.Name = "tabGirisKayit";
            this.tabGirisKayit.SelectedIndex = 0;
            this.tabGirisKayit.Size = new System.Drawing.Size(713, 512);
            this.tabGirisKayit.TabIndex = 0;
            // 
            // tabKAyitSayfa
            // 
            this.tabKAyitSayfa.BackColor = System.Drawing.Color.MistyRose;
            this.tabKAyitSayfa.Controls.Add(this.pictureBox2);
            this.tabKAyitSayfa.Controls.Add(this.btnKayit);
            this.tabKAyitSayfa.Controls.Add(this.label2);
            this.tabKAyitSayfa.Controls.Add(this.label1);
            this.tabKAyitSayfa.Controls.Add(this.txtSifreKayit);
            this.tabKAyitSayfa.Controls.Add(this.txtTCKayit);
            this.tabKAyitSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabKAyitSayfa.Location = new System.Drawing.Point(4, 25);
            this.tabKAyitSayfa.Name = "tabKAyitSayfa";
            this.tabKAyitSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tabKAyitSayfa.Size = new System.Drawing.Size(705, 483);
            this.tabKAyitSayfa.TabIndex = 0;
            this.tabKAyitSayfa.Text = "Kayıt Ol";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.LightCyan;
            this.btnKayit.Location = new System.Drawing.Point(366, 366);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(83, 41);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(248, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(180, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtSifreKayit
            // 
            this.txtSifreKayit.Location = new System.Drawing.Point(332, 314);
            this.txtSifreKayit.Name = "txtSifreKayit";
            this.txtSifreKayit.Size = new System.Drawing.Size(148, 22);
            this.txtSifreKayit.TabIndex = 1;
            // 
            // txtTCKayit
            // 
            this.txtTCKayit.Location = new System.Drawing.Point(332, 243);
            this.txtTCKayit.Mask = "00000";
            this.txtTCKayit.Name = "txtTCKayit";
            this.txtTCKayit.Size = new System.Drawing.Size(148, 22);
            this.txtTCKayit.TabIndex = 0;
            this.txtTCKayit.ValidatingType = typeof(int);
            // 
            // tabGirisSayfa
            // 
            this.tabGirisSayfa.BackColor = System.Drawing.Color.MistyRose;
            this.tabGirisSayfa.Controls.Add(this.pictureBox1);
            this.tabGirisSayfa.Controls.Add(this.btnGiris);
            this.tabGirisSayfa.Controls.Add(this.label3);
            this.tabGirisSayfa.Controls.Add(this.label4);
            this.tabGirisSayfa.Controls.Add(this.txtSifreGiris);
            this.tabGirisSayfa.Controls.Add(this.txtTCGiris);
            this.tabGirisSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabGirisSayfa.Location = new System.Drawing.Point(4, 25);
            this.tabGirisSayfa.Name = "tabGirisSayfa";
            this.tabGirisSayfa.Padding = new System.Windows.Forms.Padding(3);
            this.tabGirisSayfa.Size = new System.Drawing.Size(705, 483);
            this.tabGirisSayfa.TabIndex = 1;
            this.tabGirisSayfa.Text = "Giriş Yap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_220601135_Berkay_UZUN_FinalOdev.Properties.Resources.profileicon;
            this.pictureBox1.Location = new System.Drawing.Point(310, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(322, 397);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(83, 40);
            this.btnGiris.TabIndex = 11;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(347, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(318, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC Kimlik No";
            // 
            // txtSifreGiris
            // 
            this.txtSifreGiris.Location = new System.Drawing.Point(297, 346);
            this.txtSifreGiris.Name = "txtSifreGiris";
            this.txtSifreGiris.Size = new System.Drawing.Size(148, 22);
            this.txtSifreGiris.TabIndex = 8;
            // 
            // txtTCGiris
            // 
            this.txtTCGiris.Location = new System.Drawing.Point(297, 256);
            this.txtTCGiris.Mask = "00000";
            this.txtTCGiris.Name = "txtTCGiris";
            this.txtTCGiris.Size = new System.Drawing.Size(148, 22);
            this.txtTCGiris.TabIndex = 7;
            this.txtTCGiris.ValidatingType = typeof(int);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_220601135_Berkay_UZUN_FinalOdev.Properties.Resources.profileicon;
            this.pictureBox2.Location = new System.Drawing.Point(345, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::_220601135_Berkay_UZUN_FinalOdev.Properties.Resources.istockphoto_997921658_612x612;
            this.ClientSize = new System.Drawing.Size(1000, 572);
            this.Controls.Add(this.tabGirisKayit);
            this.Name = "frmMain";
            this.Text = "Personel Giriş Ekranı";
            this.tabGirisKayit.ResumeLayout(false);
            this.tabKAyitSayfa.ResumeLayout(false);
            this.tabKAyitSayfa.PerformLayout();
            this.tabGirisSayfa.ResumeLayout(false);
            this.tabGirisSayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGirisKayit;
        private System.Windows.Forms.TabPage tabKAyitSayfa;
        private System.Windows.Forms.TabPage tabGirisSayfa;
        private System.Windows.Forms.TextBox txtSifreKayit;
        private System.Windows.Forms.MaskedTextBox txtTCKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifreGiris;
        private System.Windows.Forms.MaskedTextBox txtTCGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


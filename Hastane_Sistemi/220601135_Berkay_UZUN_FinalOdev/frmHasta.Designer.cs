namespace _220601135_Berkay_UZUN_FinalOdev
{
    partial class frmHasta
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
            this.btnHastaGoster = new System.Windows.Forms.Button();
            this.dtHastalar = new System.Windows.Forms.DataGridView();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtMedeniDurum = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKayitOlustur = new System.Windows.Forms.Button();
            this.boxKayit = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.boxHastaninIlaclari = new System.Windows.Forms.GroupBox();
            this.btnHastaninIlaclarınıGoster = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHastaninIlaclari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtHastalar)).BeginInit();
            this.boxKayit.SuspendLayout();
            this.boxHastaninIlaclari.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHastaGoster
            // 
            this.btnHastaGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGoster.Location = new System.Drawing.Point(789, 544);
            this.btnHastaGoster.Name = "btnHastaGoster";
            this.btnHastaGoster.Size = new System.Drawing.Size(181, 63);
            this.btnHastaGoster.TabIndex = 0;
            this.btnHastaGoster.Text = "Kayıtlı Hastaları Göster";
            this.btnHastaGoster.UseVisualStyleBackColor = true;
            this.btnHastaGoster.Click += new System.EventHandler(this.btnHastaGoster_Click);
            // 
            // dtHastalar
            // 
            this.dtHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHastalar.Location = new System.Drawing.Point(12, 2);
            this.dtHastalar.Name = "dtHastalar";
            this.dtHastalar.RowHeadersWidth = 51;
            this.dtHastalar.RowTemplate.Height = 24;
            this.dtHastalar.Size = new System.Drawing.Size(1208, 288);
            this.dtHastalar.TabIndex = 1;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(239, 33);
            this.txtTC.Mask = "000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(107, 27);
            this.txtTC.TabIndex = 3;
            this.txtTC.ValidatingType = typeof(int);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(610, 192);
            this.txtTelefon.Mask = "000000000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(107, 27);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(239, 135);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(107, 27);
            this.txtSoyad.TabIndex = 5;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(239, 192);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(107, 27);
            this.txtDogumYeri.TabIndex = 6;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Location = new System.Drawing.Point(610, 35);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(107, 27);
            this.txtDogumTarihi.TabIndex = 7;
            // 
            // txtMedeniDurum
            // 
            this.txtMedeniDurum.Location = new System.Drawing.Point(610, 86);
            this.txtMedeniDurum.Name = "txtMedeniDurum";
            this.txtMedeniDurum.Size = new System.Drawing.Size(107, 27);
            this.txtMedeniDurum.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(610, 137);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(107, 27);
            this.txtAdres.TabIndex = 9;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(239, 84);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(107, 27);
            this.txtAd.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "TC Kimlik numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(410, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(25, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Doğum Yeri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(410, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Medeni Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(410, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Doğum Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(410, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Telefon Numarası:";
            // 
            // btnKayitOlustur
            // 
            this.btnKayitOlustur.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKayitOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitOlustur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKayitOlustur.Location = new System.Drawing.Point(636, 245);
            this.btnKayitOlustur.Name = "btnKayitOlustur";
            this.btnKayitOlustur.Size = new System.Drawing.Size(81, 38);
            this.btnKayitOlustur.TabIndex = 19;
            this.btnKayitOlustur.Text = "Ekle";
            this.btnKayitOlustur.UseVisualStyleBackColor = false;
            this.btnKayitOlustur.Click += new System.EventHandler(this.btnKayitOlustur_Click);
            // 
            // boxKayit
            // 
            this.boxKayit.BackColor = System.Drawing.Color.PeachPuff;
            this.boxKayit.Controls.Add(this.btnKayitOlustur);
            this.boxKayit.Controls.Add(this.label8);
            this.boxKayit.Controls.Add(this.label7);
            this.boxKayit.Controls.Add(this.label6);
            this.boxKayit.Controls.Add(this.label5);
            this.boxKayit.Controls.Add(this.label4);
            this.boxKayit.Controls.Add(this.label3);
            this.boxKayit.Controls.Add(this.label2);
            this.boxKayit.Controls.Add(this.label1);
            this.boxKayit.Controls.Add(this.txtAd);
            this.boxKayit.Controls.Add(this.txtAdres);
            this.boxKayit.Controls.Add(this.txtMedeniDurum);
            this.boxKayit.Controls.Add(this.txtDogumTarihi);
            this.boxKayit.Controls.Add(this.txtDogumYeri);
            this.boxKayit.Controls.Add(this.txtSoyad);
            this.boxKayit.Controls.Add(this.txtTelefon);
            this.boxKayit.Controls.Add(this.txtTC);
            this.boxKayit.Cursor = System.Windows.Forms.Cursors.Default;
            this.boxKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxKayit.Location = new System.Drawing.Point(12, 313);
            this.boxKayit.Name = "boxKayit";
            this.boxKayit.Size = new System.Drawing.Size(749, 306);
            this.boxKayit.TabIndex = 20;
            this.boxKayit.TabStop = false;
            this.boxKayit.Text = "Kayıt Oluştur";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeriDon.Location = new System.Drawing.Point(1078, 568);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(142, 38);
            this.btnGeriDon.TabIndex = 20;
            this.btnGeriDon.Text = "Ana Sayfa";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // boxHastaninIlaclari
            // 
            this.boxHastaninIlaclari.BackColor = System.Drawing.Color.PeachPuff;
            this.boxHastaninIlaclari.Controls.Add(this.btnHastaninIlaclarınıGoster);
            this.boxHastaninIlaclari.Controls.Add(this.label9);
            this.boxHastaninIlaclari.Controls.Add(this.txtHastaninIlaclari);
            this.boxHastaninIlaclari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxHastaninIlaclari.Location = new System.Drawing.Point(827, 313);
            this.boxHastaninIlaclari.Name = "boxHastaninIlaclari";
            this.boxHastaninIlaclari.Size = new System.Drawing.Size(393, 156);
            this.boxHastaninIlaclari.TabIndex = 33;
            this.boxHastaninIlaclari.TabStop = false;
            this.boxHastaninIlaclari.Text = "Hastanın kullandığı ilaçlar";
            // 
            // btnHastaninIlaclarınıGoster
            // 
            this.btnHastaninIlaclarınıGoster.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnHastaninIlaclarınıGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaninIlaclarınıGoster.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHastaninIlaclarınıGoster.Location = new System.Drawing.Point(182, 112);
            this.btnHastaninIlaclarınıGoster.Name = "btnHastaninIlaclarınıGoster";
            this.btnHastaninIlaclarınıGoster.Size = new System.Drawing.Size(193, 38);
            this.btnHastaninIlaclarınıGoster.TabIndex = 30;
            this.btnHastaninIlaclarınıGoster.Text = "Göster";
            this.btnHastaninIlaclarınıGoster.UseVisualStyleBackColor = false;
            this.btnHastaninIlaclarınıGoster.Click += new System.EventHandler(this.btnHastaninIlaclarınıGoster_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(16, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "TC Kimlik numarası:";
            // 
            // txtHastaninIlaclari
            // 
            this.txtHastaninIlaclari.Location = new System.Drawing.Point(268, 37);
            this.txtHastaninIlaclari.Name = "txtHastaninIlaclari";
            this.txtHastaninIlaclari.Size = new System.Drawing.Size(107, 22);
            this.txtHastaninIlaclari.TabIndex = 30;
            this.txtHastaninIlaclari.TextChanged += new System.EventHandler(this.txtHastaninIlaclari_TextChanged);
            // 
            // frmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1228, 645);
            this.Controls.Add(this.boxHastaninIlaclari);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.boxKayit);
            this.Controls.Add(this.dtHastalar);
            this.Controls.Add(this.btnHastaGoster);
            this.Name = "frmHasta";
            this.Text = "Hasta İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dtHastalar)).EndInit();
            this.boxKayit.ResumeLayout(false);
            this.boxKayit.PerformLayout();
            this.boxHastaninIlaclari.ResumeLayout(false);
            this.boxHastaninIlaclari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGoster;
        private System.Windows.Forms.DataGridView dtHastalar;
        private System.Windows.Forms.MaskedTextBox txtTC;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtDogumTarihi;
        private System.Windows.Forms.TextBox txtMedeniDurum;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKayitOlustur;
        private System.Windows.Forms.GroupBox boxKayit;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox boxHastaninIlaclari;
        private System.Windows.Forms.Button btnHastaninIlaclarınıGoster;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHastaninIlaclari;
    }
}
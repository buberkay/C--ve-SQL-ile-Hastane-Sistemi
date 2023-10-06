namespace _220601135_Berkay_UZUN_FinalOdev
{
    partial class frmMuayene
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
            this.dtMuayene = new System.Windows.Forms.DataGridView();
            this.btnMuayeneGoster = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.boxMuayene = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMuayeneNo = new System.Windows.Forms.TextBox();
            this.txtReceteNo = new System.Windows.Forms.TextBox();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.txtTanı = new System.Windows.Forms.TextBox();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.picMuayene = new System.Windows.Forms.PictureBox();
            this.btnMuayeneEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMuayene)).BeginInit();
            this.boxMuayene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMuayene)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMuayene
            // 
            this.dtMuayene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMuayene.Location = new System.Drawing.Point(2, 0);
            this.dtMuayene.Name = "dtMuayene";
            this.dtMuayene.RowHeadersWidth = 51;
            this.dtMuayene.RowTemplate.Height = 24;
            this.dtMuayene.Size = new System.Drawing.Size(1241, 297);
            this.dtMuayene.TabIndex = 2;
            // 
            // btnMuayeneGoster
            // 
            this.btnMuayeneGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayeneGoster.Location = new System.Drawing.Point(815, 324);
            this.btnMuayeneGoster.Name = "btnMuayeneGoster";
            this.btnMuayeneGoster.Size = new System.Drawing.Size(219, 83);
            this.btnMuayeneGoster.TabIndex = 3;
            this.btnMuayeneGoster.Text = "Muayene Raporlarını Göster";
            this.btnMuayeneGoster.UseVisualStyleBackColor = true;
            this.btnMuayeneGoster.Click += new System.EventHandler(this.btnMuayeneGoster_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeriDon.Location = new System.Drawing.Point(1092, 551);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(142, 38);
            this.btnGeriDon.TabIndex = 21;
            this.btnGeriDon.Text = "Ana Sayfa";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // boxMuayene
            // 
            this.boxMuayene.BackColor = System.Drawing.Color.PeachPuff;
            this.boxMuayene.Controls.Add(this.btnMuayeneEkle);
            this.boxMuayene.Controls.Add(this.label7);
            this.boxMuayene.Controls.Add(this.label6);
            this.boxMuayene.Controls.Add(this.label5);
            this.boxMuayene.Controls.Add(this.label4);
            this.boxMuayene.Controls.Add(this.label3);
            this.boxMuayene.Controls.Add(this.label2);
            this.boxMuayene.Controls.Add(this.label1);
            this.boxMuayene.Controls.Add(this.txtMuayeneNo);
            this.boxMuayene.Controls.Add(this.txtReceteNo);
            this.boxMuayene.Controls.Add(this.txtTedavi);
            this.boxMuayene.Controls.Add(this.txtTanı);
            this.boxMuayene.Controls.Add(this.txtSikayet);
            this.boxMuayene.Controls.Add(this.txtTarih);
            this.boxMuayene.Controls.Add(this.txtTC);
            this.boxMuayene.Cursor = System.Windows.Forms.Cursors.Default;
            this.boxMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxMuayene.Location = new System.Drawing.Point(12, 303);
            this.boxMuayene.Name = "boxMuayene";
            this.boxMuayene.Size = new System.Drawing.Size(749, 306);
            this.boxMuayene.TabIndex = 22;
            this.boxMuayene.TabStop = false;
            this.boxMuayene.Text = "Muayene Ekle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(410, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tanı: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(410, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tedavi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(25, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şikayet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(410, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Reçete Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(25, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "TC Kimlik Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Muayene numarası:";
            // 
            // txtMuayeneNo
            // 
            this.txtMuayeneNo.Location = new System.Drawing.Point(263, 35);
            this.txtMuayeneNo.Name = "txtMuayeneNo";
            this.txtMuayeneNo.Size = new System.Drawing.Size(107, 27);
            this.txtMuayeneNo.TabIndex = 10;
            // 
            // txtReceteNo
            // 
            this.txtReceteNo.Location = new System.Drawing.Point(610, 137);
            this.txtReceteNo.Name = "txtReceteNo";
            this.txtReceteNo.Size = new System.Drawing.Size(107, 27);
            this.txtReceteNo.TabIndex = 9;
            // 
            // txtTedavi
            // 
            this.txtTedavi.Location = new System.Drawing.Point(610, 86);
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(107, 27);
            this.txtTedavi.TabIndex = 8;
            // 
            // txtTanı
            // 
            this.txtTanı.Location = new System.Drawing.Point(610, 35);
            this.txtTanı.Name = "txtTanı";
            this.txtTanı.Size = new System.Drawing.Size(107, 27);
            this.txtTanı.TabIndex = 7;
            // 
            // txtSikayet
            // 
            this.txtSikayet.Location = new System.Drawing.Point(263, 192);
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(107, 27);
            this.txtSikayet.TabIndex = 6;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(263, 135);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(107, 27);
            this.txtTarih.TabIndex = 5;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(263, 83);
            this.txtTC.Mask = "000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(107, 27);
            this.txtTC.TabIndex = 3;
            this.txtTC.ValidatingType = typeof(int);
            // 
            // picMuayene
            // 
            this.picMuayene.Image = global::_220601135_Berkay_UZUN_FinalOdev.Properties.Resources.steteskop;
            this.picMuayene.Location = new System.Drawing.Point(1088, 385);
            this.picMuayene.Name = "picMuayene";
            this.picMuayene.Size = new System.Drawing.Size(146, 130);
            this.picMuayene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMuayene.TabIndex = 32;
            this.picMuayene.TabStop = false;
            // 
            // btnMuayeneEkle
            // 
            this.btnMuayeneEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMuayeneEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuayeneEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMuayeneEkle.Location = new System.Drawing.Point(636, 237);
            this.btnMuayeneEkle.Name = "btnMuayeneEkle";
            this.btnMuayeneEkle.Size = new System.Drawing.Size(81, 38);
            this.btnMuayeneEkle.TabIndex = 33;
            this.btnMuayeneEkle.Text = "Ekle";
            this.btnMuayeneEkle.UseVisualStyleBackColor = false;
            this.btnMuayeneEkle.Click += new System.EventHandler(this.btnMuayeneEkle_Click);
            // 
            // frmMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1246, 615);
            this.Controls.Add(this.picMuayene);
            this.Controls.Add(this.boxMuayene);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnMuayeneGoster);
            this.Controls.Add(this.dtMuayene);
            this.Name = "frmMuayene";
            this.Text = "Muayene İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dtMuayene)).EndInit();
            this.boxMuayene.ResumeLayout(false);
            this.boxMuayene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMuayene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMuayene;
        private System.Windows.Forms.Button btnMuayeneGoster;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox boxMuayene;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMuayeneNo;
        private System.Windows.Forms.TextBox txtReceteNo;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.TextBox txtTanı;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.MaskedTextBox txtTC;
        private System.Windows.Forms.PictureBox picMuayene;
        private System.Windows.Forms.Button btnMuayeneEkle;
    }
}
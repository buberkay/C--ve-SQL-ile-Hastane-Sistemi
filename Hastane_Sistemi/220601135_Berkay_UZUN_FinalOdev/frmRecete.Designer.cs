namespace _220601135_Berkay_UZUN_FinalOdev
{
    partial class frmRecete
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
            this.dtRecete = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnRecete = new System.Windows.Forms.Button();
            this.boxReceteOlustur = new System.Windows.Forms.GroupBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceteNo = new System.Windows.Forms.TextBox();
            this.btnReceteOlustur = new System.Windows.Forms.Button();
            this.boxIlacEkle = new System.Windows.Forms.GroupBox();
            this.btnIlacYaz = new System.Windows.Forms.Button();
            this.txtIlacNo = new System.Windows.Forms.TextBox();
            this.txtReceteNoIlac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIlacAdet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtRecete)).BeginInit();
            this.boxReceteOlustur.SuspendLayout();
            this.boxIlacEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtRecete
            // 
            this.dtRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRecete.Location = new System.Drawing.Point(-1, 0);
            this.dtRecete.Name = "dtRecete";
            this.dtRecete.RowHeadersWidth = 51;
            this.dtRecete.RowTemplate.Height = 24;
            this.dtRecete.Size = new System.Drawing.Size(1148, 286);
            this.dtRecete.TabIndex = 3;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeriDon.Location = new System.Drawing.Point(993, 567);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(142, 38);
            this.btnGeriDon.TabIndex = 22;
            this.btnGeriDon.Text = "Ana Sayfa";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnRecete
            // 
            this.btnRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecete.Location = new System.Drawing.Point(989, 302);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(146, 63);
            this.btnRecete.TabIndex = 23;
            this.btnRecete.Text = "Reçeteleri Göster";
            this.btnRecete.UseVisualStyleBackColor = true;
            this.btnRecete.Click += new System.EventHandler(this.btnRecete_Click);
            // 
            // boxReceteOlustur
            // 
            this.boxReceteOlustur.BackColor = System.Drawing.Color.PeachPuff;
            this.boxReceteOlustur.Controls.Add(this.btnReceteOlustur);
            this.boxReceteOlustur.Controls.Add(this.txtTarih);
            this.boxReceteOlustur.Controls.Add(this.txtReceteNo);
            this.boxReceteOlustur.Controls.Add(this.label2);
            this.boxReceteOlustur.Controls.Add(this.label1);
            this.boxReceteOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxReceteOlustur.Location = new System.Drawing.Point(40, 339);
            this.boxReceteOlustur.Name = "boxReceteOlustur";
            this.boxReceteOlustur.Size = new System.Drawing.Size(423, 189);
            this.boxReceteOlustur.TabIndex = 28;
            this.boxReceteOlustur.TabStop = false;
            this.boxReceteOlustur.Text = "Reçete Oluştur";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(266, 96);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(107, 24);
            this.txtTarih.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Reçete numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tarih:";
            // 
            // txtReceteNo
            // 
            this.txtReceteNo.Location = new System.Drawing.Point(266, 37);
            this.txtReceteNo.Name = "txtReceteNo";
            this.txtReceteNo.Size = new System.Drawing.Size(107, 24);
            this.txtReceteNo.TabIndex = 29;
            // 
            // btnReceteOlustur
            // 
            this.btnReceteOlustur.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReceteOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceteOlustur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReceteOlustur.Location = new System.Drawing.Point(266, 145);
            this.btnReceteOlustur.Name = "btnReceteOlustur";
            this.btnReceteOlustur.Size = new System.Drawing.Size(107, 38);
            this.btnReceteOlustur.TabIndex = 34;
            this.btnReceteOlustur.Text = "Olustur";
            this.btnReceteOlustur.UseVisualStyleBackColor = false;
            this.btnReceteOlustur.Click += new System.EventHandler(this.btnReceteOlustur_Click);
            // 
            // boxIlacEkle
            // 
            this.boxIlacEkle.BackColor = System.Drawing.Color.PeachPuff;
            this.boxIlacEkle.Controls.Add(this.txtIlacAdet);
            this.boxIlacEkle.Controls.Add(this.label5);
            this.boxIlacEkle.Controls.Add(this.btnIlacYaz);
            this.boxIlacEkle.Controls.Add(this.txtIlacNo);
            this.boxIlacEkle.Controls.Add(this.txtReceteNoIlac);
            this.boxIlacEkle.Controls.Add(this.label3);
            this.boxIlacEkle.Controls.Add(this.label4);
            this.boxIlacEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxIlacEkle.Location = new System.Drawing.Point(507, 339);
            this.boxIlacEkle.Name = "boxIlacEkle";
            this.boxIlacEkle.Size = new System.Drawing.Size(423, 256);
            this.boxIlacEkle.TabIndex = 35;
            this.boxIlacEkle.TabStop = false;
            this.boxIlacEkle.Text = "Reçeteye İlaç Yaz";
            // 
            // btnIlacYaz
            // 
            this.btnIlacYaz.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIlacYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlacYaz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIlacYaz.Location = new System.Drawing.Point(266, 201);
            this.btnIlacYaz.Name = "btnIlacYaz";
            this.btnIlacYaz.Size = new System.Drawing.Size(107, 38);
            this.btnIlacYaz.TabIndex = 34;
            this.btnIlacYaz.Text = "Yaz";
            this.btnIlacYaz.UseVisualStyleBackColor = false;
            this.btnIlacYaz.Click += new System.EventHandler(this.btnIlacYaz_Click);
            // 
            // txtIlacNo
            // 
            this.txtIlacNo.Location = new System.Drawing.Point(266, 96);
            this.txtIlacNo.Name = "txtIlacNo";
            this.txtIlacNo.Size = new System.Drawing.Size(107, 24);
            this.txtIlacNo.TabIndex = 31;
            // 
            // txtReceteNoIlac
            // 
            this.txtReceteNoIlac.Location = new System.Drawing.Point(266, 37);
            this.txtReceteNoIlac.Name = "txtReceteNoIlac";
            this.txtReceteNoIlac.Size = new System.Drawing.Size(107, 24);
            this.txtReceteNoIlac.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "İlaç barkod numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(28, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Reçete numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(28, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "İlaç adedi:";
            // 
            // txtIlacAdet
            // 
            this.txtIlacAdet.Location = new System.Drawing.Point(266, 152);
            this.txtIlacAdet.Name = "txtIlacAdet";
            this.txtIlacAdet.Size = new System.Drawing.Size(107, 24);
            this.txtIlacAdet.TabIndex = 36;
            // 
            // frmRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1147, 617);
            this.Controls.Add(this.boxIlacEkle);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.dtRecete);
            this.Controls.Add(this.boxReceteOlustur);
            this.Name = "frmRecete";
            this.Text = "Reçete İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dtRecete)).EndInit();
            this.boxReceteOlustur.ResumeLayout(false);
            this.boxReceteOlustur.PerformLayout();
            this.boxIlacEkle.ResumeLayout(false);
            this.boxIlacEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRecete;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.GroupBox boxReceteOlustur;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceteNo;
        private System.Windows.Forms.Button btnReceteOlustur;
        private System.Windows.Forms.GroupBox boxIlacEkle;
        private System.Windows.Forms.Button btnIlacYaz;
        private System.Windows.Forms.TextBox txtIlacNo;
        private System.Windows.Forms.TextBox txtReceteNoIlac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIlacAdet;
        private System.Windows.Forms.Label label5;
    }
}
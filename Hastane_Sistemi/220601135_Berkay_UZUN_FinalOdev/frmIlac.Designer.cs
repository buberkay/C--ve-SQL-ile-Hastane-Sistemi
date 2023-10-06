namespace _220601135_Berkay_UZUN_FinalOdev
{
    partial class frmIlac
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
            this.dtIlaclar = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnIlacGoster = new System.Windows.Forms.Button();
            this.boxIlacEkle = new System.Windows.Forms.GroupBox();
            this.btnIlacEkle = new System.Windows.Forms.Button();
            this.picIlac = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlinanIlac = new System.Windows.Forms.TextBox();
            this.boxIlacSorgu = new System.Windows.Forms.GroupBox();
            this.btnIlacAlanlariGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtIlaclar)).BeginInit();
            this.boxIlacEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlac)).BeginInit();
            this.boxIlacSorgu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtIlaclar
            // 
            this.dtIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIlaclar.Location = new System.Drawing.Point(12, 1);
            this.dtIlaclar.Name = "dtIlaclar";
            this.dtIlaclar.RowHeadersWidth = 51;
            this.dtIlaclar.RowTemplate.Height = 24;
            this.dtIlaclar.Size = new System.Drawing.Size(1037, 370);
            this.dtIlaclar.TabIndex = 2;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeriDon.Location = new System.Drawing.Point(1170, 570);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(142, 38);
            this.btnGeriDon.TabIndex = 21;
            this.btnGeriDon.Text = "Ana Sayfa";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(36, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tür:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Barkod numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(36, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "İlaç Adı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(250, 43);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(107, 27);
            this.txtAd.TabIndex = 24;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(250, 151);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(107, 27);
            this.txtTur.TabIndex = 23;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(250, 94);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(107, 27);
            this.txtBarkodNo.TabIndex = 22;
            // 
            // btnIlacGoster
            // 
            this.btnIlacGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlacGoster.Location = new System.Drawing.Point(1100, 179);
            this.btnIlacGoster.Name = "btnIlacGoster";
            this.btnIlacGoster.Size = new System.Drawing.Size(196, 63);
            this.btnIlacGoster.TabIndex = 28;
            this.btnIlacGoster.Text = "Sistemdeki İlaçları Göster";
            this.btnIlacGoster.UseVisualStyleBackColor = true;
            this.btnIlacGoster.Click += new System.EventHandler(this.btnIlacGoster_Click);
            // 
            // boxIlacEkle
            // 
            this.boxIlacEkle.BackColor = System.Drawing.Color.PeachPuff;
            this.boxIlacEkle.Controls.Add(this.btnIlacEkle);
            this.boxIlacEkle.Controls.Add(this.label5);
            this.boxIlacEkle.Controls.Add(this.label3);
            this.boxIlacEkle.Controls.Add(this.label2);
            this.boxIlacEkle.Controls.Add(this.txtAd);
            this.boxIlacEkle.Controls.Add(this.txtTur);
            this.boxIlacEkle.Controls.Add(this.txtBarkodNo);
            this.boxIlacEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxIlacEkle.Location = new System.Drawing.Point(27, 410);
            this.boxIlacEkle.Name = "boxIlacEkle";
            this.boxIlacEkle.Size = new System.Drawing.Size(502, 198);
            this.boxIlacEkle.TabIndex = 29;
            this.boxIlacEkle.TabStop = false;
            this.boxIlacEkle.Text = "İlaç Kayıt";
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIlacEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlacEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIlacEkle.Location = new System.Drawing.Point(405, 145);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(81, 38);
            this.btnIlacEkle.TabIndex = 29;
            this.btnIlacEkle.Text = "Ekle";
            this.btnIlacEkle.UseVisualStyleBackColor = false;
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // picIlac
            // 
            this.picIlac.Image = global::_220601135_Berkay_UZUN_FinalOdev.Properties.Resources.ilac;
            this.picIlac.Location = new System.Drawing.Point(1126, 32);
            this.picIlac.Name = "picIlac";
            this.picIlac.Size = new System.Drawing.Size(146, 130);
            this.picIlac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIlac.TabIndex = 31;
            this.picIlac.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "İlaç barkod numarası:";
            // 
            // txtAlinanIlac
            // 
            this.txtAlinanIlac.Location = new System.Drawing.Point(268, 37);
            this.txtAlinanIlac.Name = "txtAlinanIlac";
            this.txtAlinanIlac.Size = new System.Drawing.Size(107, 22);
            this.txtAlinanIlac.TabIndex = 30;
            // 
            // boxIlacSorgu
            // 
            this.boxIlacSorgu.BackColor = System.Drawing.Color.PeachPuff;
            this.boxIlacSorgu.Controls.Add(this.btnIlacAlanlariGoster);
            this.boxIlacSorgu.Controls.Add(this.label1);
            this.boxIlacSorgu.Controls.Add(this.txtAlinanIlac);
            this.boxIlacSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxIlacSorgu.Location = new System.Drawing.Point(622, 432);
            this.boxIlacSorgu.Name = "boxIlacSorgu";
            this.boxIlacSorgu.Size = new System.Drawing.Size(393, 156);
            this.boxIlacSorgu.TabIndex = 32;
            this.boxIlacSorgu.TabStop = false;
            this.boxIlacSorgu.Text = "İlaç Kullanıcıları";
            // 
            // btnIlacAlanlariGoster
            // 
            this.btnIlacAlanlariGoster.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIlacAlanlariGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlacAlanlariGoster.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIlacAlanlariGoster.Location = new System.Drawing.Point(182, 112);
            this.btnIlacAlanlariGoster.Name = "btnIlacAlanlariGoster";
            this.btnIlacAlanlariGoster.Size = new System.Drawing.Size(193, 38);
            this.btnIlacAlanlariGoster.TabIndex = 30;
            this.btnIlacAlanlariGoster.Text = "Göster";
            this.btnIlacAlanlariGoster.UseVisualStyleBackColor = false;
            this.btnIlacAlanlariGoster.Click += new System.EventHandler(this.btnIlacAlanlariGoster_Click);
            // 
            // frmIlac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1324, 620);
            this.Controls.Add(this.boxIlacSorgu);
            this.Controls.Add(this.picIlac);
            this.Controls.Add(this.boxIlacEkle);
            this.Controls.Add(this.btnIlacGoster);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.dtIlaclar);
            this.Name = "frmIlac";
            this.Text = "İlaç İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dtIlaclar)).EndInit();
            this.boxIlacEkle.ResumeLayout(false);
            this.boxIlacEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlac)).EndInit();
            this.boxIlacSorgu.ResumeLayout(false);
            this.boxIlacSorgu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtIlaclar;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnIlacGoster;
        private System.Windows.Forms.GroupBox boxIlacEkle;
        private System.Windows.Forms.PictureBox picIlac;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlinanIlac;
        private System.Windows.Forms.GroupBox boxIlacSorgu;
        private System.Windows.Forms.Button btnIlacAlanlariGoster;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace _220601135_Berkay_UZUN_FinalOdev
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static Personel personel= new Personel();
        private void btnKayit_Click(object sender, EventArgs e)
        {
            personel.TC = Convert.ToInt32(txtTCKayit.Text);
            personel.sifre = Convert.ToString(txtSifreKayit.Text);
            MessageBox.Show("Personel kaydınız başarıyla oluşturuldu.");
            txtTCKayit.Clear();
            txtSifreKayit.Clear();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if ((Convert.ToInt32(txtTCGiris.Text) == personel.TC) && (txtSifreGiris.Text == personel.sifre))
            {
                frmIslemler frmIslemler = new frmIslemler();
                frmIslemler.Show();
                this.Hide();
                MessageBox.Show("Hoş geldiniz.");

            }
            else
            {
                MessageBox.Show("Bilgilerinizi doğru girdiğinizden emin olun.");
            }
            
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220601135_Berkay_UZUN_FinalOdev
{
    public partial class frmIslemler : Form
    {
        public frmIslemler()
        {
            InitializeComponent();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmMain anasayfa = new frmMain();
            MessageBox.Show("Çıkış Yapılmıştır.");
            this.Hide();
            anasayfa.Show();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            frmHasta frmhasta = new frmHasta();
            frmhasta.Show();
            this.Hide();
        }

        private void btnIlac_Click(object sender, EventArgs e)
        {
            frmIlac frmilac = new frmIlac();
            frmilac.Show();
            this.Hide();
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            frmMuayene frmmuayene = new frmMuayene();
            frmmuayene.Show();
            this.Hide();
        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            frmRecete frmRecete = new frmRecete();
            frmRecete.Show();
            this.Hide();
        }
    }
}

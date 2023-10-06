using Npgsql;
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
    public partial class frmMuayene : Form
    {
        public frmMuayene()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane;User Id=postgres;Password=1234");

        public void MuayeneGoster(string text)
        {
            {
                conn.Open();
                NpgsqlCommand komut = new NpgsqlCommand();
                komut.Connection = conn;
                komut.CommandType = CommandType.Text;
                komut.CommandText = text;
                NpgsqlDataReader dr = komut.ExecuteReader();

                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dtMuayene.DataSource = dt;
                }
                komut.Dispose();
                conn.Close();
            }
        }
        private void btnMuayeneGoster_Click(object sender, EventArgs e)
        {
            MuayeneGoster("select * from muayene");
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmIslemler frmIslemler = new frmIslemler();
            frmIslemler.Show();
            this.Hide();
        }

        private void btnMuayeneEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@muayeneno", txtMuayeneNo.Text);
            komut_ekle.Parameters.AddWithValue("@tc", Convert.ToInt32(txtTC.Text));
            komut_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(txtTarih.Text));
            komut_ekle.Parameters.AddWithValue("@sikayet", txtSikayet.Text);
            komut_ekle.Parameters.AddWithValue("@tani", txtTanı.Text);
            komut_ekle.Parameters.AddWithValue("@tedavi", txtTedavi.Text);
            komut_ekle.Parameters.AddWithValue("@receteno", txtReceteNo.Text);


            komut_ekle.CommandType = CommandType.Text;

            if (txtReceteNo.Text != "")
            {
                komut_ekle.CommandText = "insert into muayene (muayene_no, tc_kimlik_no, tarih, sikayet, tani, tedavi, recete_no) values (@muayeneno, @tc, @tarih, @sikayet, @tani, @tedavi, @receteno)";
            }
            else
            {
                komut_ekle.CommandText = "insert into muayene values (@muayeneno, @tc, @tarih, @sikayet, @tani, @tedavi, @receteno)";
            }

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtMuayene.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            MessageBox.Show("Kayıt başarılı.");
            MuayeneGoster("Select * from muayene");
        }
    }
}

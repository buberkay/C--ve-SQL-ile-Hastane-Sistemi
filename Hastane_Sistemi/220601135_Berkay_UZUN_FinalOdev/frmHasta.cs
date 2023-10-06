using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;

namespace _220601135_Berkay_UZUN_FinalOdev
{
    public partial class frmHasta : Form
    {
        public frmHasta()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane;User Id=postgres;Password=1234");

        public void HastaGoster(string text)
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
                    dtHastalar.DataSource = dt;
                }
                komut.Dispose();
                conn.Close();
            }
        }

        private void btnHastaGoster_Click(object sender, EventArgs e)
        {
            HastaGoster("Select * from hastakimlik");
        }
        public void IlaclariGoster()
        {
            conn.Open();
            NpgsqlCommand komut_goster = new NpgsqlCommand();
            komut_goster.Connection = conn;

            komut_goster.Parameters.AddWithValue("@hastatcilac", Convert.ToInt32(txtHastaninIlaclari.Text));

            komut_goster.CommandType = CommandType.Text;
            komut_goster.CommandText = "SELECT ilac.* FROM muayene INNER JOIN recete_ilac ON muayene.recete_no = recete_ilac.recete_no INNER JOIN ilac ON recete_ilac.barkod_no = ilac.barkod_no WHERE muayene.tc_kimlik_no = @hastatcilac;";

            NpgsqlDataReader dr = komut_goster.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtHastalar.DataSource = dt;
            }
            komut_goster.Dispose();
            conn.Close();
        }

        private void btnKayitOlustur_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@tc", Convert.ToInt32(txtTC.Text));
            komut_ekle.Parameters.AddWithValue("@ad", txtAd.Text);
            komut_ekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut_ekle.Parameters.AddWithValue("@yer", txtDogumYeri.Text);
            komut_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(txtDogumTarihi.Text));
            komut_ekle.Parameters.AddWithValue("@medeni", txtMedeniDurum.Text);
            komut_ekle.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut_ekle.Parameters.AddWithValue("@telefon", Convert.ToInt32(txtTelefon.Text));

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into hastakimlik values (@tc, @ad, @soyad, @yer, @tarih, @medeni, @adres, @telefon)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtHastalar.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            MessageBox.Show("Kayıt başarılı.");
            HastaGoster("Select * from hastakimlik");
            
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmIslemler frmIslemler= new frmIslemler();
            frmIslemler.Show();
            this.Hide();
        }

        private void btnHastaninIlaclarınıGoster_Click(object sender, EventArgs e)
        {
            IlaclariGoster();
        }

        private void txtHastaninIlaclari_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

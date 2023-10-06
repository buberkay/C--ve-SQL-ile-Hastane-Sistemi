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
    public partial class frmIlac : Form
    {
        public frmIlac()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane;User Id=postgres;Password=1234");

        public void IlacGoster(string text)
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
                    dtIlaclar.DataSource = dt;
                }
                komut.Dispose();
                conn.Close();
            }
        }
        public void IlaciAlanlarıGoster()
        {
            conn.Open();
            NpgsqlCommand komut_goster = new NpgsqlCommand();
            komut_goster.Connection = conn;

            komut_goster.Parameters.AddWithValue("@barkod", txtAlinanIlac.Text);

            komut_goster.CommandType = CommandType.Text;
            komut_goster.CommandText = "SELECT hastakimlik.* FROM muayene INNER JOIN recete_ilac ON muayene.recete_no = recete_ilac.recete_no INNER JOIN hastakimlik ON muayene.tc_kimlik_no = hastakimlik.tc_kimlik_no WHERE recete_ilac.barkod_no = @barkod;";

            NpgsqlDataReader dr = komut_goster.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtIlaclar.DataSource = dt;
            }
            komut_goster.Dispose();
            conn.Close();
        }


        private void btnIlacGoster_Click(object sender, EventArgs e)
        {
            IlacGoster("select * from ilac");
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@ad", txtAd.Text);
            komut_ekle.Parameters.AddWithValue("@barkod", txtBarkodNo.Text);
            komut_ekle.Parameters.AddWithValue("@tur", txtTur.Text);

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ilac values (@barkod, @ad, @tur)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtIlaclar.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            MessageBox.Show("Kayıt başarılı.");
            IlacGoster("Select * from ilac");
            MessageBox.Show("İlaç, sisteme kayıt edilmiştir.");
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmIslemler frmIslemler = new frmIslemler();
            frmIslemler.Show();
            this.Hide();
        }

        private void btnIlacAlanlariGoster_Click(object sender, EventArgs e)
        {
            IlaciAlanlarıGoster();
        }
    }
}

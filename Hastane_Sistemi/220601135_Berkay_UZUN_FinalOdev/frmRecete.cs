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
    public partial class frmRecete : Form
    {
        public frmRecete()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=hastane;User Id=postgres;Password=1234");

        public void Goster(string text)
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
                    dtRecete.DataSource = dt;
                }
                komut.Dispose();
                conn.Close();
            }
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmIslemler frmIslemler = new frmIslemler();
            frmIslemler.Show();
            this.Hide();
        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            Goster("select * from recete order by tarih");
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@receteno", txtReceteNo.Text);
            komut_ekle.Parameters.AddWithValue("@tarih", Convert.ToDateTime(txtTarih.Text));

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into recete values (@receteno, @tarih)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dtRecete.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();
            Goster("select * from recete order by tarih");
        }

        private void btnIlacYaz_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIlacAdet.Text) <= 3)
            {
                conn.Open();
                NpgsqlCommand komut_ekle = new NpgsqlCommand();
                komut_ekle.Connection = conn;

                komut_ekle.Parameters.AddWithValue("@receteno", txtReceteNoIlac.Text);
                komut_ekle.Parameters.AddWithValue("@ilacno", txtIlacNo.Text);
                komut_ekle.Parameters.AddWithValue("@adet", Convert.ToInt32(txtIlacAdet.Text));

                komut_ekle.CommandType = CommandType.Text;
                komut_ekle.CommandText = "insert into recete_ilac values (@receteno, @ilacno, @adet)";

                NpgsqlDataReader dr = komut_ekle.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dtRecete.DataSource = dt;
                }
                komut_ekle.Dispose();
                conn.Close();
                MessageBox.Show("İlaç reçeteye eklenmiştir.");
            }
            if (Convert.ToInt32(txtIlacAdet.Text) > 3)
            {
                MessageBox.Show("Bir reçeteye aynı ilaçtan \n3 adetten fazla yazamazsınız!");
            }
        }
    }
}

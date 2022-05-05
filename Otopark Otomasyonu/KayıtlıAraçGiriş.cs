using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public partial class KayıtlıAraçGiriş : Form
    {
        DatabaseConnection con = new DatabaseConnection();
        DatabaseConnection con2 = new DatabaseConnection();
        public KayıtlıAraçGiriş()
        {
            InitializeComponent();
        }
      

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.SqlProcess(string.Format("UPDATE araba SET giris_saati = '{0}',cikis_saati = NULL,park_yeri = '{1}' WHERE plaka = '{2}'", DateTime.Now,park_yeri.SelectedItem.ToString(),plaka.SelectedItem.ToString()));
            con.SqlProcess(string.Format("UPDATE otopark SET otopark_durumu = '{0}' WHERE park_yeri = '{1}'","True", park_yeri.Text.ToString()));


            OtoparkDurumu otoparkDurumu = new OtoparkDurumu();
            otoparkDurumu.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Hide();
        }

        private void KayıtlıAraçGiriş_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlDataReader reader = connection.DataReader(string.Format("SELECT * FROM otopark", connection));
            while (reader.Read())
            {
                if ((bool)reader["otopark_durumu"] == false)
                {
                    park_yeri.Items.Add(reader["park_yeri"]);
                }
            }
            connection.CloseConnection();
            
            SqlDataReader reader1 = connection.DataReader(string.Format("SELECT * FROM musteri", connection));
            while (reader1.Read())
            {
                SqlDataReader reader2 = con2.DataReader(string.Format("SELECT * FROM araba WHERE plaka = '{0}'", reader1["plaka"].ToString()));
                while (reader2.Read())
                {
                    if (reader2["giris_saati"].ToString() == "")
                    {
                        plaka.Items.Add(reader1["plaka"]);
                    }
                }
                con2.CloseConnection();
            }
            con2.CloseConnection();
        }

        private void plaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader = con.DataReader(string.Format("SELECT * FROM musteri WHERE plaka = '{0}'",plaka.SelectedItem.ToString()));
            
            while (reader.Read())
            {
                tc.Text = reader["tc_kimlik_no"].ToString();
                ad.Text = reader["ad"].ToString();
                soyad.Text = reader["soyad"].ToString();
                telefon.Text = reader["telefon"].ToString();
                email.Text = reader["email"].ToString();
                
            }
            con.CloseConnection();
            SqlDataReader readerMarka = con.DataReader(string.Format("SELECT * FROM araba WHERE plaka = '{0}'", plaka.SelectedItem.ToString()));

            while (readerMarka.Read())
            {
                marka.Text = readerMarka["marka"].ToString();
            }
            con.CloseConnection();
            
        }
    }
}

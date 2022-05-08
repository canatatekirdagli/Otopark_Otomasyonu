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
    public partial class Araç_Çıkışcs : Form
    {
        DatabaseConnection con = new DatabaseConnection();
        DatabaseConnection con2 = new DatabaseConnection();
        string pYeri = "";
        int total = 0;
        public Araç_Çıkışcs()
        {
            InitializeComponent();
        }
       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cmbPlaka.SelectedItem != null)
            {
                con.SqlProcess(string.Format("UPDATE araba SET park_yeri = NULL,cikis_saati = '{0}',giris_saati = NULL WHERE plaka = '{1}'", DateTime.Now.ToString(), cmbPlaka.SelectedItem.ToString()));
                con.SqlProcess(string.Format("UPDATE otopark SET otopark_durumu = 'False' WHERE park_yeri = '{0}'", pYeri));
                con.SqlProcess(string.Format("UPDATE cuzdan SET toplam_kazanc += {0}", total));
                MessageBox.Show("Aracın Çıkışı Yapıldı");
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Eksik ya da yanlış bir giriş mevcut kontrol edip tekrar giriş yapınız!!");
            }
        }

        private void Araç_Çıkışcs_Load(object sender, EventArgs e)
        {
            SqlDataReader reader1 = con.DataReader(string.Format("SELECT * FROM musteri", con));
            while (reader1.Read())
            {
                SqlDataReader reader2 = con2.DataReader(string.Format("SELECT * FROM araba WHERE plaka = '{0}'", reader1["plaka"].ToString()));
                while (reader2.Read())
                {
                    if (reader2["giris_saati"].ToString() != "" && reader2["cikis_saati"].ToString() == "")
                    {
                        cmbPlaka.Items.Add(reader1["plaka"]);
                    }
                }
                con2.CloseConnection();
            }
            con.CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader reader = con.DataReader(string.Format("SELECT * FROM musteri WHERE plaka = '{0}'", cmbPlaka.SelectedItem.ToString()));
            int sureToplam = 0;
            int ucret = 0;
            while (reader.Read())
            {
                tc.Text = reader["tc_kimlik_no"].ToString();
                ad.Text = reader["ad"].ToString();
                soyad.Text = reader["soyad"].ToString();
                
            }
            con.CloseConnection();
            SqlDataReader readerMarka = con.DataReader(string.Format("SELECT * FROM araba WHERE plaka = '{0}'", cmbPlaka.SelectedItem.ToString()));
            
            while (readerMarka.Read())
            {
                marka.Text = readerMarka["marka"].ToString();
                giris_tarihi.Text = readerMarka["giris_saati"].ToString();
                SqlDataReader readerSure = con2.DataReader(string.Format("SELECT DATEDIFF(MINUTE,'{0}','{1}') AS 'Sure'",(DateTime)readerMarka["giris_saati"],DateTime.Now.ToString()));
                while (readerSure.Read())
                {
                    sure.Text = readerSure["Sure"].ToString() + " dakika";
                    sureToplam = (int)readerSure["Sure"];
                }
                pYeri = readerMarka["park_yeri"].ToString();
                con2.CloseConnection();
            }
            con.CloseConnection();
            FiyatTarifesi tarife = new FiyatTarifesi(sureToplam);
            toplam_tutar.Text = tarife.UcretHesapla().ToString();
            ucret = tarife.UcretHesapla();
            total = ucret;
        }
    }
}

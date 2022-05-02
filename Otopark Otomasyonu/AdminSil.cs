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
    public partial class AdminSil : Form
    {
        public AdminSil()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show(this);
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            try
            {
                SqlDataReader reader = connection.DataReader("select  * from giris where kullanici_adi='" + kullanici_adi.Text + "'");
                DialogResult sonuc;
                sonuc = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcıyı sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.No)
                {
                }
                if (sonuc == DialogResult.Yes)
                {
                    connection.CloseConnection();
                    connection.SqlProcess("DELETE from giris where kullanici_adi='" + kullanici_adi.Text + "'");
                    MessageBox.Show("Kullanıcı silindi!");
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.Show(this);
                    Hide();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void KullanıcıSil_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlDataReader reader = connection.DataReader(string.Format("SELECT * FROM giris", connection));
            while (reader.Read())
            {
                kullanici_adi.Items.Add(reader["kullanici_adi"]);
            }
            connection.CloseConnection();
        }
    }
}

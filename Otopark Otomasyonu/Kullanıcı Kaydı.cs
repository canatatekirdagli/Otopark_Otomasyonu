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
    public partial class Kullanıcı_Kaydı : Form
    {
        

        public Kullanıcı_Kaydı()
        {
            InitializeComponent();
        }
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DatabaseConnection connection = new DatabaseConnection();
            //kaynakça https://www.kodlamamerkezi.com/c-net/c-ile-sql-server-veritabanina-kayit-ekleme/comment-page-1/#comment-9236
            connection.OpenConnection();
            string kayit = "insert into musteriler(tc_kimlik_no,ad,soyad,telefon,email,plaka,marka,renk,parkyeri) values (@tc_kimlik_no,@ad,@soyad,@telefon,@email,@plaka,@marka,@renk,@parkyeri)";
            SqlCommand command = new SqlCommand(kayit);
            command.Parameters.AddWithValue("@tc_kimlik_no", tc.Text);
            command.Parameters.AddWithValue("@ad", ad.Text);
            command.Parameters.AddWithValue("@soyad", soyad.Text);
            command.Parameters.AddWithValue("@telefon", telefon.Text);
            command.Parameters.AddWithValue("@email", email.Text);
            command.Parameters.AddWithValue("@plaka", plaka.Text);
            command.Parameters.AddWithValue("@marka", marka.Text);
            command.Parameters.AddWithValue("@renk", renk.Text);
            command.Parameters.AddWithValue("@parkyeri", park_yeri.Text);
            command.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            connection.CloseConnection();
            MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            OtoparkDurumu otoparkDurumu = new OtoparkDurumu();
            otoparkDurumu.Show();
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Hide();
        }
       
        private void Kullanıcı_Kaydı_Load(object sender, EventArgs e)
        {
            DatabaseConnection connection = new DatabaseConnection();
            SqlDataReader reader = connection.DataReader(string.Format("SELECT * FROM otopark",connection));
            while (reader.Read())
            {
                park_yeri.Items.Add(reader["park_yeri"]);
            }
            connection.CloseConnection();
            SqlDataReader reader1 = connection.DataReader(string.Format("SELECT * FROM marka", connection));
            while (reader1.Read())
            {
                marka.Items.Add(reader1["marka"]);
            }
            connection.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void marka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

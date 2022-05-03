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

        public KayıtlıAraçGiriş()
        {
            InitializeComponent();
        }
      

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
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
                plaka.Items.Add(reader1["plaka"]);
            }
            connection.CloseConnection();
        }

        private void plaka_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* DatabaseConnection connection = new DatabaseConnection();
            SqlDataReader reader = connection.DataReader(string.Format("select * from musteri where plaka='" + plaka + "'", connection));
            while (reader.Read())
            {
                tc.Text = reader[0].ToString();

                ad.Text = reader[1].ToString();

                soyad.Text = reader[2].ToString();

                telefon.Text = reader[3].ToString();

                email.Text = reader[4].ToString();

                //marka.Text = reader["marka"].ToString();
            }
            connection.CloseConnection();*/
        }
    }
}
